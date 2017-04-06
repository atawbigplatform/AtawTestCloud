using Ataw.Framework.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ataw.TestCloud.Service;
using Ataw.Framework.Core;
using Ataw.TestCloud.Core;

namespace Ataw.TestCloud.Web.Controllers
{
    public class TestPageController : AtawBaseController
    {
        public string TestDemoPage(string url)
        {
            //先检查exe在不在
            if (TestCloudUtil.CheckExe())
            {
                TestDemoService service = new TestDemoService();
                service.Test(url);
                return ReturnJson("");
            }
            else
            {
                return ReturnJson("No File");
            }

        }

        public string Login(string url)
        {
            //先检查exe在不在
            if (TestCloudUtil.CheckExe())
            {
                TestDemoService service = new TestDemoService();
                var userID = AtawAppContext.Current.UserId;
                service.Login(url, userID);
                return ReturnJson("");
            }
            else
            {
                return ReturnJson("No File");
            }
        }

        public string TestMianPage(string url)
        {
            if (TestCloudUtil.CheckExe())
            {
                TestDemoService service = new TestDemoService();
                service.TestMianPage(url);
                return ReturnJson("");
            }
            else
            {
                return ReturnJson("No File");
            }
        }

        public string Demo()
        {
            return "dddd123";
        }
    }
}