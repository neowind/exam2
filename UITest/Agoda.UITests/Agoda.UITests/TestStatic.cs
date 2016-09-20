using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace Agoda.UITests
{
    class TestStatic
    {
        private IWebDriver WebDriver;
        private string fullPath;

        private bool WebReady(IWebDriver WebDriver)
        {
            WebDriver.SwitchTo().DefaultContent();
            string documentState = WebDriver.ExecuteJavaScript<string>("return document.readyState");

            return documentState == "complete";
        }

        [SetUp]
        public void setup()
        {
            fullPath = Directory.GetCurrentDirectory() + "\\Agoda.UITests\\Support";

            WebDriver = new ChromeDriver(fullPath);
            WebDriver.Navigate().GoToUrl("http://localhost:59106/default/static");
        }

        [TearDown]
        public void tearDown()
        {
            WebDriver.Close();
        }

        [Test]
        public void InitPage()
        {
            int retried = 0;

            while (!(WebReady(WebDriver)) && retried < 10)
            {
                System.Threading.Thread.Sleep(1000);
                retried++;
            }

            if (retried < 10)
            {

                Assert.That(() => WebDriver.FindElement(By.TagName("button")),
                Throws.TypeOf<OpenQA.Selenium.NoSuchElementException>());
            }
        }

        [Test]
        public void checkResultStatic()
        {
            int retried = 0;

            while (!(WebReady(WebDriver)) && retried < 10)
            {
                System.Threading.Thread.Sleep(1000);
                retried++;
            }

            if (retried < 10)
            {
                var rows = WebDriver.FindElements(By.CssSelector("tr.data"));

                Assert.That(rows.Count == 2);
                Assert.That(rows[0].FindElement(By.CssSelector("td:first-child")).Text == "Dusit Thani Hotel Pattaya");
                Assert.That(rows[1].FindElement(By.CssSelector("td:first-child")).Text == "Hard Rock Hotel Pattaya");
            }
        }
    }
}
