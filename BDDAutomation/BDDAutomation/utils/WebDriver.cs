
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BDDAutomation.utils
{
  public sealed class WebDriver
  {
    private static WebDriver instance;
    public IWebDriver driver { get; set; }   
    
    public void startChrome()
    {
      driver = new ChromeDriver("./");
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30.00);
      driver.Manage().Window.Maximize();
      driver.Url = "http://automationpractice.com/";
    }

    private WebDriver() { }

    public static WebDriver Instance
    {
      get
      {
        if (instance == null)
          lock (typeof(WebDriver))
            if (instance == null) instance = new WebDriver();

        return instance;
      }
    }

    public void closeWindow() { driver.Quit(); }
  }
}