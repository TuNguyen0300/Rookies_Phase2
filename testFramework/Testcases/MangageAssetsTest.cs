using NUnit.Framework;
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
            HomePage homePage = new HomePage(_driver);

            commonFlow.CMUserLogin(_driver);
            homePage.ClickManageAsset();
        }

    }
}
