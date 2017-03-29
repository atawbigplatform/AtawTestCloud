using Ataw.TestCloud.DB;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.Core
{
    //接口还是抽象类
    public abstract class PageTestBase
    {

        protected IWebDriver driver { get; }

        protected DateTime startTime { get; set; }

        protected DateTime endTime { get; set; }

        protected TimeSpan duration { get; set; }

        protected TestCase testCase { get; set; }

        

        public PageTestBase(IWebDriver driver)
        {
            if (driver == null) throw new NullReferenceException("浏览器驱动不能为null");
            this.driver = driver;//基类中进行定位
        }

        public IWebDriver getDriver()
        {
            return driver;
        }


        //获取当前的地址
        public String getCurrentUrl()
        {
            return driver.Url;
        }

        
        public IWebElement getElementByID(string  ElementName)
        {
            return driver.FindElement(By.Id(ElementName));
        }

        public ICollection<IWebElement> getElementByName(string ElementName)
        {
            return driver.FindElements(By.ClassName(ElementName));
        }

        public IWebElement getElement(By by)
        {
            return driver.FindElement(by);
        }

        public ICollection<IWebElement> getElements(By by)
        {
            return driver.FindElements(by);
        }


        public void stop()
        {
            driver.Quit();
        }

        //public virtual void onTest(TestCase testcase)
        //{

        //    if (startTime != null)
        //    {
        //        endTime = DateTime.Now;
        //        duration = startTime - endTime;
        //    }
        //    driver.Quit();
        //}
    }
}
