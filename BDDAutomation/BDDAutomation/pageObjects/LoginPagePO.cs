using BDDAutomation.utils;
using OpenQA.Selenium;

namespace BDDAutomation.pageObjects
{
  class LoginPagePO
  {
    readonly WebDriver webDriver;

    public LoginPagePO()
    {
      webDriver = WebDriver.Instance;
    }

    public IWebElement GetSignInButton()
    {
      return webDriver.driver.FindElement(By.Id("SubmitLogin"));
    }

    public void SetEmailAddress(string email)
    {
      webDriver.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(email);
    }

    public void SetPassword(string password)
    {      
      webDriver.driver.FindElement(By.Id("passwd")).SendKeys(password);
    }

  }
}
