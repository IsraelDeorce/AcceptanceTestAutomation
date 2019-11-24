using BDDAutomation.pageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace BDDAutomation.tasks
{
  class DressesPT
  {
    public DressesPO dressesPageObject;

    public DressesPT()
    {
      dressesPageObject = new DressesPO();
    }

    public IReadOnlyCollection<IWebElement> VisualizeDresses()
    {
      return dressesPageObject.GetDresses();
    }

    public void AddDressToCart(int dressIndex)
    {
      dressesPageObject.GetAddToCartButton(dressIndex).Click();
    }

    public IWebElement VerifyAddedToCart()
    {
      return dressesPageObject.GetCartModal();
    }
  }
}
