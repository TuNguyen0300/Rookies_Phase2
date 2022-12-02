using CoreFramework.DriverCore;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.PageObject
{
    public class ManageUserPage : WebDriverAction
    {
        public ManageUserPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
