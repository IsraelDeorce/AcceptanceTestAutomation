
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace BDDAutomation.utils
{
  class BaseTest
  {
    public static IWebDriver CreateChrome()
    {     
      IWebDriver navegador = new ChromeDriver();
      navegador.Navigate().GoToUrl("http://www.github.com");
      return navegador;

      //erro pq Test run will use DLL(s) built for framework .NETCoreApp,Version=v1.0 and platform X86. Following DLL(s) do not match framework/platform settings
    }
  }
}