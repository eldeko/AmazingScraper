using AmazingScraper.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingScraper
{
    public class Scraper
    {
        private static int GearNumber { get; set; }
        public static bool GreenLight { get; set; }
        public static bool Working { get; private set; }
        public static string GearBar()
        {
            switch (GearNumber)
            {
                case 1: return " | ";
                case 2: return " / ";
                case 3: return "-- ";
                case 4: return "\\ ";
                default: return " | ";
            }
        }

        private static void AddGear()
        {
            GearNumber++;

            if (GearNumber == 5)
                GearNumber = 1;
            var form = Application.OpenForms[0] as MainForm;
            Control.CheckForIllegalCrossThreadCalls = false;
            form.InsertBar = GearBar();
        }

        public void Scrape(string userParam, string passwordParam, string searchParams, bool showChrome)
        {

            Working = true;
            ClockGear();
            GreenLight = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            bool LoggedIn = false;

            string BaseDir = "c:\\Scraping";


            if (!Directory.Exists(BaseDir))
            {
                TextBox.CheckForIllegalCrossThreadCalls = false;
                Console.WriteLine("Creando Directorio Base");
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
            Console.WriteLine("Abriendo navegador");
            var options = new ChromeOptions();

            if (!showChrome)
                options.AddArguments("headless");

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            var driver = new ChromeDriver(driverService, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            foreach (string searchParam in array)
            {
                #region Login

                if (!LoggedIn && GreenLight)
                {
                    AddGear();
                    //Go to amazon.es and click sign in
                    Console.WriteLine("Ingresando a Amazon.es");
                    driver.Url = "https://www.amazon.es/";
                    Console.WriteLine("Click en Login");
                    driver.FindElement(By.CssSelector("#nav-link-accountList > div > span")).Click();
                    AddGear();
                    //Fill email and click
                    Console.WriteLine("Ingresando usuario");
                    var user = driver.FindElement(By.CssSelector("#ap_email"));
                    user.SendKeys(userParam);
                    driver.FindElement(By.CssSelector("#continue")).Click();
                    AddGear();
                    //Fill password and click
                    Console.WriteLine("Ingresando Contraseña");
                    var password = driver.FindElement(By.CssSelector("#ap_password"));
                    password.SendKeys(passwordParam);
                    driver.FindElement(By.CssSelector("#auth-signin-button")).Click();
                    LoggedIn = true;
                    AddGear();
                }

                #endregion

                #region Búsqueda y filtro
                if (GreenLight)
                {
                    //Fill search
                    Console.WriteLine("Ingresando en Amazon.es");
                    driver.Url = "https://www.amazon.es/";
                    AddGear();
                    Thread.Sleep(2000);
                    var searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
                    Console.WriteLine("Ingresando búsqueda");
                    searchBox.SendKeys(searchParam);
                    searchBox.SendKeys(OpenQA.Selenium.Keys.Return);
                    //driver.FindElement(By.CssSelector("#nav-search > form > div.nav-right > div > input")).Click();
                    AddGear();
                    Thread.Sleep(2000);
                    AddGear();
                    //Ir a novedades
                    Console.WriteLine("Ordenando por novedades");

                    driver.FindElement(By.CssSelector("#a-autoid-7")).Click();
                    AddGear();
                    driver.FindElement(By.CssSelector("#s-result-sort-select_4")).Click();
                    AddGear();

                    //Cargar todos los productos de la primera página
                    Thread.Sleep(2000);
                    Console.WriteLine("Creando lista de productos");
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
                    if (GreenLight)
                        foreach (string link in linkList)
                        {
                            if (GreenLight)
                            {
                                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
                                AddGear();
                                Console.WriteLine("Ingresando a producto");
                                driver.Url = link;
                                Thread.Sleep(2000);
                                driver.FindElement(By.CssSelector("#amzn-ss-text-link > span > span > strong > a")).Click();

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
                                    Console.WriteLine("Creando directorio de búsqueda");
                                    Directory.CreateDirectory(FullDir);
                                    id = 1;
                                }

                                #region Validaciones

                                if (poseeNombre)
                                    nombreProducto = driver.FindElement(By.CssSelector("#productTitle")).Text;
                                Console.WriteLine("Obteniendo Nombre");

                                if (poseeDescripcion)
                                    descripcion = driver.FindElement(By.CssSelector("#productDescription")).Text;
                               descripcion = RemoveCarriageReturn(descripcion);
                                Console.WriteLine("Obteniendo Descripción");

                                if (poseeValoracion)
                                    valoracion = driver.FindElement(By.CssSelector("#acrPopover")).GetAttribute("Title");
                                Console.WriteLine("Obteniendo Valoración");

                                if (poseePrecio)
                                    precio = driver.FindElement(By.CssSelector("#price_inside_buybox")).Text;
                                Console.WriteLine("Obteniendo Precio");

                                if (poseePrecioEnvio)
                                    precioEnvio = driver.FindElement(By.CssSelector("#price-shipping-message")).Text;
                                Console.WriteLine("Obteniendo Costo de envío");

                                if (poseeCaracteristicas)
                                    caracteristicas = driver.FindElement(By.CssSelector("#feature-bullets")).Text;
                                    RemoveCarriageReturn(caracteristicas);
                                Console.WriteLine("Obteniendo Características");

                                if (poseeImagen)
                                {
                                    Console.WriteLine("Descargando Imagen");
                                    linkImagen = driver.FindElement(By.CssSelector("#landingImage")).GetAttribute("src");
                                    ImageDownloader.DownloadImageFromUrl(linkImagen).Save(FullDir + "\\" + id + " - " + searchParam + ".jpg");
                                    Console.WriteLine("Imagen descargada");
                                }

                                #endregion

                                #region Appends
                                //Id,Link,Producto,Características,Valoración,Precio,Precio Envío,Descripción,Link Imagen,Link Afiliado.
                                AddGear();
                                sb.AppendLine("\"" + id + "\","
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
                                Console.WriteLine("Guardando CSV...");
                                System.IO.File.WriteAllText(FullDir + "\\scrap.csv", s);
                                Console.WriteLine("Guardado");
                                Console.WriteLine("");
                            }
                        }
                    else
                    {
                        Console.WriteLine("Cancelado por usuario");
                    }
                }
            }
            Console.WriteLine("Cerrando navegador");
            driver.Close();
            driver.Quit();
            Console.WriteLine("Terminado");
            Working = false;
            var form = Application.OpenForms[0] as MainForm;

            form.InsertBar = "--";
        }

        private static string RemoveCarriageReturn(string blockOfText)
        {
            string processedString = blockOfText
                .Replace(" "+Environment.NewLine, ". ")
                .Replace(Environment.NewLine, ". ")
                .Replace("..", ".")
                .Replace("› Ver más detalles", "");

            return processedString;
        }

        public static async Task ClockGear()
        {
            await Task.Run(() =>
            {
                while (Working)
                {
                    AddGear();
                    Thread.Sleep(500);
                }              
            });
        }
    }
}