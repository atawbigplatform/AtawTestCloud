
using Ataw.Framework.Core;
using Ataw.TestCloud.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.DA
{
    public class DATestStep : TestCloudRepository<TestStep>
    {
        public DATestStep(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}


