using AmazingScraper.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingScraper
{
    public class Scraper
    {
        private static int GearNumber { get; set; }

        public static string GearBar()
        {
            switch (GearNumber)
            {
                case 1: return " | ";
                case 2: return " / ";
                case 3: return "-- ";
                case 4: return "\\ ";
                default:return " | ";
            }            
        }

        private void AddGear()
        {
            GearNumber++;

            if (GearNumber == 5)
                GearNumber = 1;
           var form = Application.OpenForms[0] as MainForm;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            form.InsertBar = GearBar();
        }       

        public void Scrape(string userParam, string passwordParam, string searchParams)
        {
            
            bool LoggedIn = false;

            string BaseDir = "c:\\Scraping";

            if (!Directory.Exists(BaseDir))
            {
                Directory.CreateDirectory(BaseDir);
            }

            int id = 0;

            #region Default Login

            if (string.IsNullOrEmpty(userParam))
                userParam = "angeles.ladigan@gmail.com";

            if (string.IsNullOrEmpty(passwordParam))
                passwordParam = "DekoTommy0904";

            #endregion

            string[] array = searchParams.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var options = new ChromeOptions();
            options.AddArguments("headless");            

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            var driver = new ChromeDriver(driverService, options);       

            foreach (string searchParam in array)
            {
                #region Login

                if (!LoggedIn)
                {
                    //Go to amazon.es and click sign in
                    driver.Url = "https://www.amazon.es/";
                    driver.FindElement(By.CssSelector("#nav-link-accountList > div > span")).Click();
                    AddGear();
                    //Fill email and click
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    var user = driver.FindElement(By.CssSelector("#ap_email"));
                    user.SendKeys(userParam);
                    driver.FindElement(By.CssSelector("#continue")).Click();
                    AddGear();
                    //Fill password and click
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    var password = driver.FindElement(By.CssSelector("#ap_password"));
                    password.SendKeys(passwordParam);
                    driver.FindElement(By.CssSelector("#auth-signin-button")).Click();
                    LoggedIn = true;
                    AddGear();
                }

                #endregion

                #region Búsqueda y filtro

                //Fill search
                driver.Url = "https://www.amazon.es/";
                AddGear();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
                searchBox.SendKeys(searchParam);
                driver.FindElement(By.CssSelector("#nav-search > form > div.nav-right > div > input")).Click();
                AddGear();
                Thread.Sleep(2000);
                AddGear();
                //Ir a novedades
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.CssSelector("#a-autoid-7")).Click();
                AddGear();
                driver.FindElement(By.CssSelector("#s-result-sort-select_4")).Click();
                AddGear();

                //Cargar todos los productos de la primera página
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                Thread.Sleep(2000);
                var webElements = driver.FindElements(By.XPath(".//*[@data-component-type='s-search-result']"));
                AddGear();
                //Removemos patrocinados

                var filteredElements = webElements.Where(z => !z.Text.Contains("Patrocinado"));
                AddGear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Id,Link,Producto,Características,Valoración,Precio,Precio Envío,Descripción,Link Imagen,Link Afiliado");

                var linkList = new List<string>();
                AddGear();
                foreach (var webElement in filteredElements)
                {
                    AddGear();
                    var linkTag = webElement.FindElement(By.TagName("a")).GetAttribute("href");

                    if (!linkTag.Contains("bestsellers")) linkList.Add(linkTag);
                }

                #endregion
                AddGear();
                foreach (string link in linkList.Take(3))
                {
                    AddGear();
                    driver.Url = link;
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Thread.Sleep(2000);
                    driver.FindElement(By.CssSelector("#amzn-ss-text-link > span > span > strong > a")).Click();

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
                    wait.Until(drv => drv.FindElement(By.ClassName("amzn-ss-text-shortlink-textarea")).Displayed);
                    var linkAfiliado = driver.FindElement(By.ClassName("amzn-ss-text-shortlink-textarea")).Text;

                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(200);
                    bool poseeNombre = driver.FindElements(By.CssSelector("#productTitle")).Count() > 0;
                    AddGear();
                    bool poseeDescripcion = driver.FindElements(By.CssSelector("#productDescription")).Count() > 0;
                    AddGear();
                    bool poseePrecio = driver.FindElements(By.CssSelector("#price_inside_buybox")).Count() > 0;
                    AddGear();
                    bool poseePrecioEnvio = driver.FindElements(By.CssSelector("#price-shipping-message")).Count() > 0;
                    AddGear();
                    bool poseeValoracion = driver.FindElements(By.CssSelector("#acrPopover")).Count() > 0;
                    AddGear();
                    bool poseeImagen = driver.FindElements(By.CssSelector("#landingImage")).Count() > 0;
                    AddGear();
                    bool poseeCaracteristicas = driver.FindElements(By.CssSelector("#feature-bullets")).Count() > 0;

                    id += 1;

                    #region Init vars
                    string descripcion = "";
                    string valoracion = "";
                    string precio = "";
                    string precioEnvio = "";
                    string nombreProducto = "";
                    string linkImagen = "";
                    string caracteristicas = "";
                    #endregion

                    string FullDir = BaseDir + "\\" + searchParam;

                    if (!Directory.Exists(FullDir))
                    {
                        Directory.CreateDirectory(FullDir);
                        id = 1;
                    }

                    #region Validaciones

                    if (poseeNombre)
                        nombreProducto = driver.FindElement(By.CssSelector("#productTitle")).Text;

                    if (poseeDescripcion)
                        descripcion = driver.FindElement(By.CssSelector("#productDescription")).Text;

                    if (poseeValoracion)
                        valoracion = driver.FindElement(By.CssSelector("#acrPopover")).GetAttribute("Title");

                    if (poseePrecio)
                        precio = driver.FindElement(By.CssSelector("#price_inside_buybox")).Text;

                    if (poseePrecioEnvio)
                        precioEnvio = driver.FindElement(By.CssSelector("#price-shipping-message")).Text;

                    if (poseeCaracteristicas)
                        caracteristicas = driver.FindElement(By.CssSelector("#feature-bullets")).Text;

                    if (poseeImagen)
                    {
                        linkImagen = driver.FindElement(By.CssSelector("#landingImage")).GetAttribute("src");
                        ImageDownloader.DownloadImageFromUrl(linkImagen).Save(FullDir + "\\" + id + " - " + searchParam + ".jpg");
                    }

                    #endregion

                    #region Appends
                    //Id,Link,Producto,Características,Valoración,Precio,Precio Envío,Descripción,Link Imagen,Link Afiliado.
                    AddGear();
                    sb.AppendLine( "\"" + id + "\","
                                 + "\"" + link + "\","
                                 + "\"" + nombreProducto + "\","
                                 + "\"" + caracteristicas + "\","
                                 + "\"" + valoracion + "\","
                                 + "\"" + precio + "\","
                                 + "\"" + precioEnvio + "\","
                                 + "\"" + descripcion + "\","
                                 + "\"" + linkImagen + "\","
                                 + "\"" + linkAfiliado + "\"");

                    string s = sb.ToString();
                    AddGear();
                    #endregion

                    System.IO.File.WriteAllText(FullDir + "\\scrap.csv", s);

                }                
            }
            driver.Dispose();
            
        }
    }
}