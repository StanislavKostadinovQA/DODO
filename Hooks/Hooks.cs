using OpenQA.Selenium;
using SpecFlowProject2.WaitHelper;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.Hooks
{
    [Binding]
    public class Hooks { 

        private static IWebDriver driver;
        private readonly WaitHelper _waitHelper;

        public Hooks()
        {
            driver = DriverManager.GetDriver();
            _waitHelper = new WaitHelper();
        }

        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
           
            

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            //driver.Dispose();
        }

        [AfterTestRun]
        public static void AfterTestRun() {

            driver.Close();
            driver.Dispose(); 
        }

        private void ClickAcceptCookieButton()
        {
            try
            {
                IWebElement AcceptCookieButton = driver.FindElement(By.XPath("//*[@data-cky-tag='accept-button']]"));
                _waitHelper.WaitForElementToBeVisible(driver, AcceptCookieButton);
                AcceptCookieButton.Click();
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
