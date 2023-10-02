using AutomatizaWebOrange.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class Recruitment : Inicializacao
    {
        [TestMethod]
        [TestCategory("08")]
        public void ValidarTelaCadastroCandidato()
        {

            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: Clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[Recruitment]");
            WriteLine("E: Exibir a tela 'Recruitment'");
            WriteLine("Qaundo: Clicar no botão [+ Add]");
            WriteLine("Então: Será redirecionado ao link: 'https://opensource-demo.orangehrmlive.com/web/index.php/recruitment/addCandidate'");


            RecruitmentSteps.ValidarTelaCadastroCandidato("Admin", "admin123");
        }
    }
}
