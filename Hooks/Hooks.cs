using OpenQA.Selenium;
using SpecFlowProject2.WaitHelper;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        private static IWebDriver _driver;
        private readonly WaitHelper _waitHelper;

        public Hooks()
        {
            if (_driver == null)
            {
                _driver = DriverManager.GetDriver();
            }
            _waitHelper = new WaitHelper();
        }

        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // driver.Quit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }

        private void ClickAcceptCookieButton()
        {
            try
            {
                IWebElement acceptCookieButton = _driver.FindElement(By.XPath("//*[@data-cky-tag='accept-button']"));
                _waitHelper.WaitForElementToBeVisible(_driver, acceptCookieButton);
                acceptCookieButton.Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("AcceptCookieButton button not found. Skipping click.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while clicking consent button: {ex.Message}");
            }
        }
    }
}
