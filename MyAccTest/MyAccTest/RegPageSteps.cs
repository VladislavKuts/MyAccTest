using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MyAccTest
{
    [Binding]
    public class RegPageSteps
    {
        private MyChromeDriver myAccountPage = new MyChromeDriver();
        private UserData data = new UserData();

        [Given(@"My account registration page  opened")]
        public void GivenMyAccountRegistrationPageOpened()
        {
            myAccountPage.OpenPage();
        }
        
        [When(@"I enter '(.*)' in e-mail field")]
        public void WhenIEnterInE_MailField(string p0)
        {
            myAccountPage.EnterEmail(data.GetUniqueEmail());
        }
        
        [When(@"I enter '(.*)' in password field")]
        public void WhenIEnterInPasswordField(string p0)
        {
            myAccountPage.EnterPass(data.correctPass);
        }
        
        [When(@"I enter '(.*)' in confirm-password field")]
        public void WhenIEnterInConfirm_PasswordField(string p0)
        {
            myAccountPage.EnterConfirm(data.correctPass);
        }
        
        [When(@"I click Send button")]
        public void WhenIClickSendButton()
        {
            myAccountPage.ClickSubmit();
        }
        
        [When(@"I click on link Sign In")]
        public void WhenIClickOnLinkSignIn()
        {
            myAccountPage.ClickLinkSignIn();
        }
        
        [Then(@"Personal page opened")]
        public void ThenPersonalPageOpened()
        {
            Assert.AreEqual("Sign Out", myAccountPage.GetTextFromSignOutLabel());
        }
        
        [Then(@"Authorization page opened")]
        public void ThenAuthorizationPageOpened()
        {
            Assert.AreEqual("Login", myAccountPage.GetTextFromLoginButton());
        }
        
        [Then(@"Error '(.*)' showed under email-field")]
        public void ThenErrorShowedUnderEmail_Field(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
