using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class Payment_page
{
    IWebDriver driver;
    public Payment_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By ConfirmMyOrder = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]");

    public Order_Confirmation_page PaymentPage_NavToConfmPage()
    {
        driver.FindElement(ConfirmMyOrder).Click();
        return new Order_Confirmation_page(driver); //Return driver to next page       
    }
}
}