using OpenQA.Selenium;
using PLS30UI_BDD_Automation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLS30UI_BDD_Automation.Pages
{
   public class HomePage : BasePage
    {
        private By hmbrgrMenu => By.Id("sidebarCollapse");
        private By txtSrUsName => By.Id("searchByParamInput");

        private WebDriver driver;

        public HomePage(WebDriver _driver)
        {
            this.driver = _driver;
        }

        public void VerifyHomePage()
        {
            try
            {
                driver.WaitForCondition(d => d.FindElement(hmbrgrMenu).Displayed, "Wait for Hamberger menu to appear");
                driver.WaitForCondition(d => d.FindElement(txtSrUsName).Displayed, "Wait for User Name search box");
            }
            catch
            {
                Assert.Fail("Home Page was not loaded");
            }
        }
    }
}
