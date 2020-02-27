using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PLS30UI_BDD_Automation.Context;
using PLS30UI_BDD_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PLS30UI_BDD_Automation.Steps
{
   public class BaseSteps 
    {
        public HomePage homePage { get; set; }
        public LoginPage loginPage { get; set; }
        private readonly WebDriver webDriver;
        public BaseSteps(WebDriver driver)
        {
            webDriver = driver;
            homePage = new HomePage(webDriver);
            loginPage = new LoginPage(webDriver);
        }

    }
}
