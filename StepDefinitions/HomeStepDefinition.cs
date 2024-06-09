using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowProject2.Hooks;
using SpecFlowProject2.PageObjects;
using TechTalk.SpecFlow;


namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class HomeStepDefinition 
    {
        private IWebDriver _driver;
        private WaitHelper.WaitHelper _waitHelper;
        private HomePage _homePage;
        private Urls _url;
        private ContactPage _contactPage;
       

        public HomeStepDefinition() {

            _driver = BasePage.BasePage.GetDriver();
            _waitHelper = new WaitHelper.WaitHelper();
            _url = new Urls();
            _homePage = new HomePage();
            _contactPage = new ContactPage();
        }

        [Given(@"I navigate to Home page")]
        public void GivenINavigateToHomePage()
        {
            _homePage.NavigateTo(_driver,_url.HomePageURL);
            _waitHelper.WaitForPageToLoad(_driver);
        }
            
        [When(@"I am on the Home Page")]
        public void WhenIAmOnTheHomePage()
        {
            Thread.Sleep(3500); //TODO
            _homePage.ClickElement("AcceptCookieButton");
        }

        [When(@"I Navigate to Contact Page")]
        public void WhenINavigateToContactPage()
        {
            _homePage.ClickElement("ContactPageHeaderLink");
        }


        [When(@"I scroll the to footer")]
        public void WhenIScrollTheToFooter()
        {
            _homePage.ScrollIntoView("FooterGrid");
        }

        [Then(@"I Should see Social Network Grid is displayed")]
        public void ThenIShouldSeeSocialNetworkGridIsDisplayed()
        {
            _contactPage.IsElementDisplayed("Facebook");
            _contactPage.IsElementDisplayed("Instagram");
            _contactPage.IsElementDisplayed("Linkedin");
            _contactPage.IsElementDisplayed("Twitter");
            _contactPage.IsElementDisplayed("Youtube");
        }

        
        [Then(@"I should see the main section grid is displayed")]
        public void ThenIShouldSeeTheMainSectionGridIsDisplayed()
        {
                List<string> expectedTexts = new List<string>
                 {
                   "About", "Services", "Customers", "Nearsurance", "Resources", "Careers"
                 };

                IWebElement headerSection = _homePage.HeaderSection;
                IList<IWebElement> liElements = headerSection.FindElements(By.TagName("li"));
                List<string> liTexts = new List<string>();
                foreach (IWebElement li in liElements)
                {
                    liTexts.Add(li.Text.Trim());
                }

                foreach (string expectedText in expectedTexts)
                {
                    if (!liTexts.Contains(expectedText))
                    {
                        throw new Exception($"Validation failed: '{expectedText}' was not found in the header section.");
                    }
                }

                Console.WriteLine("Validation passed: All expected texts are displayed in the header section.");
            }
        }
    }





