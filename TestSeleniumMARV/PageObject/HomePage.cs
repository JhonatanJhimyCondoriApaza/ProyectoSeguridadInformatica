using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumMARV.Handler;

namespace TestSeleniumMARV.PageObject
{
    /*
     * Esta clase representa la página de registro de categorias
     */
    public class HomePage
    {
        //Selenium Driver
        protected IWebDriver Driver;
        //Localizadores
        protected By Div = By.Id("MenuNavegacion");
        //Constructor. Lanza una excepcion si el titulo de la página de categorias no es el correcto.
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            if(!Driver.Title.Equals("Home Page - Mi aplicación ASP.NET"))
            {
                throw new Exception("This is not the Home page");
            }
        }
        //Metodo para detectar si el Div del menú esta cargado
        //Retornara true si el elemento del div esta presente sino retorna false
        public bool DivIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, Div);
        }
    }
}
