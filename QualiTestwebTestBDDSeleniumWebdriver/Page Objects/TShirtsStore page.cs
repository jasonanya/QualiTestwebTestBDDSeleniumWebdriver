using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class TShirts_page
{
    IWebDriver driver;
    public TShirts_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By SelectTShirtProductDisplayed = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[2]/ul[1]/li[1]/div[1]/div[1]/div[1]/a[1]/img[1]");

    public Product_page TShirtsStorePage_NavToProductPage()
    {
     // Select the T Shirt product displayed
     driver.FindElement(SelectTShirtProductDisplayed).Click();
     return new Product_page(driver); //Return driver to next page        
    }
}
}


