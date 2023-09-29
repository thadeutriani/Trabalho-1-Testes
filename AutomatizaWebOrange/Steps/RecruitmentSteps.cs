using AutomatizaWebOrange.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Steps
{
    public class RecruitmentSteps : Inicializacao
    {
        public static void ValidarTelaCadastroCandidato(string Username, string Password)
        {
            LoginSteps.Login(Username, Password);
            WriteLine("Clicar no botão [Recruitment]");
            Driver.FindElement(DashboardPage.btRecuitment).Click();
            Thread.Sleep(5000);
            WriteLine("Clicar no botão [+ Add]");
            Driver.FindElement(RecruitmentPage.btAdd).Click();
            WriteLine("Validar se está na tela de adicionar candidatos");
            string pgAddCandidatoAtual = Convert.ToString(Driver.Url);
            string pgAddCandidatoEsperdo = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/recruitment/addCandidate");
            Assert.AreEqual(pgAddCandidatoEsperdo, pgAddCandidatoAtual, "Página carregada com sucesso!");
            
        }
    }
}
