
using Ataw.Framework.Core;
using Ataw.Framework.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Ataw.TestCloud.DB;
namespace Ataw.TestCloud.DA
{
    public class TestCloudRepository<T> : Repository<T, TestCloudDBContext>, IRepository<T> where T : class
    {
        public TestCloudRepository(IUnitOfData dbContext)
            : base(dbContext as AtawDbContext)
        { 
        }       
    }
}


