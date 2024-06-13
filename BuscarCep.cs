using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject3
{
     class BuscarCep : Begin //:Begin = herdar informações da class Begin
    {
        [Test]
        public void Teste()
        {
            //preencher info
            driver.FindElement(By.Name("Localidade")).SendKeys("Campos dos Goytacazes");
            driver.FindElement(By.Name("Tipo")).SendKeys("Parque");
            driver.FindElement(By.Name("Numero")).SendKeys("37");
            driver.FindElement(By.Name("Logradouro")).SendKeys("tabelião lobo da costa");
            driver.FindElement(By.Name("UF")).SendKeys("RJ");

            //button pesquisar
            driver.FindElement(By.XPath("//input[@value='Buscar']")).Click();

            //validar consulta 1 cod e 1 dado
         Assert.That(driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div/div/div[2]/div[2]/div[2]/table/tbody/tr[2]/td[1]")).Text, Does.Contain("Rua Tabelião José Lobo da Costa "));
        }
    }
}
