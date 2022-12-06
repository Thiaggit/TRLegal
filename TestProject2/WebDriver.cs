using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shared;

namespace TestProject2
{
    public sealed class WebDriverSingleton
    {
        private static IWebDriver instance = null;
        private WebDriverSingleton() { }

        public static IWebDriver GetInstance()
        {
            if(instance==null)
            {
                CommonLogic commonLogic = new CommonLogic();
                instance = new ChromeDriver(".");
            }
            return instance;
        }
    }
}