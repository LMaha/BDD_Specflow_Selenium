using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PLS30UI_BDD_Automation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PLS30UI_BDD_Automation.Pages
{
    public class BasePage
    {

        public Driver Driver { get; private set; }
        public Assert Assert { get; private set; }
        public RandomHelper Random { get; private set; }

       
    }
 }
