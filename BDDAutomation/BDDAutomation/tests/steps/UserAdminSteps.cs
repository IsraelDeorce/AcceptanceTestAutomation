using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Xunit;

namespace BDDAutomation.tests.steps
{
  [Binding]
  public class UserAdminSteps
  {
    IWebDriver driver;

    [Given(@"That I am on the edgewords web site")]
    public void GivenThatIAmOnTheEdgewordsWebSite()
    {
      driver = new ChromeDriver("./");
      driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
    }

    [When(@"I login as an administrator")]
    public void WhenILoginAsAnAdministrator()
    {
      //driver.FindElement(By.PartialLinkText("Sign in")).Click();
      driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("israel.idvj@gmail.com");
      driver.FindElement(By.Id("passwd")).SendKeys("12345");
      driver.FindElement(By.Id("SubmitLogin")).Click();
    }

    [Then(@"I see the full admin list of options")]
    public void ThenISeeTheFullAdminListOfOptions()
    {
      Console.WriteLine("It worked!");
      Assert.Equal("My account - My Store", driver.Title);
    }
  }
}
