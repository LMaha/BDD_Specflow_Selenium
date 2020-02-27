using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PLS30UI_BDD_Automation.Context;
using PLS30UI_BDD_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PLS30UI_BDD_Automation.Steps
{
    [Binding]
   public class LoginSteps : BaseSteps
    {


        private readonly WebDriver webDriver;

        public LoginSteps(WebDriver driver) : base(driver)
        {
            webDriver = driver;
        }
     
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            webDriver._driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

        }

        [Given(@"I have typed username and password")]
        public void GivenIHaveTypedUsernameAndPassword()
        {
            loginPage.Login(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["Password"]);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            
            loginPage.ClickLogin();
        }
     

        [Then(@"I should see the HomePage page")]
        public void ThenIShouldSeeTheHomePagePage()
        {
           homePage.VerifyHomePage();
        }
     
   
    }
}
