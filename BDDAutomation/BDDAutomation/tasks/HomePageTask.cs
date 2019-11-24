using BDDAutomation.pageObjects;

namespace BDDAutomation.tasks
{
  class HomePageTask
  {
    public HomePagePO homePageObject;

    public HomePageTask()
    {
      homePageObject = new HomePagePO();
    }

    public void ClickSignInButton()
    {
      homePageObject.GetSignInButton().Click();
    }

    public void ClickDressesButton()
    {
      homePageObject.GetDressesButton().Click();
    }
  }
}
