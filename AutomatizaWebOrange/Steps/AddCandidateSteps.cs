using AutomatizaWebOrange.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Steps
{
    public class AddCandidatesSteps : Inicializacao
    {
        public static void ValidarAdicionarCandidato(string Username, string Password, string FirstName, string MiddleName, string LastName, string Vacancy,
            string Email, string ContactNumber, string Keyword, string Notes)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [Recruitment]");
            Driver.FindElement(DashboardPage.btRecuitment).Click();
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(RecruitmentPage.btAdd).Click();
            WriteLine("Preencher o Primeiro nome");
            Driver.FindElement(AddCandidatePage.FirstName).SendKeys(FirstName);
            WriteLine("Preencher o nome do meio");
            Driver.FindElement(AddCandidatePage.MiddleName).SendKeys(MiddleName);
            WriteLine("Preencher o Último nome");
            Driver.FindElement(AddCandidatePage.LastName).SendKeys(LastName);
            WriteLine("Selecionar a Vaga");
            Driver.FindElement(AddCandidatePage.Vacancy).Click();


            Driver.(By.XPath($"//*[text() = '{Vacancy}']")));
            // Parei akiiiiii
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [Save]");
            Driver.FindElement(AddCandidatePage.Save).Click();
            WriteLine("Validar se está na tela de aplicação do candidato");
            string CandidateApplicationStagePageAtual = Convert.ToString(Driver.FindElement(CandidateApplicationStagePage.pgCandidateApplicationStage).Text);
            string CandidateApplicationStagePageEsperdo = Convert.ToString("Application Stage");
            Assert.AreEqual(CandidateApplicationStagePageEsperdo, CandidateApplicationStagePageAtual, "Página carregada com sucesso!");

        }
    }
}
