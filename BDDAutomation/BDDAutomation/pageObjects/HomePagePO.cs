using BDDAutomation.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDAutomation.pageObjects
{
  class HomePagePO
  {
    readonly WebDriver webDriver;

    public HomePagePO()
    {
      webDriver = WebDriver.Instance;
    }
    public IWebElement GetSignInButton()
    {
      return webDriver.driver.FindElement(By.PartialLinkText("Sign in"));
    }

    public IWebElement GetDressesButton()
    {
      return webDriver.driver.FindElement(By.XPath("//body[@id='index']/div[@id='page']/div[@class='header-container']/header[@id='header']/div/div[@class='container']/div[@class='row']/div[@id='block_top_menu']/ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li[2]/a[1]"));
    }
  }
}