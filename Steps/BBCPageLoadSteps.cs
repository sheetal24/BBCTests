using System;
using TechTalk.SpecFlow;
using BBCTest.Base;
using OpenQA.Selenium;
using BBCTest.Pages;

namespace BBCTest.Steps
{
    [Binding]
    [Scope(Tag = "BBCPageLoad")]
    public class BBCPageLoadSteps : SetUp
    {
        public IWebDriver Browser;
        public BBCPageLoad pageload;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            pageload = new BBCPageLoad(Browser);
            pageload.NavigateBBC();
            
        }
        
        [Then(@"I see BBC page loads")]
        public void ThenISeeBBCPageLoads()
        {
            pageload.CheckMessage();
        }
    }
}
