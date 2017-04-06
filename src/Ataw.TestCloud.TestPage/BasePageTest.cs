using Ataw.Framework.Core;
using Ataw.TestCloud.BF;
using Ataw.TestCloud.Core;
using Ataw.TestCloud.Data;
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
    /// <summary>
    /// 测试页面基类
    /// </summary>
    public abstract class BasePageTest
    {
        protected IWebDriver driver = null;

        public PageTestBase page = null;

        public BFTestCase bfTestCase = null;

        public BFTestStep bfTestStep = null;
        /// <summary>
        /// 页面名称
        /// </summary>
        public virtual string PageName { get; }

        private string CaseID { get; set; }

        public List<TestStep> ModelSetps { get; set; }

        public TestCase ModelCase { get; set; }

        public int Addflag = 0;

        public BasePageTest()
        {
            string ChomeDriverPath = "ChomeDriverPath".AppKv<string>("");

            driver = new ChromeDriver(ChomeDriverPath);

            ModelSetps = new List<TestStep>();

        }

        private string _UserID
        {
            get;
            set;
        }

        /// <summary>
        /// 跳专到测试页面之前的操作（比如登陆）
        /// </summary>
        abstract public void init();


        /// <summary>
        /// 页面自定义行为
        /// </summary>
        abstract public void PageAction(PageData data);

        public virtual void Action(PageData data = null)
        {

            try
            {
                if (data.userId != null)
                    _UserID = data.userId;

                if (bfTestCase == null)
                    bfTestCase = new BFTestCase();

                if (bfTestStep == null)
                {
                    bfTestStep = new BFTestStep();
                    bfTestStep.SetUnitOfData(bfTestCase.UnitOfData);
                }

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

                init();

                TestCloudUtil.ScreenGFile(driver, PageRegisteredName + "开始");

                //var userID = AtawAppContext.Current.UserId;
                PageAction(data);
                TestCloudUtil.ScreenGFile(driver, PageRegisteredName + "结束");
                page.quit();
            }
            catch (Exception e)
            {
                //失败 几率错误信息
                if (ModelCase != null)
                {
                    Addflag = 1;
                    ModelCase.IsPass = false;
                    CaseID = bfTestCase.Add(ModelCase);
                    TestStep errorModel = new TestStep() { TestCaseFID = CaseID, IsPass = "1", CmdName = "SeleniumTestPage", Line = e.Message, IsSend = "1", UserID = _UserID };
                    this.ModelSetps.Add(errorModel);
                }
            }
            finally
            {
                if (ModelCase != null)
                {
                    //判断是否报错
                    if (Addflag == 0)
                    {
                        ModelCase.IsPass = true;
                        CaseID = bfTestCase.Add(ModelCase);
                    }

                    foreach (var item in ModelSetps)
                    {
                        item.TestCaseFID = CaseID;
                        bfTestStep.Add(item);
                    }
                }

                bfTestCase.Submit();


                driver.Quit();
                driver.Dispose();
            }
        }

        public void quit()
        {
            page.getDriver().Quit();//退出驱动
            page.getDriver().Dispose();
            driver = null;
        }


        public void initCaseModel(String title)
        {
            ModelCase = new TestCase()
            {
                UserID = _UserID,
                PageName = PageName,
                IsPass = true,
                TestTime = DateTime.Now,
                Title = title
            };
        }

        public void AddStepModel(string line)
        {
            TestStep errorModel = new TestStep() { TestCaseFID = CaseID, IsPass = "1", CmdName = "SeleniumTestPage", Line = line, IsSend = "1", UserID = _UserID };
            this.ModelSetps.Add(errorModel);
        }

    }
}
