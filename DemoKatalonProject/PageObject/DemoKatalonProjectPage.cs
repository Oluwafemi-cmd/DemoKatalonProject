using DemoKatalonProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKatalonProject.PageObject
{
    class DemoKatalonProjectPage
    {
        public DemoKatalonProjectPage() 
        {
            driver = Hooks1.driver;
            
        }

        IWebDriver driver;


        IWebElement FirstItem => driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/ul/li[6]/div/a[2]"));
        IWebElement SecondItem => driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/ul/li[7]/div/a[2]"));
        IWebElement ThirdItem => driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/ul/li[4]/div/a[2]"));
        IWebElement FourthItem => driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/ul/li[8]/div/a[2]"));
        IWebElement ViewCart => driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/ul/li[1]/a"));
        IWebElement RemoveItem => driver.FindElement(By.XPath("//*[@id=\"post-8\"]/div/div/form/table/tbody/tr[4]/td[1]/a"));
        IWebElement UpdateCart => driver.FindElement(By.XPath("//*[@id=\"post-8\"]/div/div/form/table/tbody/tr[4]/td/button"));

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickOnFirstCart()
        {
            FirstItem.Click();
        }

        public void ClickOnSecondCart()
        {
            SecondItem.Click();
        }

        public void ClickOnThirdCart()
        {
            ThirdItem.Click();

        }

        public void ClickOnFourthCart()
        {
            FourthItem.Click();
        }

        public void ClickOnCart()
        {
            ViewCart.Click();
        }

        public void ClickOnCancelSign()
        {
            RemoveItem.Click();
        }

        public bool IsThreeItemsDisplayed()
        {
            var webDriverWait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            webDriverWait.Until(x => UpdateCart.Displayed);
            return UpdateCart.Displayed;
        }


    }
}
