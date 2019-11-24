using System;
using BDDAutomation.tasks;
using BDDAutomation.utils;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;

namespace BDDAutomation.tests.steps
{
  [Binding]
  public class UserSignInSteps
  {
    WebDriver webDriver;
    [Given(@"I am on the automationpractice home page")]
    public void GivenIAmOnTheAutomationpracticeHomePage()
    {
      webDriver = WebDriver.Instance;
      webDriver.startChrome();
    }

    [When(@"I click on the Sign In Button")]
    public void WhenIClickOnTheSignInButton()
    {
      HomePageTask element = new HomePageTask();
      element.ClickSignInButton();
    }

    [When(@"I provide my email and password to login")]
    public void WhenIProvideMyEmailAndPasswordToLogin()
    {
      LoginPageTask element = new LoginPageTask();
      element.Login("israel.idvj@gmail.com", "12345");
    }

    [Then(@"I should be redirected to my account page")]
    public void ThenIShouldBeRedirectedToMyAccountPage()
    {
      Assert.Equal("My account - My Store", webDriver.driver.Title);
      WebDriver.Instance.closeWindow();
    }
  }
}
