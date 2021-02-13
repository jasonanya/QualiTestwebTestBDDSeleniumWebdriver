using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Threading;
using QualiTestwebTestBDDSeleniumWebdriver.Page_Objects;

namespace QualiTestwebTestBDDSeleniumWebdriver
{
    [Binding]
    public class CustomerOrderSteps
    {
        public IWebDriver driver;

        public CustomerOrderSteps()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver = new FirefoxDriver();
            //driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com");
        }

        [AfterScenario]
        public void CleanUp()
        {
            driver.Quit();
        }

        [Given(@"Customer is at Your Logo website and login to their account using (.*) and (.*) and clicks sign in")]
        public void GivenCustomerIsAtYourLogoWebsiteAndLoginToTheirAccountUsingAndAndClicksSignIn(string email, string password)
        {
            var login_page = new Login_page(driver);
            login_page.EnterLoginDetails(email, password);
            login_page.NavToMyAccountPage();
        }

        [Given(@"Arrives at their account page and clicks T Shirts Tab to search for T Shirts")]
        public void GivenArrivesAtTheirAccountPageAndClicksTShirtsTabToSearchForTShirts()
        {

            var myaccount_page = new MyAccount_page(driver);
            myaccount_page.MyAccountPage_NavToTShirstStorepage();
            
        }

        [Given(@"Arrives at T Shirts store page and select product displayed")]
        public void GivenArrivesAtTShirtsStorePageAndSelectProductDisplayed()
        {
            var tshirts_page = new TShirts_page(driver);
            tshirts_page.TShirtsStorePage_NavToProductPage();
        }

        [Given(@"Arrives at the product page and add to cart")]
        public void GivenArrivesAtTheProductPageAndAddToCart()
        {
            var product_page = new Product_page(driver);
            product_page.ProductPage_NavToOrderSummaryPage();
        }

        [Given(@"Arrives at order Summary page and clicks Proceed to checkout")]
        public void GivenArrivesAtOrderSummaryPageAndClicksProceedToCheckout()
        {
            var order_summary_page = new Order_Summary_page(driver);
            order_summary_page.OrderSummaryPage_NavToBillingAddrPage();
        }

        [Given(@"Verifies billing address and clicks Proceed to checkout")]
        public void GivenVerifiesBillingAddressAndClicksProceedToCheckout()
        {
            var billing_address_page = new Billing_address_page(driver);
            Assert.AreEqual("2 Merton Road",billing_address_page.VerifyBillingAddrRoadText());
            billing_address_page.BillingAddrPage_NavToTermsAndConditionsPage();
        }

        [Given(@"Agrees to terms and conditions of service and clicks Proceed to checkout")]
        public void GivenAgreesToTermsAndConditionsOfServiceAndClicksProceedToCheckout()
        {
            var terms_and_conditions_page = new Terms_and_Conditions_page(driver);
            terms_and_conditions_page.ClickTermsAndConditionsCheckbox();
            terms_and_conditions_page.TermsAndConditionPage_NavToPaymentMethodPage();
        }

        [When(@"Customer arrives at Payment method page and clicks Pay by bank wire")]
        public void WhenCustomerArrivesAtPaymentMethodPageAndClicksPayByBankWire()
        {
            var payment_method_page = new Payment_Method_page(driver);
            payment_method_page.PaymentMethodPage_NavToPaymentPage();
        }

        [When(@"Arrives at Payment page and clicks I confirm my order")]
        public void WhenArrivesAtPaymentPageAndClicksIConfirmMyOrder()
        {
            var payment_page = new Payment_page(driver);
            payment_page.PaymentPage_NavToConfmPage();
        }

        [When(@"Arrives at Order Confrimation page and click on Back to Orders")]
        public void WhenArrivesAtOrderConfrimationPageAndClickOnBackToOrders()
        {
            var order_confirmation_page = new Order_Confirmation_page(driver);
            Assert.AreEqual("ORDER CONFIRMATION", order_confirmation_page.VerifyOrderConfirmationHeaderText());
            order_confirmation_page.OrderConfrmPage_NavToOrderHistoryPage();
        }

        [Then(@"Customer should arrive at Order history page to verify their order and click Back to your Account")]
        public void ThenCustomerShouldArriveAtOrderHistoryPageToVerifyTheirOrderAndClickBackToYourAccount()
        {
            var orderHistory_page = new OrderHistory_page(driver);
            orderHistory_page.ClickOnOrderDetailsBtn();
            Assert.AreEqual("Faded Short Sleeve T-shirts - Color : Orange, Size : S", orderHistory_page.VerifyTShirtName());
            orderHistory_page.OrderHistroyPage_NavBackToAccountPage();
        }

        [When(@"Customer selects My personal information tab")]
        public void WhenCustomerSelectsMyPersonalInformationTab()
        {
            var myaccount_page = new MyAccount_page(driver);
            myaccount_page.MyAccountPage_NavToMyIdentityPage();
        }

        [When(@"Arrives at their identity page")]
        public void WhenArrivesAtTheirIdentityPage()
        {
            var identity_page = new Identity_page(driver);
            identity_page.VerifyCustomerIsOnIdentityPage();
        }

        [Then(@"Customer should be able to update their (.*) validate with their (.*) and click save")]
        public void ThenCustomerShouldBeAbleToUpdateTheirValidateWithTheirAndClickSave(string firstname, string password)
        {
            var identity_page = new Identity_page(driver);
            identity_page.UpdateFirstNameAndValidateWithPassword(firstname, password);
        }

    }
}