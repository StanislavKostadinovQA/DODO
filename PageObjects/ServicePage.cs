using OpenQA.Selenium;
using SpecFlowProject2.BasePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.PageObjects
{
    internal class ServicePage : BasePage.BasePage
    {
        public ServicePage() : base() { }
        private static IWebDriver driver = DriverManager.GetDriver();

        public IWebElement ServicePageHeader => driver.FindElement(By.XPath("//h2[contains(text(),'Services to make the world smarter​')]"));
        public IWebElement ITinfrastructureSection => driver.FindElement(By.XPath("//h2[contains(text(),'IT Infrastructure')]"));
        public IWebElement DigitalTransformationSection => driver.FindElement(By.XPath("//h2[contains(text(),'Digital Transformation')]"));
        public IWebElement MobiityAndTransportationSection => driver.FindElement(By.XPath("//h2[contains(text(),'Mobility & Transportation')]"));
        public IWebElement ConsultancySection => driver.FindElement(By.XPath("//h2[contains(text(),'Consultancy')]"));
        public IWebElement RemoteDiagnosticSection => driver.FindElement(By.XPath("//h2[contains(text(),'Remote Diagnostics Monitoring and Predictive Maint')]"));
        public IWebElement SmartAplicationSection => driver.FindElement(By.XPath("//h2[contains(text(),'Smart Applications - Development, Modernization & ')]"));
        public IWebElement ModularServiceSection => driver.FindElement(By.XPath("//h2[contains(text(),'Modularity Services')]"));





        public override IWebElement ReturnElement(string elementName)
        {
            return elementName switch
            {
                "ServicePageHeader" => ServicePageHeader,
                "ITinfrastructureSection" => ITinfrastructureSection,
                "DigitalTransformationSection" => DigitalTransformationSection,
                "MobiityAndTransportationSection" => MobiityAndTransportationSection,
                "ConsultancySection" => ConsultancySection,
                "RemoteDiagnosticSection" => RemoteDiagnosticSection,
                "SmartAplicationSection" => SmartAplicationSection,
                "ModularServiceSection" => ModularServiceSection,

                 _ => throw new NoSuchElementException("Element not found: " + elementName)
            };
        }
    }
}
