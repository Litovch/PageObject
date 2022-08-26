using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver): base(driver)
        {

        }

        private IWebElement btnImage => driver.FindElement(By.XPath("//a[@href='https://www.google.com.ua/imghp?hl=uk&ogbl']"));

        public void ClicLogin() => btnImage.Click();
       
    }
}
