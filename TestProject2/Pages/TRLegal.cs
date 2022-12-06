using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shared;

namespace TestProject2
{
    [SetUpFixture]
    public class TRLegal
    {
        IWebDriver webDriver;

        [SetUp]
        public void Start()
        {
            CommonLogic commonlogic = new CommonLogic();
            webDriver = webdriverSingleton.GetInstance();
            webDriver.Url = commonlogic.GetAppUrl();
        }


        [Test]
        public void Test()
        {
            IWebElement products = webDriver.FindElement(By.XPath("//span[contains(text(),'Products')]"));
            products.Click();

            IWebElement practicalLaw = webDriver.FindElement(By.XPath("//span[contains(text(),'Practical Law')]"));
            practicalLaw.Click();

            IWebElement viewPlans = webDriver.FindElement(By.XPath("//a[@aria-label=\'View plans\']"));
            viewPlans.Click();

            IWebElement generalCounsel = webDriver.FindElement(By.XPath("//label[contains(text(),'General counsel Selected']"));
            bool elementSelected = generalCounsel.Selected.Equals(true);

            IWebElement noOfSeats = webDriver.FindElement(By.Id("Numberofseats"));
            noOfSeats.SendKeys("5");

            IWebElement duration = webDriver.FindElement(By.Id("duration");
            duration.SendKeys("5");
        }

        public static bool IsSelected(this IWebElement element)
        {
            var webElement = element.FindElement(By.TagName("input"));
            return Convert.ToBoolean(webElement.GetAttribute("aria-Checked"));
        }


        [OneTimeTearDown]
        public void RunAfterAllTests()
        {
           //webDriver.Close();
        }
    }
}