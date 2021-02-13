using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class Order_Confirmation_page
{
    IWebDriver driver;
    public Order_Confirmation_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

        By OrderConfrmText = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/h1[1]");
        By BackToOrders = By.LinkText("Back to orders");

        public string VerifyOrderConfirmationHeaderText()
        {
            // Verify Customer is on Order Confirmation page
            return driver.FindElement(OrderConfrmText).Text;
        }

        public OrderHistory_page OrderConfrmPage_NavToOrderHistoryPage()
        {
        driver.FindElement(BackToOrders).Click();
        return new OrderHistory_page(driver); //Return driver to next page       
        }
}
}