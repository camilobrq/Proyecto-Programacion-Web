using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogicaServices
{
    public class SeleniumTests
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        public void Test()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Assert.Pass();
        }
    }
}
