using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumMARV.PageObject
{
    /*
     * Esta clase representa la página de inicio de sesion*/
    internal class LoginPage
    {
        //Selenium driver
        protected IWebDriver Driver;
        //Localizadores
        protected By EmailInput = By.Id("EmailAdmin");
        protected By PasswordInput = By.Id("PassAdmin");
        protected By LoginButton = By.Id("BtnLoginAdmin");
        //Constructor. Lanza una excepcion si el titulo de la pagina del login no es el correcto
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            if(!Driver.Title.Equals("Inicio de sesión para administradores en Ferreland"))
            {
                throw new Exception("This is not the login Page");
            }
        }
        //Metodo para escribir el email
        public void TypeEmail(string email)
        {
            Driver.FindElement(EmailInput).SendKeys(email);
        }
        //Metodo para escribir el password
        public void TypePassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }
        //Metodo para hacer click en el boton del login
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }
        //Metodo para loguearse. Retorna la pagina del formulario de Categoria
        public HomePage LoginAs(string email, string password)
        {
            TypeEmail(email);
            TypePassword(password);
            ClickLoginButton();
            return new HomePage(Driver);
        }

    }
}
