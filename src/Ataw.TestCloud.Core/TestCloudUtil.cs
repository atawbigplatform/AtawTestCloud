using Ataw.Framework.Core;
using Ataw.TestCloud.BF;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.Core
{
    public class TestCloudUtil
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="line"></param>
        /// <param name="key"></param>
        /// <param name="CmdName"></param>
        public static void SendCommandFun(string userId, string line, string key = "", string CmdName = "")
        {

            if (CmdName.IsAkEmpty())
            {
                CmdName = "SeleniumTestPage";
            }

            if (key.IsAkEmpty())
            {
                NodeServerPusher.SendCommand(new string[] { userId }, CmdName, line);
            }
            else
            {
                NodeServerPusher.SendCommand(new string[] { userId }, CmdName, new { Key = key, Value = line });
            }
        }

        /// <summary>
        /// 查看chormedriver.exe是否存在
        /// </summary>
        /// <returns></returns>
        public static bool CheckExe()
        {
            string ChomeDriverPath = "ChomeDriverPath".AppKv<string>("");

            if (!ChomeDriverPath.IsAkEmpty() && File.Exists(ChomeDriverPath + "\\chromedriver.exe"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 存储到数据库
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="line"></param>
        /// <param name="key"></param>
        /// <param name="CmdName"></param>
        public static void SendCommandFunBySql(string userId, string line, string key = "", string CmdName = "")
        {
            BFNodeNews bf = new BFNodeNews();
            bf.SendCommandFunBySql(userId, line, key, CmdName);
        }


        /// <summary>
        /// 推送消息并添加到数据库
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="line"></param>
        /// <param name="key"></param>
        /// <param name="CmdName"></param>
        public static void sendCommanAndSql(string userId, string line, string key = "", string CmdName = "")
        {
            SendCommandFun(userId, line, key, CmdName);
            SendCommandFunBySql(userId, line, key, CmdName);
        }

        /// <summary>
        /// 截图
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="name"></param>
        public static void ScreenGFile(IWebDriver driver, string name)
        {
            Screenshot screenShotFile = ((ITakesScreenshot)driver).GetScreenshot();
            string dataStr = DateTime.Now.ToString("yyyyMMddhhmmsssss");

            string TestImagePath = "TestImagePath".AppKv<string>("C:\\TestCloudeImage\\");

            if (!Directory.Exists(TestImagePath))
            {
                Directory.CreateDirectory(TestImagePath);
            }

            screenShotFile.SaveAsFile(TestImagePath + dataStr + "+" + name + ".jpg", ScreenshotImageFormat.Jpeg);
        }

        //输出日记  
        public static void Log()
        {

        }

        /// <summary>
        /// 断言
        /// </summary>
        public static void Assert()
        {

        }
    }
}
