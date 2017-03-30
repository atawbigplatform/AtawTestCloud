using Ataw.Framework.Core;
using Ataw.TestCloud.Core;
using Ataw.TestCloud.Data;
using Ataw.TestCloud.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.TestPage
{
    public class MinTestPageTest : BasePageTest
    {
        public override void init()
        {
            driver.Navigate().GoToUrl("SeleniumMianUrl".AppKv<string>(""));//主页地址
            //登陆网站
            LoginPage login = new LoginPage(driver);
            login.Login();
            page = new MinTestPage(driver);
        }

        public override void PageAction(PageData data)
        {
            new WebDriverWait(driver, new TimeSpan(0, 0, 20)).Until(a =>
            {
                return a.Title == "主页";
            });
            //等待 页面跳转然
            page.getDriver().Navigate().GoToUrl(data.url);

            new WebDriverWait(driver, new TimeSpan(0, 0, 20)).Until(a =>
            {
                return a.Title == "TestMinPage页面;";
            });

            ((MinTestPage)page).Action();
        }
    }
}
