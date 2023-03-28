using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumMARV.PageObject;

namespace TestSeleniumMARV.TestCase
{
    [TestFixture]
    public class LoginTest
    {
        protected IWebDriver Driver;
        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://localhost:44331/");
            //Driver.Navigate().GoToUrl("https://verstnadqa.com/ejercicios/");
        }

        [Test]
        public void SuccesfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            HomePage homePage = loginPage.LoginAs("mrocabado321@gmail.com", "mrock123");
            Assert.IsTrue(homePage.DivIsPresent());
        }
        [TearDown]
        public void AfterTest()
        { 
            if(Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}
