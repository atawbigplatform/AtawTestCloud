using Ataw.Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.Core
{
    public class TestCloudUtil
    {
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

        public static bool CheckExe()
        {

            string ChomeDriverPath = "ChomeDriverPath".AppKv<string>("");

            if (!ChomeDriverPath.IsAkEmpty() && File.Exists(ChomeDriverPath+ "\\chromedriver.exe"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //输出日记
        public static void Log()
        {

        }
    }
}
