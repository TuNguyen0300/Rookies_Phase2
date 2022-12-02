using NUnit.Framework;
using NUnit.Framework.Internal;
using testFramework.Common;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class LoginTest : ProjectNUnitTestSetup
    {
        //[TestCase("vangdv", "vangdv@01011990")]
        //[TestCase("tuandv", "tuandv@01011990")]
        //[TestCase("quynhct", "quynhct@01011990")]
        

        [Test]
        public void LoginSuccess()
        {
            CommonFlow commonFlow = new CommonFlow();
            commonFlow.CMUserLogin(_driver);

            LoginPage login = new LoginPage(_driver);
            login.DirectCorrectHome();
        }

        [Test]
        public void ChangePassword()
        {
            CommonFlow commonFlow = new CommonFlow();
            HomePage homePage = new HomePage(_driver);

            commonFlow.CMUserLogin(_driver);
            homePage.ChangePassword(Constant.PassID1new);
            homePage.VerifyBackLoginPage();

            
        }
        [Test]
        public void LogOut()
        {
            CommonFlow commonFlow = new CommonFlow();
            HomePage menuHeader = new HomePage(_driver);
            LoginPage login = new LoginPage(_driver);

            commonFlow.CMUserLogin(_driver);
            menuHeader.Logout();
            login.DirectCorrectLogin();
        }
        [Test]
        public void CancelChangePassword()
        {
            CommonFlow commonFlow = new CommonFlow();
            HomePage homePage = new HomePage(_driver);

            commonFlow.CMUserLogin(_driver);
            homePage.CancelChangePassword();
            homePage.VerifyBackHomePage();
        }
        [Test]
        public void CancelLogout()
        {
            CommonFlow commonFlow = new CommonFlow();
            HomePage homePage = new HomePage(_driver);

            commonFlow.CMUserLogin(_driver);
            homePage.CancelLogout();
            homePage.VerifyBackHomePage();
        }
    }
}
