using BDDAutomation.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BDDAutomation.pageObjects
{
  class DressesPO
  {
    readonly WebDriver webDriver;

    public DressesPO()
    {
      webDriver = WebDriver.Instance;
    }

    public IReadOnlyCollection<IWebElement> GetDresses()
    {
      return webDriver.driver.FindElements(By.XPath("//ul[@class='product_list grid row']"));
    }

    public IWebElement GetDressImage(string dressName)
    {      
      return webDriver.driver.FindElement(By.PartialLinkText(dressName));
    }
    public IWebElement GetAddToCartButton()
    {
      return webDriver.driver.FindElement(By.Name("Submit"));
    }

    public IWebElement GetCartModal()
    {
      return webDriver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/header[1]/div[3]/div[1]/div[1]/div[4]/div[1]"));
    }
  }
}
