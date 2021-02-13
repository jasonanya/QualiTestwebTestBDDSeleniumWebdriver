using System.Threading;
using OpenQA.Selenium;


namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class Billing_address_page
{
    IWebDriver driver;
    public Billing_address_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By BillingAddrRoadText = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/div[1]/div[2]/div[1]/ul[1]/li[4]");
    By Billing_ProceedToCheckBtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]");

        public string VerifyBillingAddrRoadText()
        {
            // Verify Billing Address road text
            return driver.FindElement(BillingAddrRoadText).Text;
        }

        public Terms_and_Conditions_page BillingAddrPage_NavToTermsAndConditionsPage()
        {
             
        driver.FindElement(Billing_ProceedToCheckBtn).Click();
        return new Terms_and_Conditions_page(driver); //Return driver to next page       
        }
}
}