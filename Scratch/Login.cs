using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using System.CodeDom.Compiler;

namespace Scratch
{
    [TestClass]
    public class Login
    {
        //CommonMethods comn = new CommonMethods();

        [TestMethod]
        public void Signup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://scratch.mit.edu/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test1.png", ScreenshotImageFormat.Png);
            driver.FindElement(By.XPath("//*[@id='view']/div/div[2]/div[1]/div[1]/div/a[2]")).Click();
            IWebElement tab1 = driver.FindElement(By.XPath("//*[@id='username']"));
            tab1.SendKeys("laibariaz00");
            IWebElement tab2 = driver.FindElement(By.XPath("//*[@id='password']"));
            tab2.SendKeys("alidaan12");
            var pass = tab2.GetAttribute("value");
            IWebElement tab3 = driver.FindElement(By.XPath("//*[@id='passwordConfirm']"));
            tab3.SendKeys("alidaan12");
            var pass2 = tab3.GetAttribute("value");
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test2.png", ScreenshotImageFormat.Png);
            Assert.AreEqual(pass, pass2);

            driver.Close();
        }
        [TestMethod]
        public void Form()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://scratch.mit.edu/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            IWebElement Jobs = driver.FindElement(By.XPath("//*[@id='footer']/div/div/dl[1]/dd[7]/a"));

            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");
            Jobs.Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test3.png", ScreenshotImageFormat.Png);

            driver.SwitchTo().Frame(0);
            IWebElement sqa = driver.FindElement(By.XPath("//*[@id=\"jobs-list\"]/li[1]/a"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", sqa);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test4.png", ScreenshotImageFormat.Png);
            sqa.Click();
            System.Threading.Thread.Sleep(1000);

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //var e=wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("applicant_first_name")));
            System.Threading.Thread.Sleep(4000);
            IWebElement element = driver.FindElement(By.Id("applicant_first_name"));
            element.SendKeys("Laiba");
            IWebElement element2 = driver.FindElement(By.Id("applicant_last_name"));
            element2.SendKeys("Riaz");
            IWebElement element3 = driver.FindElement(By.Id("applicant_email"));
            element3.SendKeys("laibariaz0@gmail.com");
            IWebElement element4 = driver.FindElement(By.Id("applicant_address"));
            element4.SendKeys("Raiwind");
            IWebElement element5 = driver.FindElement(By.Id("applicant_city"));
            element5.SendKeys("Lahore");
            IWebElement element6 = driver.FindElement(By.Id("applicant_state"));
            element6.SendKeys("Punjab");
            IWebElement element7 = driver.FindElement(By.Id("applicant_postal"));
            element7.SendKeys("1234");
            IWebElement element8 = driver.FindElement(By.Id("applicant_phone"));
            element8.SendKeys("032167828829");
            IWebElement element9 = driver.FindElement(By.Id("applicant_resumes_resume"));

            //element9.SendKeys("C:\\Users\\Admin\\Downloads\\document.pdf");
            //We are going to click and manually select the profile as its mandatory but path is different in every system.
           

            IWebElement element10 = driver.FindElement(By.Id("applicant_linkedin"));
            element10.SendKeys("https://www.linkedin.com/login");
            IWebElement element11 = driver.FindElement(By.XPath("//*[@id=\"new_applicant\"]/div[11]/div/label/div"));
            element11.Click();
            IWebElement element12 = driver.FindElement(By.Id("applicant_desired_salary"));
            element12.SendKeys("500");
            IWebElement element13 = driver.FindElement(By.Id("response"));
            element13.SendKeys("Hi,My name is laiba,I saw this job opening on Scratch,I,m an automation tester");

            Actions act = new Actions(driver);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element14 = driver.FindElement(By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[2]/div[2]/label/label/input"));
            act.Click(element14).Perform();
            IWebElement element15 = driver.FindElement(By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[3]/div[2]/label/label/input"));
            act.Click(element15).Perform();
            IWebElement element16 = driver.FindElement(By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[4]/input[3]"));
            element16.SendKeys("Scratch");
            IWebElement element17 = driver.FindElement(By.Id("applicant_gender_female"));
            act.Click(element17).Perform();
            IWebElement element18 = driver.FindElement(By.Id("applicant_ethnicity_asian"));
            act.Click(element18).Perform();
            IWebElement element19 = driver.FindElement(By.XPath("/html/body/div/section/div/div[2]/aside/form/div[16]/div[3]/label[1]/input"));
            act.Click(element19).Perform();
            IWebElement element20 = driver.FindElement(By.Id("applicant_disability_status_no_i_dont_have_a_disability_or_a_historyrecord_of_having_a_disability"));
            act.Click(element20).Perform();
            IWebElement element21 = driver.FindElement(By.Id("apply_candidate"));
            act.Click(element21).Perform();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("arguments[0].scrollIntoView(true);", element14);
            //IWebElement element15 = driver.FindElement(By.XPath("/html/body/div/section/div/div[2]/aside/form/div[12]/div[3]/div[2]/label/label/input"));
            //element15.Click();
            driver.Quit();


        }
    }
}

