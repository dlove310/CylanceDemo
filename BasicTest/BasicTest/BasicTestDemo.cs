using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicTest
{
    class BasicTestDemo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\david\\Test");
        }

        [Test]
        public void Test()
        {
            //Set vars
            var username = "test@test.com";
            var password = "testpassword";

            //Initiate Test
            driver.Url = "https://partner.cylance.com/s/login/";

            //Run Test Actions
            driver.FindElement(By.CssSelector("#sfdc_username_container input"))
                .SendKeys(username);
            driver.FindElement(By.CssSelector("#sfdc_password_container input"))
                .SendKeys(password);
            driver.FindElement(By.CssSelector(".loginButton"))
                .Click();

            //Assert Results
            var result = driver.FindElement(By.CssSelector(".error div")).Text;
            Assert.AreEqual("Your login attempt has failed. Make sure the username and password are correct.", result);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
