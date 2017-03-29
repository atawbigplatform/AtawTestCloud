using Ataw.Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.Core
{
    public class DriverFactory
    {
        private static IWebDriver driver = null;

        private static Object lockobj = new object();

        /// <summary>
        /// 单利模式
        /// </summary>
        /// <returns></returns>
        public static IWebDriver getdriver()
        {
            if (driver == null)
            {
                lock (lockobj)
                {
                    string ChomeDriverPath = "ChomeDriverPath".AppKv<string>("");
                    //以后可以进行驱动替换
                    if (driver == null) driver = new ChromeDriver(ChomeDriverPath);
                }
            }
            return driver;
        }

        private DriverFactory()
        {

        }
    }
}
