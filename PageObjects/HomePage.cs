using OpenQA.Selenium;

namespace SpecFlowProject2.PageObjects
{
    internal class HomePage : BasePage.BasePage
    {
        public HomePage() : base() { }
        private static IWebDriver driver = DriverManager.GetDriver();

        //header
        public IWebElement HeaderSection => driver.FindElement(By.XPath("//ul[@id='menu-1-50af2d3b']"));
        public IWebElement AcceptCookieButton => driver.FindElement(By.XPath("//*[@data-cky-tag='accept-button']"));
        public  IWebElement ContactPageHeaderLink => driver.FindElement(By.XPath("(//*[@class='elementor-item menu-link' and contains(text(),'Contact')])[1]"));
        public  IWebElement GetInTouch => driver.FindElement(By.XPath("//*[@title='Get in touch']"));
        public  IWebElement WeAreStrypesHeaderText => driver.FindElement(By.XPath("//h1"));
        //Main Sections

        //Footer
        public  IWebElement EmailInputSubscription => driver.FindElement(By.XPath("//*[@id='form-field-email']"));
        public  IWebElement SubscriptionButton => driver.FindElement(By.XPath("//*[@id='Layer_1']"));
        public  IWebElement  SubscriptionSuccessMessage => driver.FindElement(By.XPath("//*[@class='elementor-message elementor-message-success']"));
        public IWebElement FooterGrid => driver.FindElement(By.XPath("//*[@data-id='ec24f16']"));
        //Footer - Social Networks
        public IWebElement Facebook => driver.FindElement(By.XPath("//*[contains(@class, 'elementor-screen-only') and contains(text(), 'Facebook')]"));
        public IWebElement Instagram => driver.FindElement(By.XPath("//*[contains(@class, 'elementor-screen-only') and contains(text(), 'Instagram')]"));
        public IWebElement Youtube => driver.FindElement(By.XPath("//*[contains(@class, 'elementor-screen-only') and contains(text(), 'Youtube')]"));
        public IWebElement Linkedin => driver.FindElement(By.XPath("//*[contains(@class, 'elementor-screen-only') and contains(text(), 'Linkedin-in')]"));
        public IWebElement Twitter => driver.FindElement(By.XPath("//*[contains(@class, 'elementor-screen-only') and contains(text(), 'Twitter')]"));


        public override IWebElement ReturnElement(string elementName)
        {
            return elementName switch
            {
                "AcceptCookieButton" => AcceptCookieButton,
                "GetInTouch" => GetInTouch,
                "ContactPageHeaderLink" => ContactPageHeaderLink,
                "WeAreStrypesHeaderText" => WeAreStrypesHeaderText,
                "EmailInputSubscription" => EmailInputSubscription,
                "SubscriptionButton" => SubscriptionButton,
                "SubscriptionSuccessMessage" => SubscriptionSuccessMessage,
                "FooterGrid" => FooterGrid,
                "Facebook" => Facebook,
                "Instagram" => Instagram,
                "Youtube" => Youtube,
                "Linkedin" => Linkedin,
                "Twitter" => Twitter,
                _ => throw new NoSuchElementException("Element not found: " + elementName)
            };
        }
    }
}
