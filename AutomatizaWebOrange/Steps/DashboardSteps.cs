using AutomatizaWebOrange.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Steps
{
    public class DashboardSteps : Inicializacao
    {
        public static void ValidarExibicaoDaTelaRecruitment(string Username, string Password)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [Recruitment]");
            Driver.FindElement(DashboardPage.btRecuitment).Click();
            Thread.Sleep(5000);
            WriteLine("Validar se está na tela Recritment");
            string pgRecuitmentAtual = Convert.ToString(Driver.Url);
            string pgRecuitmentEsperdo = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/recruitment/viewCandidates");
            Assert.AreEqual(pgRecuitmentEsperdo, pgRecuitmentAtual, "Página carregada com sucesso!");
        }
    }
}
