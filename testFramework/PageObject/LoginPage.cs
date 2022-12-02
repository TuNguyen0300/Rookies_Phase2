using CoreFramework.DriverCore;
using OpenQA.Selenium;

namespace testFramework.PageObject
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string boxUserName = "//input[@id='login_username']";
        private readonly string boxPassword = "//input[@id='login_password']";
        private readonly string buttonLogin = "//button[@type='submit']";

        private readonly string btnMenu = "//span[@class='ant-menu-title-content']";
        private readonly string btnChangePass = "//a[text()='Change Password']";

        private readonly string txtHomepage = "//div[text()='Home page']";
        private readonly string boxLogin = "//div[@class='ant-card-body']";

        public void ClickMenu()
        {
            Click(btnMenu);
        }

        public void ClickChangePassword()
        {
            Click(btnChangePass);
        }

        public void InputUserName(string username)
        {
            SendKeys_(boxUserName, username);
        }
        public void InputPassword(string password)
        {
            SendKeys_(boxPassword, password);
        }
        public void ClickLogin()
        {
            Click(buttonLogin);
        }
        public void DirectCorrectHome()
        {
            IsElementDisplayed(txtHomepage);
        }
        public void DirectCorrectLogin()
        {
            IsElementDisplayed(boxLogin);
        }


    }
}
