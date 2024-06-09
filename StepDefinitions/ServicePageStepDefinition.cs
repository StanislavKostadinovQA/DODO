using OpenQA.Selenium;
using SpecFlowProject2.Hooks;
using SpecFlowProject2.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    internal class ServicePageStepDefinition
    {
        [Binding]
        public class HomeStepDefinition
        {
            private IWebDriver _driver;
            private WaitHelper.WaitHelper _waitHelper;
            private HomePage _homePage;
            private ServicePage _servicepage;
            private Urls _url;

            public HomeStepDefinition()
            {
                _driver = BasePage.BasePage.GetDriver();
                _waitHelper = new WaitHelper.WaitHelper();
                _homePage = new HomePage();
                _servicepage = new ServicePage();
                _url = new Urls();
            }


            [Given(@"I navigate to Service Page")]
            public void GivenINavigateToServicePage()
            {
                _servicepage.NavigateTo(_driver,_url.ServicePageURL);
                _waitHelper.WaitForPageToLoad(_driver);
            }

            [When(@"I am on the Service Page")]
            public void WhenIAmOnTheServicePage()
            {
                _servicepage.ScrollToCenter();
                _servicepage.IsElementDisplayed("ServicePageHeader");
            }

            [Then(@"I Should see the main screen sections")]
            public void ThenIShouldSeeTheMainScreenSections()
            {
                _servicepage.ScrollIntoView("ITinfrastructureSection");
                _servicepage.IsElementDisplayed("ITinfrastructureSection");
                _servicepage.IsElementDisplayed("DigitalTransformationSection");
                _servicepage.ScrollIntoView("MobiityAndTransportationSection");
                _servicepage.IsElementDisplayed("MobiityAndTransportationSection");
                _servicepage.IsElementDisplayed("ConsultancySection");
                _servicepage.ScrollIntoView("RemoteDiagnosticSection");
                _servicepage.IsElementDisplayed("RemoteDiagnosticSection");
                _servicepage.IsElementDisplayed("SmartAplicationSection");

            }


        }
    }
}