using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.PageObjects
{
    internal class ContactPage : BasePage.BasePage
    {
        public ContactPage() : base() { }
        private static IWebDriver driver = DriverManager.GetDriver();

        public IWebElement HeaderGetInTouch => driver.FindElement(By.XPath("//h1"));
        public IWebElement FirstNameInput => driver.FindElement(By.XPath("//*[@name='firstname']"));
        public IWebElement LastNameInput => driver.FindElement(By.XPath("//*[@name='lastname']"));
        public IWebElement EmailInput => driver.FindElement(By.XPath("//*[@name='email']"));
        public IWebElement CompanyInput => driver.FindElement(By.XPath("//*[@name='company']"));
        public IWebElement MessageInput => driver.FindElement(By.XPath("//*[@name='message']"));
        public IWebElement TermOfUseCheckBox => driver.FindElement(By.XPath("//*[@id='LEGAL_CONSENT.subscription_type_4681882-9246f6ce-b893-4249-8362-96d17c0861f5']"));
        public IWebElement SubscriptionNewslaterCheckbox => driver.FindElement(By.XPath("//*[@id='LEGAL_CONSENT.subscription_type_4673944-9246f6ce-b893-4249-8362-96d17c0861f5']"));
        public IWebElement SendButton => driver.FindElement(By.XPath("//*[@value='SEND']"));
        public IWebElement SubscriptionSuccessMessage => driver.FindElement(By.XPath("//*[@class='hbspt-form']"));
        public override IWebElement ReturnElement(string elementName)
        {
            return elementName switch
            {
                "HeaderGetInTouch" => HeaderGetInTouch,
                "FirstNameInput" => FirstNameInput,
                "LastNameInput" => LastNameInput,
                "EmailInput" => EmailInput,
                "CompanyInput" => CompanyInput,
                "MessageInput" => MessageInput,
                "TermOfUseCheckBox" => TermOfUseCheckBox,
                "SubscriptionNewslaterCheckbox" => SubscriptionNewslaterCheckbox,
                "SendButton" => SendButton,
                "SubscriptionSuccessMessage" => SubscriptionSuccessMessage,
                _ => throw new NoSuchElementException("Element not found: " + elementName)
            };
        }
    }
}