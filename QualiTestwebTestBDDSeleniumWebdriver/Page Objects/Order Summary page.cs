using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{

public class Order_Summary_page
{
    IWebDriver driver;
    public Order_Summary_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By OrderSummary_ProceedToCheckBtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/p[2]/a[1]/span[1]");

    public Billing_address_page OrderSummaryPage_NavToBillingAddrPage()
    {
          
        driver.FindElement(OrderSummary_ProceedToCheckBtn).Click();
        return new Billing_address_page(driver); //Return driver to next page        
    }
}
}
