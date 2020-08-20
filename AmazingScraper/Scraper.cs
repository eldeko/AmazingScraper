using AmazingScraper.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static bool GreenLight { get; set; }
        public static bool Working { get; private set; }

        int id = 0;      

        public void Scrape(string userParam, string passwordParam, string searchParams, bool showChrome, bool oneCsv)
        {
            Working = true;
            ClockGear();
            GreenLight = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            bool LoggedIn = false;
            string baseDir = "c:\\Scraping";         

            SetBaseDir(baseDir);
            string fechaString = DateTime.Now.ToString("yyyy-MM-dd hh.mm");

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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(10000));
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id,Link,Producto,Características,Valoración,Precio,Precio Envío,Descripción,Link Imagen,Link Afiliado");

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
                    wait.Until(drv => drv.FindElement(By.CssSelector("#nav-link-accountList > div > span")).Displayed);
                    driver.FindElement(By.CssSelector("#nav-link-accountList > div > span")).Click();
                    AddGear();
                    //Fill email and click
                    Console.WriteLine("Ingresando usuario");
                    wait.Until(drv => drv.FindElement(By.CssSelector("#ap_email")).Displayed);
                    var user = driver.FindElement(By.CssSelector("#ap_email"));
                    user.SendKeys(userParam);
                    driver.FindElement(By.CssSelector("#continue")).Click();
                    AddGear();
                    //Fill password and click
                    Console.WriteLine("Ingresando Contraseña");
                    wait.Until(drv => drv.FindElement(By.CssSelector("#ap_password")).Displayed);
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
                    Console.WriteLine("Ingresando a Amazon.es");
                    driver.Url = "https://www.amazon.es/";
                    AddGear();
                    Thread.Sleep(2000);
                    var searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
                    Console.WriteLine("Ingresando búsqueda");
                    searchBox.SendKeys(searchParam);
                    searchBox.SendKeys(OpenQA.Selenium.Keys.Return);
                   
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

                    if (!oneCsv)
                    {
                        sb.Clear();
                        sb.AppendLine("Id,Link,Producto,Características,Valoración,Precio,Precio Envío,Descripción,Link Imagen,Link Afiliado");
                    }

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
                        foreach (string link in linkList.Take(2))
                        {
                            if (GreenLight)
                            {
                                
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
                                string descripcion = ""; string valoracion = ""; string precio = ""; string precioEnvio = "";
                                string nombreProducto = ""; string linkImagen = ""; string caracteristicas = "";
                                #endregion

                                string fullDir = baseDir + "\\" + searchParam;

                                CreateFullDir(fullDir);

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
                                    caracteristicas = RemoveCarriageReturn(caracteristicas);
                                Console.WriteLine("Obteniendo Características");
 #endregion

                                if (poseeImagen)
                                {
                                    Console.WriteLine("Descargando Imagen");
                                    linkImagen = driver.FindElement(By.CssSelector("#landingImage")).GetAttribute("src");
                                    ImageDownloader.DownloadImageFromUrl(linkImagen).Save(fullDir + "\\" + searchParam + " - " + id + ".jpg");
                                    Console.WriteLine("Imagen descargada");
                                }                               

                                #region Appends
                              
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

                                string fileNameWithDate = "";

                                if (oneCsv)
                                {
                                    fileNameWithDate = baseDir + "\\" + fechaString + ".csv";
                                }
                                else
                                {
                                    fileNameWithDate = fullDir + "\\" + searchParam + " " + fechaString + ".csv";
                                }
                                File.WriteAllText(fileNameWithDate, s);
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
            KillChromeDriver();
            Console.WriteLine("Terminado");
            Working = false;
            var form = Application.OpenForms[0] as MainForm;

            form.InsertBar = "--";
        }

        private void KillChromeDriver()
        {
            var chromeDriverProcesses = Process.GetProcesses().Where(pr => pr.ProcessName == "chromedriver");

            foreach (var process in chromeDriverProcesses)
            {
                process.Kill();
            }
        }

        private void CreateFullDir(string fullDir)
        {
            if (!Directory.Exists(fullDir))
            {
                Console.WriteLine("Creando directorio de búsqueda");
                Directory.CreateDirectory(fullDir);
                id = 1;
            }
        }

        private void SetBaseDir(string baseDir)
        {           
            if (!Directory.Exists(baseDir))
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                Console.WriteLine("Creando Directorio Base");
                Directory.CreateDirectory(baseDir);
            }
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

        private static void AddGear()
        {
            GearNumber++;

            if (GearNumber == 5)
                GearNumber = 1;
            var form = Application.OpenForms[0] as MainForm;
            Control.CheckForIllegalCrossThreadCalls = false;
            form.InsertBar = GearBar();
        }

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
    }
}