using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class ImagePage : BasePage
    {
        public ImagePage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement txtQuery => driver.FindElement(By.XPath("//input[@name='q']"));
        private IWebElement btnSearch => driver.FindElement(By.XPath("//span[@class='z1asCe MZy1Rb']"));
        private IWebElement imagesResult => driver.FindElement(By.XPath("//img[@jsname='Q4LuWd']"));

        public void SentTextToQuery(string text) => txtQuery.SendKeys(text);
        public void btnClick() => btnSearch.Click();
        public string FindImage() => imagesResult.GetAttribute("src");

    }
}
