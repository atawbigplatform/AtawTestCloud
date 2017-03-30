using Ataw.Framework.Core;
using Ataw.TestCloud.Core;
using Ataw.TestCloud.Data;
using Ataw.TestCloud.Page;
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

        public override void init()
        {
            driver.Navigate().GoToUrl("SeleniumMianUrl".AppKv<string>(""));//主页地址
            page = new LoginPage(driver);
        }

        public override void PageAction(PageData data)
        {
            ((LoginPage)page).OnLogin();  
        }
    }
}
