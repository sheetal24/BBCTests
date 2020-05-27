using System;
using TechTalk.SpecFlow;
using BBCTest.Base;
using BBCTest.Pages;
using OpenQA.Selenium;

namespace BBCTest.Steps
{
    [Binding]
    [Scope(Tag = "HeaderLinks")]
    public class HeaderLinksSteps : SetUp
    {
        public IWebDriver Browser;
        public HeaderLink header;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            header = new HeaderLink(Browser);
            header.NavigateMethod();
           
        }

        [When(@"I click on (.*)")]
        public void WhenIClickOnNews(string link)
        {
            header.ClickHeaderLinks(link);
        }
        
        [Then(@"I see the (.*) pages")]
        public void ThenISeeTheNewsPages(string link)
        {
            header.VerifyHeaderLinks(link);
        }
    }
}
