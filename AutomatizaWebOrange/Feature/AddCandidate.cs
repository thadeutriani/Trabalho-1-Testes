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
    public class AddCandidate : Inicializacao
    {
        [TestMethod]
        [TestCategory("09")]
        public void ValidarFirstNameObrigatorioNaTelaAddCandidato()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[Recruitment]");
            WriteLine("E: exibir a tela 'Recruitment'");
            WriteLine("E: Clicar no botão [+ Add]");
            WriteLine("E: Exibir a tela de cadastro de candidatos");
            WriteLine("E: Não preencher o campo @FirstName ");
            WriteLine("E: Preencher os campos @LastName e @Email com os dados do candidato");
            WriteLine("Quando clicar no botão [Save]");
            WriteLine("Então: O cadastro não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @FirstName");
            AddCandidateSteps.ValidarFirstNameObrigatorioNaTelaAddCandidato("Admin", "admin123", "", "Silva", "jose.silva@teste.com");
        }

        [TestMethod]
        [TestCategory("10")]
        public void ValidarLastNameObrigatorioNaTelaAddCandidato()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[Recruitment]");
            WriteLine("E: exibir a tela 'Recruitment'");
            WriteLine("E: Clicar no botão [+ Add]");
            WriteLine("E: Exibir a tela de cadastro de candidatos");
            WriteLine("E: Preencher o campo @FirstName com os dados do candidato");
            WriteLine("E: Não preencher o campo @LastName");
            WriteLine("E: Preencher o campo @Email com os dados do candidato");
            WriteLine("Quando clicar no botão [Save]");
            WriteLine("Então: O cadastro não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @LastName");
            AddCandidateSteps.ValidarLastNameObrigatorioNaTelaAddCandidato("Admin", "admin123", "José", "", "jose.silva@teste.com");
        }

        [TestMethod]
        [TestCategory("11")]
        public void ValidarEmailObrigatorioNaTelaAddCandidato()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário previamente cadastrado");
            WriteLine("E: clicar no botão[Login]");
            WriteLine("E: O login ser realizado com sucesso.");
            WriteLine("E: Exibir a tela Dashboard");
            WriteLine("E: Clicar no botão[Recruitment]");
            WriteLine("E: exibir a tela 'Recruitment'");
            WriteLine("E: Clicar no botão [+ Add]");
            WriteLine("E: Exibir a tela de cadastro de candidatos");
            WriteLine("E: Preencher os campos @FirstName e @LastName com os dados do candidato");
            WriteLine("E: Não preencher o campo @Email");
            WriteLine("Quando clicar no botão [Save]");
            WriteLine("Então: O cadastro não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @Email");
            AddCandidateSteps.ValidarEmailObrigatorioNaTelaAddCandidato("Admin", "admin123", "José", "Silva", "");
        }
    }
}
