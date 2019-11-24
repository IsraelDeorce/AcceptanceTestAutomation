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

    public IWebElement GetAddToCartButton(int index)
    {      
      webDriver.driver.FindElement(By.XPath($"/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[2]/ul[1]/li[{index}]/div[1]/div[1]/div[1]/a[1]")).Click();
      //IWebElement element = webDriver.driver.FindElement(By.XPath("//span[contains(text(),'Add to cart')]"));
      //Console.WriteLine(element);
      //element.Click();

      //WebDriverWait wait = new WebDriverWait(webDriver.driver, TimeSpan.FromSeconds(30));
      Thread.Sleep(10000);
      //List<string> lstWindow = webDriver.driver.WindowHandles.ToList();
      //foreach (var handle in lstWindow)
      //{
       // Console.WriteLine(handle);
       // webDriver.driver.SwitchTo().Window(handle);
     // }
      IWebElement element = webDriver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/form[1]/div[1]/div[3]/div[1]/p[1]/button[1]"));
      Actions action = new Actions(webDriver.driver);
      action.Click(element);
      action.Perform();
      //IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/form[1]/div[1]/div[3]/div[1]/p[1]/button[1]")));

     

     // element.Click();
      return element;
    }

    public IWebElement GetCartModal()
    {
      return webDriver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/header[1]/div[3]/div[1]/div[1]/div[4]/div[1]"));
    }
  }
}
