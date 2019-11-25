using BDDAutomation.pageObjects;

namespace BDDAutomation.tasks
{
  class LoginPT
  {
    public LoginPO loginPageObject;

    public LoginPT()
    {
      loginPageObject = new LoginPO();
    }

    public void Login(string email, string password)
    {
      loginPageObject.SetEmailAddress(email);
      loginPageObject.SetPassword(password);
      loginPageObject.GetSignInButton().Click();
    }
  }
}
