using NUnit.Framework;
using PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
     public class LoginTest : BaseTest
    {
        [Test]
        public void VeirfyTest()
        {
            InitPage init = new InitPage(driver);
            init.ClicLogin();
            Thread.Sleep(2000);

            ImagePage imagePage = new ImagePage(driver);
            imagePage.SentTextToQuery("image");
            imagePage.btnClick();
            Thread.Sleep(2000);
            string actualImg = imagePage.FindImage();
            string expectedImg = "image/jpeg";

           
            Assert.IsTrue(actualImg.Contains(expectedImg), $"{expectedImg} is not {actualImg}");
        }
    }
}
