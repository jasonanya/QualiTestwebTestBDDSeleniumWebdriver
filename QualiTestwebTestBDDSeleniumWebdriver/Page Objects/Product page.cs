using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class Product_page
{
    IWebDriver driver;
    public Product_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By AddToCartBtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[4]/form[1]/div[1]/div[3]/div[1]/p[1]/button[1]/span[1]");
    By ProceedToCheckoutBtn = By.XPath("/html[1]/body[1]/div[1]/div[1]/header[1]/div[3]/div[1]/div[1]/div[4]/div[1]/div[2]/div[4]/a[1]/span[1]");
    public Order_Summary_page ProductPage_NavToOrderSummaryPage()
    {
     // Add to Cart and proceed to checkout   
     WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));//Wait for page to load
     wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(AddToCartBtn));
     driver.FindElement(AddToCartBtn).Click();
     driver.FindElement(ProceedToCheckoutBtn).Click();
     return new Order_Summary_page(driver); //Return driver to next page        
    }
}
}
