using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;

namespace TestWebPinterest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        public void InnitializeDriver() // Hàm khỏi tạo và truy cập vào trang web 
        {
            // Nguyễn Phú Quý - 2151053051
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.pinterest.com/");
            Thread.Sleep(6000);
        }
        public void LoginToPinterest(string email, string password) // Hàm đăng nhập vào trang web
        {
            // Nguyễn Phú Quý -2151053051
            driver.FindElement(By.CssSelector("#mweb-unauth-container > div > div > div.QLY._he.zI7.iyn.Hsu > div > div.Eqh.KS5.hs0.un8.C9i.TB_ > div.wc1.zI7.iyn.Hsu > button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(10000);
        }
        //[TestMethod]
        //public void TestLoginSuccess()// Test case đăng nhập thành công 
        //{
        //    // Nguyễn Phú Quý -2151053051 - Khởi tạo và truy cập vào trang web
        //    driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.pinterest.com/");
        //    Thread.Sleep(6000);

        //    // Nguyễn Phú Quý - 2151053051 - Thực hiện click vào nút đăng nhập 
        //    driver.FindElement(By.CssSelector("#mweb-unauth-container > div > div > div.QLY._he.zI7.iyn.Hsu > div > div.Eqh.KS5.hs0.un8.C9i.TB_ > div.wc1.zI7.iyn.Hsu > button")).Click();
        //    Thread.Sleep(2000);

        //    // Nguyễn Phú Quý - 2151053051 - Điền tên đăng nhập hoặc email đã đăng ký từ trước
        //    driver.FindElement(By.Id("email")).SendKeys("nguyenphuquy300603@gmail.com");

        //    // Nguyễn Phú Quý - 2151053051  - Điền thông tin password đã đăng ký từu trước
        //    driver.FindElement(By.Id("password")).SendKeys("27022022nPqPnTt!");

        //    // Nguyễn Phú Quý - 2151053051 - Bước check lại thông tin đã đăng nhập đúng với tài khoản đã đăng ký từ trước hay chưa 
        //    driver.FindElement(By.CssSelector("#__PWS_ROOT__ > div > div:nth-child(1) > div:nth-child(4) > div > div > div > div > div > div:nth-child(4) > form > div.hjj.zI7.iyn.Hsu > button")).Click();

        //    Thread.Sleep(20000);
        //    driver.FindElement(By.XPath("//*[@id=\"HeaderContent\"]/div/div/div[2]/div/div/div/div[5]/div[4]/div/div")).Click();
        //    IWebElement currentUserElement = driver.FindElement(By.XPath("//*[@id=\"__PWS_ROOT__\"]/div/div[1]/div/div[2]/div/div/div/div[1]/div/div/div[2]/div/h1/div"));
        //    Assert.IsNotNull(currentUserElement, "Login failed. The user's name element is not present");

        //    string actualUserName = currentUserElement.Text;

        //    Assert.AreEqual("Phú Quý Nguyễn", actualUserName, "Unexpected text in the user's name element");
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void CheckMail()
        //{
        //    // Nguyễn Phú Quý - 2151053051 // Đăng nhập thất bại vì gmail không đúng định dạng
        //    InnitializeDriver();
        //    LoginToPinterest("nguyenphuquy300603@gmail", "27022022nPqPnTt!");
        //    Thread.Sleep(20000);
        //    IWebElement errmessage = driver.FindElement(By.CssSelector("#email-error > div > div > div:nth-child(2)"));
        //    string error = errmessage.Text;

        //    Assert.AreEqual("Hmm...that doesn't look like an email address.", error, " Unexpected text in the user's name element.");
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void LoginFail()
        //{
        //    //Nguyễn Phú Quý -2151053051 // Đăng nhập lỗi khi nhập sai email
        //    InnitializeDriver();
        //    LoginToPinterest("nguyenphuquy272306@gmail.com", "27022022nPqPnTt!");
        //    IWebElement errmessage = driver.FindElement(By.CssSelector("#email-error > div > div > div:nth-child(2)"));
        //    Assert.AreEqual("The email you entered does not belong to any account.", errmessage.Text.Trim(), "Unexpected error massage");
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void SearchAnDownOne()
        //{
        //    // Nguyễn Phú Quý - 215053051 // Tải về hình ảnh
        //    InnitializeDriver();
        //    LoginToPinterest("nguyenphuquy300603@gmail.com", "27022022nPqPnTt!");
        //    IWebElement getSearchUser = driver.FindElement(By.XPath("//*[@id=\"searchBoxContainer\"]/div/div/div[2]/input"));
        //    getSearchUser.SendKeys("cat");
        //    new Actions(driver).KeyDown(Keys.Enter).Build().Perform();
        //    string downloadsPath = "C:\\Users\\nguye\\Downloads";
        //    int initialFileCount = Directory.GetFiles(downloadsPath).Length;
        //    Thread.Sleep(10000);
        //    IWebElement firstImage = driver.FindElement(By.XPath("//*[@id=\"__PWS_ROOT__\"]/div/div[1]/div/div[2]/div/div/div[4]/div/div[1]/div/div/div/div/div[1]/div[1]/div/div/div/div/div/div[1]/a/div/div[1]/div/div/div/div/div/img"));
        //    firstImage.Click();
        //    Thread.Sleep(2000);
        //    IWebElement getModel = driver.FindElement(By.CssSelector("#gradient > div > div > div.ujU.zI7.iyn.Hsu > div > div > div > div > div > div > div > div > div > div.Jea.jzS.zI7.iyn.Hsu > div.Jea.jzS.ujU.zI7.iyn.Hsu > div.qiB > div > div > div > div.DUt.Jea.KS5.b8T.imm.zI7.iyn.Hsu > div > div:nth-child(2) > div > div > div > div > div > div > div > div > div > button > div > div > svg"));
        //    getModel.Click();
        //    // Nguyễn Phú Quý - 215053051 
        //    // Lấy sự kiện tải về 
        //    IWebElement btnDownload = driver.FindElement(By.CssSelector("#pin-action-dropdown-item-0 > div > div > div.jzS.ujU.un8.C9i.kwA > div > div > span"));
        //    btnDownload.Click();
        //    Thread.Sleep(2000);
        //    driver.Quit();
        //}
        //[TestMethod]
        //public void SearchNotFound()
        //{
        //    InnitializeDriver();
        //    LoginToPinterest("nguyenphuquy300603@gmail.com", "27022022nPqPnTt!");
        //    IWebElement getSearchUser = driver.FindElement(By.XPath("//*[@id=\"searchBoxContainer\"]/div/div/div[2]/input"));
        //    getSearchUser.SendKeys("abcsadkasd,ádadsasd");
        //    new Actions(driver).KeyDown(Keys.Enter).Build().Perform();
        //    Thread.Sleep(10000);
        //    IWebElement errorMessage = driver.FindElement(By.CssSelector("#__PWS_ROOT__ > div > div:nth-child(1) > div > div.appContent > div > div > div.qiB > div > div.LCN.imm.qDf.zI7.iyn.Hsu > div > div"));
        //    string error = errorMessage.Text;
        //    Assert.AreEqual("Đây là những thông tin mà chúng tôi tìm thấy cho abcsadkasd ádadsad. Tìm kiếm abcsadkasd ádadsasd để thay thế?", error, "Error message does not match");
        //    driver.Quit();
        //}
        [TestMethod]
        public void Search()
        {
            InnitializeDriver();
            LoginToPinterest("nguyenphuquy300603@gmail.com", "27022022nPqPnTt!");
            IWebElement getSearchUser = driver.FindElement(By.CssSelector("#searchBoxContainer > div > div > div.ujU.zI7.iyn.Hsu > input[type=text]"));
            getSearchUser.SendKeys("abc");
            new Actions(driver).KeyDown(Keys.Enter).Build().Perform();
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
