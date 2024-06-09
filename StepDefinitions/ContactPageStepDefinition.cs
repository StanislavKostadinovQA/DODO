using OpenQA.Selenium;
using SpecFlowProject2.Hooks;
using SpecFlowProject2.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    internal class ContactPageStepDefinition
    {
        [Binding]
        public class ContactStepDefinition
        {
            private IWebDriver _driver;
            private WaitHelper.WaitHelper _waitHelper;
            private HomePage _homePage;
            private Urls _url;
            private ContactPage _contactPage;


            public ContactStepDefinition()
            {

                _driver = BasePage.BasePage.GetDriver();
                _waitHelper = new WaitHelper.WaitHelper();
                _url = new Urls();
                _homePage = new HomePage();
                _contactPage = new ContactPage();

            }

            [Given(@"I open the Contact Page")]
            public void GivenIOpenTheContactPage()
            {
                _contactPage.NavigateTo(_driver,_url.ContactPageURL);
            }


            [When(@"I fullfill the form with my '([^']*)' , '([^']*)' , '([^']*)' and '([^']*)'")]
            public void WhenIFullfillTheFormWithMyAnd(string firstname, string lastname, string company, string email)
            {
                _homePage.SendKeysToElement(_contactPage.FirstNameInput, firstname);
                _homePage.SendKeysToElement(_contactPage.LastNameInput, lastname);
                _homePage.SendKeysToElement(_contactPage.CompanyInput, company);
                _homePage.SendKeysToElement(_contactPage.EmailInput, email);
            }

            [When(@"I click the '([^']*)'")]
            public void WhenIClickThe(string element)
            {

                _homePage.ScrollIntoView(element);
                _homePage.ClickElement(element);
            }

            [When(@"Confirm the subscribtion")]
            public void WhenConfirmTheSubscribtion()
            {
                _contactPage.ClickElement("SendButton");
            }

            [Then(@"I should see a success message")]
            public void ThenIShouldSeeASuccessMessage()
            {
                _contactPage.ScrollIntoView("SubscriptionSuccessMessage");
                _contactPage.DoesElementContainText("SubscriptionSuccessMessage", "Thank you for submitting the form.");

            }

            [When(@"I click the Term of Use cehckbox in Contact Page")]
            public void WhenIClickTheTermOfUseCehckboxInContactPage()
            {
                _contactPage.ScrollIntoView("TermOfUseCheckBox");
                _contactPage.ScrollToCenter();
                _contactPage.ClickElement("TermOfUseCheckBox");
            }

            [When(@"I am on the Contact Page")]
            public void WhenIAmOnTheContactPage()
            {   
                _contactPage.IsElementDisplayed("HeaderGetInTouch");
            }

        }
    }
}