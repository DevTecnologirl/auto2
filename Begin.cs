using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject3
{
    public class Begin
    {
        //intanciar biblioteca selenium 
        public IWebDriver driver;
        public bool driverQuit = true;

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver(); //chromeDriver importado através de: pacotes > gerenciar pacotes > procurar > install
            driver.Navigate().GoToUrl("https://www2.correios.com.br/sistemas/buscacep/buscaCep.cfm"); // busca site 
            driver.Manage().Window.Maximize(); //Maximiza a tela que abrirá
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); // espera 5s para encontrar elemento
            driverQuit = false;
        }

      
        [TearDown]
        public void FimTeste()
        {
           //fechar navegador
          if (driverQuit) driver.Quit();
        }
    }
}