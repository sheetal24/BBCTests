using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using BBCTest.Base;
using BBCTest.Pages;

namespace BBCTest
{
    [Binding]
    [Scope(Tag = "BBCSignIn")]
    public class BBCSignInSteps : SetUp
    {
        public IWebDriver Browser;
        public BBCSignIn signin;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            Browser.Navigate().GoToUrl("https://bbc.co.uk");
        }
        
        [When(@"I click signin")]
        public void WhenIClickSignin()
        {
            signin = new BBCSignIn(Browser);
            signin.ClickSignIn();
            
        }
        
        [When(@"I login with valid user details")]
        public void WhenILoginWithValidUserDetails()
        {
            signin.UserDetails();
        }
        
        [Then(@"I see login is succesful")]
        public void ThenISeeLoginIsSuccesful()
        {
            signin.VerifyLogin();
        }
    }
}
