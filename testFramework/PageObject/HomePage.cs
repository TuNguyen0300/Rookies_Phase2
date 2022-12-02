using CoreFramework.DriverCore;
using OpenQA.Selenium;

namespace testFramework.PageObject
{
    public class HomePage : WebDriverAction
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string btnMenu = "//li[@role='none']";

        private readonly string btnChangePass = "//div[contains(@style,'position')]//li[1]";
        private readonly string boxOldPass = "//input[@id='change-password_oldPassword']";
        private readonly string boxNewPass = "//input[@id='change-password_newPassword']";
        private readonly string btnSaveChange = "//button[@class='ant-btn ant-btn-primary ant-btn-dangerous']";
        private readonly string btnCancelChange = "//button[@class='ant-btn ant-btn-default']";

        private readonly string btnLogout = "//div[contains(@style, 'position')]//li[2]";
        private readonly string btnConfirmLog = "//span[text()='Log out']";
        private readonly string btnCancelLog = "//span[text()='Cancel']";
        private readonly string txtHomepage = "//div[text()='Home page']";

        private readonly string oldPass = "vangdv@01011990";
        private readonly string boxLogin = "//div[@class='ant-card-body']";

        private readonly string btnHome = "//a[@href='/home']";
        private readonly string btnM_Users = "//a[@href='/manage-users']";
        private readonly string btnM_Assets = "//a[@href='/manage-assets']";
        private readonly string btnM_Assignments = "//a[@href='/manage-assignments']";
        private readonly string btnRequest_Return = "//a[@href='/request-for-returning']";
        private readonly string btnReport = "//a[@href='/report']";
        public void ChangePassword(string newPass)
        {
            Click(btnMenu);
            Click(btnChangePass);
            SendKeys_(boxOldPass, oldPass);
            SendKeys_(boxNewPass, newPass);
            Click(btnSaveChange);
        }
        public void CancelChangePassword()
        {
            Click(btnMenu);
            Click(btnChangePass);
            Click(btnCancelChange);
        }
        public void Logout()
        {
            Click(btnMenu);
            Click(btnLogout);
            Click(btnConfirmLog);
        }
        public void CancelLogout()
        {
            Click(btnMenu);
            Click(btnLogout);
            Click(btnCancelLog);
        }
        public void VerifyBackHomePage()
        {
            IsElementDisplayed(txtHomepage);
        }
        public void VerifyBackLoginPage()
        {
            IsElementDisplayed(boxLogin);
        }
        public void ClickHome()
        {
            Click(btnHome);
        }
        public void ClickManageAsset()
        {
            Click(btnM_Assets);
        }
        public void ClickManageAssi()
        {
            Click(btnM_Assignments);
        }
        public void ClickManageUser()
        {
            Click(btnM_Users);
        }
        public void ClickRequest()
        {
            Click(btnRequest_Return);
        }
        public void ClickReport()
        {
            Click(btnReport);
        }
    }
}
