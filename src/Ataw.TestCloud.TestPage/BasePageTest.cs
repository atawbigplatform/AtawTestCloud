using Ataw.TestCloud.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.TestPage
{
    /// <summary>
    /// 测试页面基类
    /// </summary>
    public abstract class BasePageTest
    {
        protected IWebDriver driver = null;
        public PageTestBase page = null;

        public BasePageTest()
        {
            driver = DriverFactory.getdriver();
        }

        abstract public void init();


        public void quit()
        {
            page.getDriver().Quit();//退出驱动
            page.getDriver().Dispose();
            driver = null;
        }

    }
}
