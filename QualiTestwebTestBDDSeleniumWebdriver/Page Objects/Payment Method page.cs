using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{ 
public class Payment_Method_page
{
    IWebDriver driver;
    public Payment_Method_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By PayByBankWire = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[3]/div[1]/div[1]/p[1]/a[1]");
   
    public Payment_page PaymentMethodPage_NavToPaymentPage()
    {
        driver.FindElement(PayByBankWire).Click();
        return new Payment_page(driver); //Return driver to next page       
    }
}
}