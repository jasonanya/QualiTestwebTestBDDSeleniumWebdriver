using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;


namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
public class Identity_page
{
    IWebDriver driver;
    public Identity_page(IWebDriver driverFromPreviousClass)
    {
        this.driver = driverFromPreviousClass;
    }

    By Firstname = By.Id("firstname");
    By CurrenPassword = By.XPath("old_passwd");

     public void VerifyCustomerIsOnIdentityPage()
     {
       // Verify Customer is on Identity page
       String URL = driver.Url;
       Assert.AreEqual(URL, "http://automationpractice.com/index.php?controller=identity");         
     }

     public void UpdateFirstNameAndValidateWithPassword(string firstname, string password)
     {
       // Enter customer name to update and enter password to validate with
       driver.FindElement(Firstname).SendKeys(firstname);
       driver.FindElement(CurrenPassword).SendKeys(password);
            
     }
}
}