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
            _waitHelper.WaitForElementToBeVisible(_driver, _homePage.WeAreStrypesHeaderText);
            _waitHelper.WaitForElementToBeVisible(_driver, _homePage.AcceptCookieButton);
            Thread.Sleep(3000);
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








    }

}



