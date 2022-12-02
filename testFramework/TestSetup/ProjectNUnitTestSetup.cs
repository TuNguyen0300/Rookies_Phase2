using CoreFramework.NUnitTestSetup;
using NUnit.Framework;

namespace testFramework.TestSetup
{
    public class ProjectNUnitTestSetup : NUnitTestSetup
    {
        [SetUp]
        public void SetUp()
        {
            driverBaseAction.GoToUrl(Constant.BASE_URL);

        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
