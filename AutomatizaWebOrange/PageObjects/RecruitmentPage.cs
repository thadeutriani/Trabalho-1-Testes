using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaWebOrange.PageObjects
{
    public class RecruitmentPage
    {
        public static By pgRecruitmet = By.XPath("//*[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']");
        public static By btAdd = By.XPath("//*[@class='oxd-button oxd-button--medium oxd-button--secondary']");
    }
}
