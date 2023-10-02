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
    public class AddCandidateSteps : Inicializacao
    {
        public static void ValidarFirstNameObrigatorioNaTelaAddCandidato(string Username, string Password, string FirstName, string LastName, string Email)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [Recruitment]");
            Driver.FindElement(DashboardPage.btRecuitment).Click();
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(RecruitmentPage.btAdd).Click();
            WriteLine("Não preencher o Primeiro nome");
            Driver.FindElement(AddCandidatePage.FirstName).SendKeys(FirstName);
            WriteLine("Preencher o Último nome");
            Driver.FindElement(AddCandidatePage.LastName).SendKeys(LastName);
            WriteLine("Preencher o Email");
            Driver.FindElement(AddCandidatePage.Email).SendKeys(Email);
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [Save]");
            Driver.FindElement(AddCandidatePage.Save).Click();
            WriteLine("Campo obrigatório FirstName validado com sucesso");
            string FirstNameObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", FirstNameObrigatorio, "Campo obrigatório FirstName validado com sucesso");
        }

        public static void ValidarLastNameObrigatorioNaTelaAddCandidato(string Username, string Password, string FirstName, string LastName, string Email)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [Recruitment]");
            Driver.FindElement(DashboardPage.btRecuitment).Click();
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(RecruitmentPage.btAdd).Click();
            WriteLine("Não preencher o Primeiro nome");
            Driver.FindElement(AddCandidatePage.FirstName).SendKeys(FirstName);
            WriteLine("Preencher o Último nome");
            Driver.FindElement(AddCandidatePage.LastName).SendKeys(LastName);
            WriteLine("Preencher o Email");
            Driver.FindElement(AddCandidatePage.Email).SendKeys(Email);
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [Save]");
            Driver.FindElement(AddCandidatePage.Save).Click();
            WriteLine("Campo obrigatório LastName validado com sucesso");
            string LastNameObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", LastNameObrigatorio, "Campo obrigatório LastName validado com sucesso");
        }

        public static void ValidarEmailObrigatorioNaTelaAddCandidato(string Username, string Password, string FirstName, string LastName, string Email)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [Recruitment]");
            Driver.FindElement(DashboardPage.btRecuitment).Click();
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(RecruitmentPage.btAdd).Click();
            WriteLine("Não preencher o Primeiro nome");
            Driver.FindElement(AddCandidatePage.FirstName).SendKeys(FirstName);
            WriteLine("Preencher o Último nome");
            Driver.FindElement(AddCandidatePage.LastName).SendKeys(LastName);
            WriteLine("Preencher o Email");
            Driver.FindElement(AddCandidatePage.Email).SendKeys(Email);
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [Save]");
            Driver.FindElement(AddCandidatePage.Save).Click();
            WriteLine("Campo obrigatório Email validado com sucesso");
            string EmailObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", EmailObrigatorio, "Campo obrigatório Email validado com sucesso");
        }
    }
}
