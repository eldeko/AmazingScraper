using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingScraper.Models
{
    public class Producto
    {
        private readonly IWebDriver _driver;

        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionTecnica { get; set; }
        public string ImagenLink { get; set; }
        public string AfiliadoLink { get; set; }
        public List<string>Opiniones{ get; set; }
        public int Estrellitas { get; set; }
    }
}
