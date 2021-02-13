using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
    public class MyAccount_page
    {
        IWebDriver driver;
        public MyAccount_page(IWebDriver driverFromPreviousClass)
        {
            this.driver = driverFromPreviousClass;
        }

        By TShirtsTab = By.CssSelector("#block_top_menu > ul > li:nth-child(3) > a");
        By MyPersonalInformationTab = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/ul[1]/li[4]/a[1]/span[1]");
        public TShirts_page MyAccountPage_NavToTShirstStorepage()
        {
            // Click TShits Tab when on Customer account page
            driver.FindElement(TShirtsTab).Click();
            return new TShirts_page(driver); //Return driver to next page        
        }

        public Identity_page MyAccountPage_NavToMyIdentityPage()
        {
            // Click on Personal details tab
            driver.FindElement(MyPersonalInformationTab).Click();
            return new Identity_page(driver); //Return driver to next page        
        }
    }
}