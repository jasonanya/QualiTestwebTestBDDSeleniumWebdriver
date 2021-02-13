using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class OrderHistory_page
{
    IWebDriver driver;
    public OrderHistory_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By OrderDetailsBtn = By.LinkText("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[7]/a[1]/span[1]");
    By TShirtName = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/label[1]");
    By BackToYourAccount = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/ul[1]/li[1]/a[1]/span[1]");  

    public void ClickOnOrderDetailsBtn()
    {
        driver.FindElement(OrderDetailsBtn).Click();           
    }
    public string VerifyTShirtName()
    {            
     return driver.FindElement(TShirtName).Text;
    }
    public MyAccount_page OrderHistroyPage_NavBackToAccountPage()
    {
     driver.FindElement(BackToYourAccount).Click();
     return new MyAccount_page(driver); //Return driver to next page       
    }

    }
}