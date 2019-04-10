using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;


namespace MyAccTest
{
    
    class MyChromeDriver
    {
        private IWebDriver driver;
        private RegPOM page = new RegPOM();
        

        public void OpenPage()
        {
            driver = new ChromeDriver(@"C:\Users\User\Desktop");
            driver.Navigate().GoToUrl(page.pageAddres);
            Thread.Sleep(4000);
        }

        public void EnterEmail(String email)
        {
            driver.FindElement(By.Id(page.emailFieldID)).SendKeys(email);
        }

        public void EnterPass(String pass)
        {
            driver.FindElement(By.Id(page.passwordFieldID)).SendKeys(pass);
        }

        public void EnterConfirm(String confirmPass)
        {
            driver.FindElement(By.Id(page.passConfirmFieldID)).SendKeys(confirmPass);
        }

        public void ClickSubmit()
        {
            driver.FindElement(By.ClassName(page.btnSubmit)).Click();
        }

        public void ClickLinkSignIn()
        {
            driver.FindElement(By.ClassName(page.loginLink)).Click();
        }

        public String GetTextFromSignOutLabel()
        {
            return driver.FindElement(By.ClassName(page.signOutLabel)).Text;
        }

        public String GetTextFromLoginButton()
        {
            return driver.FindElement(By.ClassName(page.loginButton)).Text;
        }


    }
}
