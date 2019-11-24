using BDDAutomation.pageObjects;

namespace BDDAutomation.tasks
{
  class LoginPageTask
  {
    public LoginPagePO loginPageObject;

    public LoginPageTask()
    {
      loginPageObject = new LoginPagePO();
    }

    public void Login(string email, string password)
    {
      loginPageObject.SetEmailAddress(email);
      loginPageObject.SetPassword(password);
      loginPageObject.GetSignInButton().Click();
    }
  }
}
