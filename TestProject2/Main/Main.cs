using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shared;

namespace TestProject2
{
    [SetUpFixture]
    public class Main
    {
        IWebDriver webDriver;

        [OneTimeSetUp]
        public void RunBeforeAllTests()
        {
            CommonLogic commonlogic = new CommonLogic();
            webDriver = webdriverSingleton.GetInstance();
            webDriver.Url = commonlogic.GetAppUrl();
        }


        [OneTimeTearDown]
        public void RunAfterAllTests()
        {
           //webDriver.Close();
        }
    }
}