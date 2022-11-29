using CoreFramework.DriverCore;
using OpenQA.Selenium;

namespace testFramework.PageObject
{
    public class ManageAssetPage : WebDriverAction
    {
        public ManageAssetPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string btnCreateNewAsset = "//span[text()='Create new asset']";

        private readonly string boxAssetName = "//input[@placeholder='Asset Name']";
        private readonly string boxCategory = "//div[@class='ant-select-selector']";
        private readonly string boxSpecifi = "//*[@placeholder='Specifications']";
        private readonly string boxDate = "//*[@placeholder='Select date']";
        public void ClickCreate()
        {
            Click(btnCreateNewAsset);
        }
    }
}
