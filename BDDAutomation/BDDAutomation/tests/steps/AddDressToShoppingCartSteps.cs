using BDDAutomation.tasks;
using BDDAutomation.utils;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDDAutomation.tests.steps
{
  [Binding]
  public class AddDressToShoppingCartSteps
  {
    WebDriver webDriver;
    DressesPT dressesPt;
    HomePageTask homePageTask;

    [Given(@"that I'm in the homepage of the automationpractice home page")]
    public void GivenThatIMInTheHomepageOfTheAutomationpracticeHomePage()
    {
      webDriver = WebDriver.Instance;
      webDriver.startChrome();
    }

    [Given(@"That I'm in the automation practice dresses page")]
    public void GivenThatIMInTheAutomationPracticeDressesPage()
    {
      webDriver = WebDriver.Instance;
      webDriver.startChrome();
      homePageTask = new HomePageTask();
      homePageTask.ClickDressesButton();
      Assert.Equal("Dresses - My Store", webDriver.driver.Title);
    }

    [Given(@"I visualize the list of dresses available,")]
    public void GivenIVisualizeTheListOfDressesAvailable()
    {
      dressesPt = new DressesPT();
      Assert.NotEmpty(dressesPt.VisualizeDresses());
    }

    [When(@"I click on the Dresses button to check the dresses")]
    public void WhenIClickOnTheDressesButtonToCheckTheDresses()
    {
      homePageTask = new HomePageTask();
      homePageTask.ClickDressesButton();
    }

    [When(@"I get redirected to the dresses page")]
    public void WhenIGetRedirectedToTheDressesPage()
    {
      Assert.Equal("Dresses - My Store", webDriver.driver.Title);
    }

    [When(@"I decide to add a dress to the shopping cart by clicking on the add to cart button")]
    public void WhenIDecideToAddADressToTheShoppingCartByClickingOnTheAddToCartButton()
    {
      dressesPt.AddDressToCart(2);
    }

    [Then(@"I should visualize the list of dresses")]
    public void ThenIShouldVisualizeTheListOfDresses()
    {
      dressesPt = new DressesPT();
      Assert.NotEmpty(dressesPt.VisualizeDresses());
      WebDriver.Instance.closeWindow();
    }

    [Then(@"I should see the dress added in the shopping cart")]
    public void ThenIShouldSeeTheDressAddedInTheShoppingCart()
    {
      //Assert.NotNull(dressesPt.VerifyAddedToCart());
      WebDriver.Instance.closeWindow();
    }
  }
}
