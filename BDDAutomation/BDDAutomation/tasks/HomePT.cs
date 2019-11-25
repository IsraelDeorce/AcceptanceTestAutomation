using BDDAutomation.pageObjects;

namespace BDDAutomation.tasks
{
  class HomePT
  {
    public HomePO homePageObject;

    public HomePT()
    {
      homePageObject = new HomePO();
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
