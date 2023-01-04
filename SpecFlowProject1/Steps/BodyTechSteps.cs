using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class BodyTechSteps
    {
        ChromeDriver driver = new ChromeDriver();

        [Given(@"acesso ao google")]
        public void GivenAcessoAoGoogle()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            driver.Navigate().GoToUrl("https://google.com");
            driver.Quit();
        }

        [When(@"pesquiso pelo BodyTech")]
        public void WhenPesquisoPeloBodyTech()
        {

        }

        [Then(@"site deve estar acessível")]
        public void ThenSiteDeveEstarAcessivel()
        {

        }
    }
}
