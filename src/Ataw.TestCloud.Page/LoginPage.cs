using Ataw.TestCloud.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.Page
{
    public class LoginPage : PageTestBase
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement _login
        {
            get
            {
                return getElementByID("inputLoginName");
            }
            set
            {
                _login = value;
            }
        }


        public IWebElement _password
        {
            get
            {
                return getElementByID("inputPass");
            }
            set
            {
                _password = value;
            }
        }

        public IWebElement _btLogin
        {
            get
            {
                return getElementByID("btLogin");
            }
            set
            {
                _btLogin = value;
            }
        }

        public void OnLogin()
        {
            if (_btLogin != null) _btLogin.Click();
        }

        public void SendUserName(string name)
        {
            _login.Clear();
            _login.SendKeys(name);
        }

        public void SendPass(string pass)
        {
            _password.Clear();
            _password.SendKeys(pass);
        }

        /// <summary>
        /// 登陆一系列的动作 
        /// </summary>
        public void Login()
        {
            if (driver == null) throw new NullReferenceException("Driver没有初始化");
            SendUserName("ataws");
            SendPass("ataws");
            OnLogin();
        }

    }
    //public override void onTest(TestCase testcase)
    //{
    //    startTime = DateTime.Now;

    //    driver.Navigate().GoToUrl("http://192.168.68.19:6725/rightcloud/auth/index/1");

    //    IWebElement _login = driver.FindElement(By.Id("inputLoginName"));
    //    IWebElement _password = driver.FindElement(By.Id("inputPass"));

    //    _login.Clear();
    //    _password.Clear();

    //    _login.SendKeys("ataws");
    //    _password.SendKeys("ataws");

    //    IWebElement _btLogin = driver.FindElement(By.Id("btLogin"));
    //    _btLogin.Click();

    //    base.onTest(testcase);//测试完之后 释放资源
    //}
}
