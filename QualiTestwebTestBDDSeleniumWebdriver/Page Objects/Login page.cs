using System.Threading;
using OpenQA.Selenium;

namespace QualiTestwebTestBDDSeleniumWebdriver.Page_Objects
{
    public class Login_page
    {
        IWebDriver driver;
        public Login_page(IWebDriver driverFromPreviousClass)
        {
            this.driver = driverFromPreviousClass;
        }

        By SigninBtn = By.XPath("//a[contains(text(),'Sign in')]");
        By EmailAddress = By.Id("email");
        By Password = By.Id("passwd"); 
        By LoginBtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[2]/form[1]/div[1]/p[2]/button[1]/span[1]");

        public void EnterLoginDetails(string email, string password)
        {
            // Click Sign in Btn and Enter customer login details
            driver.FindElement(SigninBtn).Click();
            driver.FindElement(EmailAddress).SendKeys(email);
            driver.FindElement(Password).SendKeys(password);
        }
        public MyAccount_page NavToMyAccountPage()
        {
            // Click on Signin button to login
            driver.FindElement(LoginBtn).Click();
            return new MyAccount_page(driver); //Return driver to next page
        }
    }
}