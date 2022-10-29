using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestLogicaServices
{
    public class SeleniumTestTotal
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        /*
        [Test]
        public void TextPruebaClickLoguin()
        {
           
            driver.Navigate().GoToUrl("https://localhost:5001/login");
            Thread.Sleep(7000);
            IWebElement btnLoguin= driver.FindElement(By.ClassName("btn-primary"));
            btnLoguin.Click();
            Assert.Pass();
        }*/
        [TestCase("camilo", "123","Credenciales Correctos", TestName ="usuarioValido")]
        //[TestCase("camilo", "1234", "Credenciales incorrectos", TestName = "usuarioValido")]
        [Test]
        public void TestIngresoLoguin(string usuario, string contrasena, string resultado)
        {

            driver.Navigate().GoToUrl("https://localhost:5001/login");
            Thread.Sleep(7000);
            IWebElement textUser = driver.FindElement(By.Id("usuario"));
            textUser.SendKeys(usuario);
            IWebElement textContrasena = driver.FindElement(By.Id("contrasena"));
            textContrasena.SendKeys(contrasena);
            Thread.Sleep(7000);
            IWebElement btnLoguin = driver.FindElement(By.ClassName("btn-primary"));
            btnLoguin.Click();
          /*  Thread.Sleep(3000);
            IWebElement */
        }
    }
}