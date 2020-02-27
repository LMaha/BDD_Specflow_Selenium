using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using PLS30UI_BDD_Automation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLS30UI_BDD_Automation.Pages
{
    public class LoginPage : BasePage
    {
        private WebDriver driver;
        private By txtUserName => By.Name("username");
        private By txtPassword => By.Name("userPassword");
        private By btnLogin => By.Id("loginBtn");

        //public LoginPage(Driver driver, Assert assert) : base(driver, assert) { }

        public LoginPage(WebDriver _driver)
        {
            this.driver =_driver;
        }

        public void Login(string userName, string password)
        {           
            driver.SendKeys(txtUserName, userName, "Enter text in UserName");
            driver.SendKeys(txtPassword, password, "Enter text in password");                    
        }

        public HomePage ClickLogin()
        {         
           driver.FindElement(btnLogin).Click();
            return new HomePage(driver);
        }
    }
}
