
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
    public class BFTestStep : TestCloudBaseBF
    {
        public string Add(TestStep model)
        {
            DATestStep da = new DATestStep(UnitOfData);
            model.FID = UnitOfData.GetUniId();
            model.FControlUnitID = "1";
            model.CREATE_ID = model.UserID;
            model.UPDATE_ID = model.UserID;
            da.Add(model);
            return model.FID;
        }


        public string Add(string TestCaseID, string UserID, string Line)
        {
            TestStep model = new TestStep();
            model.TestCaseFID = TestCaseID;
            model.UserID = UserID;
            model.Line = Line;
            return Add(model);
        }
    }
}

