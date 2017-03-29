using Ataw.TestCloud.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ataw.TestCloud.Page
{
    public class MinTestPage : PageTestBase
    {
        public MinTestPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement text
        {
            get
            {
                return getElementByID("text");
            }
            set
            {
                text = value;
            }
        }
        public IWebElement btn
        {
            get
            {
                return getElementByID("btn");
            }
            set
            {
                btn = value;
            }
        }
        public IWebElement span
        {
            get
            {
                return getElementByID("span");
            }
            set
            {
                span = value;
            }
        }


        public void Action()
        {
            text.SendKeys("这个Selenium真的能折腾人");
            btn.Click();
            //获得弹出框
            var alert = driver.SwitchTo().Alert();
            //点击确定
            alert.Accept();
        }

    }
}
