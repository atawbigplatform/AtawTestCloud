
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ataw.Framework.Core;
using Ataw.TestCloud.DA;
using Ataw.TestCloud.DB;
using Ataw.TestCloud.Table;

namespace Ataw.TestCloud.BF
{
    public class BFTestCase : TestCloudBaseBF
    {
        public string Add(TestCase model)
        {
            DATestCase da = new DATestCase(UnitOfData);
            model.FID = UnitOfData.GetUniId();
            da.Add(model);
            return model.FID;
        }


        public string Add(string UserID, string PageName, string Title = "")
        {
            TestCase model = new TestCase();
            model.UserID = UserID;
            model.TestTime = DateTime.Now;
            model.PageName = PageName;
            model.Title = Title.IsAkEmpty() ? PageName + "≤‚ ‘" : Title;
            return Add(model);
        }

    }
}

