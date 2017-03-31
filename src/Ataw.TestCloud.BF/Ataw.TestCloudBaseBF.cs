
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ataw.Framework.Core;
using Ataw.TestCloud.DB;

namespace Ataw.TestCloud.BF
{
    public class TestCloudBaseBF : IDisposable
    {
        private IUnitOfData fUnitOfData;


        public TestCloudBaseBF SetUnitOfData(string conn)
        {
            fUnitOfData = new TestCloudDBContext(conn);
            return this;
        }

        public TestCloudBaseBF SetUnitOfData(IUnitOfData unitOfData)
        {
            if (unitOfData != null)
            {
                fUnitOfData = unitOfData;
            }
            return this;
        }

        public IUnitOfData UnitOfData
        {
            get
            {
                if (fUnitOfData == null)
                {
                    fUnitOfData = new TestCloudDBContext();
                    // fUnitOfData.db
                }
                return fUnitOfData;
            }
        }

        public int Submit()
        {
            return UnitOfData.Submit();
        }

        public void Dispose()
        {
            if (fUnitOfData != null)
            {
                fUnitOfData.Dispose();
            }
            // throw new NotImplementedException();
        }

        public static TestCloudDBContext FetchDbContext()
        {
            return new TestCloudDBContext();
        }
    }
}

