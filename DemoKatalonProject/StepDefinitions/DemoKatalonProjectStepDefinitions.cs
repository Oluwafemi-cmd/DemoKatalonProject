using DemoKatalonProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DemoKatalonProject.StepDefinitions
{
    [Binding]
    public class DemoKatalonProjectStepDefinitions
    {
        DemoKatalonProjectPage demoKatalonProjectPage;

        public DemoKatalonProjectStepDefinitions()
        {
            demoKatalonProjectPage = new DemoKatalonProjectPage();
        }

        [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            demoKatalonProjectPage.NavigateToWebsite(url);
        }

        [Given(@"I Click on Add Cart on my first choice")]
        public void GivenIClickOnAddCartOnMyFirstChoice()
        {
            demoKatalonProjectPage.ClickOnFirstCart();
        }

        [Given(@"I Click on Add Cart on my second choice")]
        public void GivenIClickOnAddCartOnMySecondChoice()
        {
            demoKatalonProjectPage.ClickOnSecondCart();
        }

        [Given(@"I Click on Add Cart on my third choice")]
        public void GivenIClickOnAddCartOnMyThirdChoice()
        {
            
            demoKatalonProjectPage.ClickOnThirdCart();
        }

        [Given(@"I Click on Add cart on my fourth choice")]
        public void GivenIClickOnAddCartOnMyFourthChoice()
        {
            demoKatalonProjectPage.ClickOnFourthCart();
        }


        [Given(@"I Click on Cart Button")]
        public void GivenIClickOnCartButton()
        {
           
            demoKatalonProjectPage.ClickOnCart();
        }

        [When(@"I Remove the Lowest Price Item from my cart")]
        public void WhenIRemoveTheLowestPriceItemFromMyCart()
        {
            demoKatalonProjectPage.ClickOnCancelSign();
        }

        [Then(@"I Should be able to verify three itemin my cart")]
        public void ThenIShouldBeAbleToVerifyThreeIteminMyCart()
        {
            
            Assert.That(demoKatalonProjectPage.IsThreeItemsDisplayed);
        }
    }
}
