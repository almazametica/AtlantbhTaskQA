using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;


namespace ContactListApp

{
    [TestClass]
    public class Contacts
    {
        [TestMethod]
        public void Smoke()
        {

            var driverDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            IWebDriver driver = new ChromeDriver(driverDir);
            driver.Navigate().GoToUrl("https://thinking-tester-contact-list.herokuapp.com/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            driver.FindElement(By.Id("signup")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("firstName")).SendKeys("Tester");
            driver.FindElement(By.Id("lastName")).SendKeys("Tester");

            Random randomGenerator = new Random();
            int randomInt = (int)randomGenerator.NextInt64(1000);
            driver.FindElement(By.Id("email")).SendKeys("test" + randomInt + "@gmail.com");

            driver.FindElement(By.Id("password")).SendKeys("1234567");
            driver.FindElement(By.Id("submit")).Click();

            driver.FindElement(By.Id("logout")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("email")).SendKeys("alma@zametica.com");
            driver.FindElement(By.Id("password")).SendKeys("1234567");
            driver.FindElement(By.Id("submit")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("add-contact")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Test");
            driver.FindElement(By.Id("lastName")).SendKeys("Test");
            driver.FindElement(By.Id("birthdate")).SendKeys("1990-10-22");
            driver.FindElement(By.Id("street1")).SendKeys("Happy street");
            driver.FindElement(By.Id("street2")).SendKeys("Lucky street");
            driver.FindElement(By.Id("city")).SendKeys("Sa");
            driver.FindElement(By.Id("stateProvince")).SendKeys("KS");
            driver.FindElement(By.Id("postalCode")).SendKeys("1234");
            driver.FindElement(By.Id("country")).SendKeys("BiH");
            driver.FindElement(By.Id("submit")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//*[@id=\"myTable\"]/tr[1]/td[2]")).Click();
            driver.FindElement(By.Id("edit-contact")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("firstName")).SendKeys("abc");
            driver.FindElement(By.Id("lastName")).SendKeys("abc");
            driver.FindElement(By.Id("submit")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("return")).Click();
            driver.FindElement(By.XPath("//*[@id=\"myTable\"]/tr[1]/td[2]")).Click();
            driver.FindElement(By.Id("delete")).Click();
            driver.SwitchTo().Alert().Accept();

        }
    }
}