using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCTest.Pages
{
   public class HeaderLink
    {
        public IWebDriver Driver;

        public HeaderLink(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "orb-nav-news")]
        public IWebElement NewsLink;

        [FindsBy(How = How.ClassName, Using = "orb-nav-sport")]
        public IWebElement SportLink;

        [FindsBy(How = How.ClassName, Using = "orb-nav-weather")]
        public IWebElement WeatherLink;

        string NewsUrl = "https://www.bbc.co.uk/news";
        string SportsUrl = "https://www.bbc.co.uk/sport";
        string WeatherUrl = "https://www.bbc.co.uk/weather";

        public void NavigateMethod()
        {
            Driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        public void ClickHeaderLinks(string link)
        {
            switch(link)
            {
                case "News":
                    NewsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Sport":
                    SportLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Weather":
                    WeatherLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                default: 
                    Console.WriteLine("Wrong Link");
                    break;
            }

        }

        public void VerifyHeaderLinks(string link)
        {
            switch(link)
            {
                case "News":
                    Driver.Url.Contains(NewsUrl);
                    break;
                case "Sport":
                    Driver.Url.Contains(SportsUrl);
                    break;
                case "Weather":
                    Driver.Url.Contains(WeatherUrl);
                    break;
                default:
                    Console.WriteLine("Wrong Link");
                    break;
            }
        }

    }
}
