using AutomatizaWebOrange.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutomatizaWebOrange.PageObjects
{
    public class AddCandidatePage
    {
        public static By FirstName = By.XPath("//*[@name='firstName']");
        public static By LastName = By.XPath("//*[@name='lastName']"); 
        public static By Email = By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[3]/div/div[1]/div/div[2]/input");
        public static By Save = By.XPath("//*[@type='submit']");
        public static By Cancel = By.XPath("//*[@class='oxd-button oxd-button--medium oxd-button--ghost']");
        public static By CampoObrigatorio = By.XPath("//*[(text()='Required')]");






    }
}
