using NUnit.Framework;
using OpenQA.Selenium;
using testFramework.Common;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class MangageAssetsTest : ProjectNUnitTestSetup
    {
        [Test]
        public void CreateNewAsset()
        {
            CommonFlow commonFlow = new CommonFlow();
            MenuLeft menuLeft = new MenuLeft(_driver);
            ManageAssetPage manageAssetPage = new ManageAssetPage(_driver);

            commonFlow.CMUserLogin(_driver);

            menuLeft.ClickManageAsset();

            manageAssetPage.ClickCreate();
        }

    }
}
