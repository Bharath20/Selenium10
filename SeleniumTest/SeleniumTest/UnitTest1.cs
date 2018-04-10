using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver("C:\\Drivers");
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(8000);
            driver.FindElement(By.Name("q")).SendKeys("Jishnupottans");
            driver.FindElement(By.Name("q")).Submit();
            driver.Quit();
        }
    }
}
