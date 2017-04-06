using Ataw.Framework.Core;
using Ataw.TestCloud.Core;
using Ataw.TestCloud.Data;
using Ataw.TestCloud.Page;
using Ataw.TestCloud.Table;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.TestPage
{
    //登陆测试页面
    public class LoginPageTest : BasePageTest
    {
        public override string PageName => "LoginPageTest";

        public override void init()
        {
            initCaseModel("登陆页面测试");
            driver.Navigate().GoToUrl("SeleniumMianUrl".AppKv<string>(""));//主页地址
            page = new LoginPage(driver);
        }

        public override void PageAction(PageData data)
        {
            AddStepModel("登陆开始");

            ((LoginPage)page).Login();
            ((LoginPage)page).OnLogin();
            //bfTestStep.Add(new Table.TestStep {UserID= _UserID,d})q
            AddStepModel("登陆结束");

        }
    }
}
