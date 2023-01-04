using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class BodyTechSteps
    {
        private WebDriver WebDriver { get; set; } = null!;
        ChromeDriver driver = new ChromeDriver(@"C:\Users\Douglas Guilherme\source\repos\SpecFlowProject1\SpecFlowProject1\Drivers\");
        IWebDriver _driver = new ChromeDriver();

        [Given(@"acesso ao google")]
        public void GivenAcessoAoGoogle()
        {
            
            WebDriver.Navigate().GoToUrl("https://google.com");
            _driver.FindElement(By.XPath("//input"));
            _driver.Quit();

        }

        [When(@"pesquiso pelo BodyTech")]
        public void WhenPesquisoPeloBodyTech()
        {
            driver.Navigate().GoToUrl("https://google.com");
        }

        [Then(@"site deve estar acessível")]
        public void ThenSiteDeveEstarAcessivel()
        {
            driver.Navigate().GoToUrl("https://google.com");
            driver.Quit();
        }
    }
}
