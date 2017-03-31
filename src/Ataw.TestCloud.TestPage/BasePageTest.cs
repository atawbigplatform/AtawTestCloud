using Ataw.Framework.Core;
using Ataw.TestCloud.Core;
using Ataw.TestCloud.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            string ChomeDriverPath = "ChomeDriverPath".AppKv<string>("");

            driver = new ChromeDriver(ChomeDriverPath);
        }

        abstract public void init();


        /// <summary>
        /// 页面自定义行为
        /// </summary>
        abstract public void PageAction(PageData data);

        public virtual void Action(PageData data = null)
        {

            try
            {
                init();

                var PageRegisteredName = "";

                if (data != null && data.url != null)
                {
                    string[] urls = data.url.Split('#');
                    if (urls.Length > 1)
                    {
                        string[] args = urls[1].Split('$');
                        PageRegisteredName = args[1];
                    }
                }

                TestCloudUtil.ScreenGFile(driver, PageRegisteredName + "开始");
                PageAction(data);
                TestCloudUtil.ScreenGFile(driver, PageRegisteredName + "结束");
                page.quit();
            }
            catch (Exception e)
            {
                driver.Dispose();
                driver = null;
            }
        }

        public void quit()
        {
            page.getDriver().Quit();//退出驱动
            page.getDriver().Dispose();
            driver = null;
        }

    }
}
