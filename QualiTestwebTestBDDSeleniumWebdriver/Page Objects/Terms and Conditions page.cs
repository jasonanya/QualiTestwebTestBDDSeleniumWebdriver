using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
    public class Terms_and_Conditions_page
{
    IWebDriver driver;
    public Terms_and_Conditions_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By TermsOfServiceCheckBox = By.Id("cgv");
    By TAndC_ProceedToCheckoutoutBtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/form[1]/p[1]/button[1]/span[1]");
    public void ClickTermsAndConditionsCheckbox()
    {
        // Accept Terms of service
        driver.FindElement(TermsOfServiceCheckBox).Click();
    }
    public Payment_Method_page TermsAndConditionPage_NavToPaymentMethodPage()
    {
        driver.FindElement(TAndC_ProceedToCheckoutoutBtn).Click();
        return new Payment_Method_page(driver); //Return driver to next page       
    }
}
}