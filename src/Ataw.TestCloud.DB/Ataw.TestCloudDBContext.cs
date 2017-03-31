
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Ataw.Framework.Core;
using Ataw.TestCloud.Table;

namespace Ataw.TestCloud.DB
{
    public class TestCloudDBContext : AtawDbContext
    {


        static TestCloudDBContext()
        {
            Database.SetInitializer<TestCloudDBContext>(null);
        }


        /// <summary>
        /// TestCase
        /// </summary>
        public IDbSet<TestCase> TestCase { get; set; }

        /// <summary>
        /// TestStep
        /// </summary>
        public IDbSet<TestStep> TestStep { get; set; }



        public TestCloudDBContext()
            : base(AtawAppContext.Current.DefaultConnString)
        {
        }

        public TestCloudDBContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Configurations.Add(new TestCaseMap());

            modelBuilder.Configurations.Add(new TestStepMap());

        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {

            modelBuilder.Configurations.Add(new TestCaseMap(schema));

            modelBuilder.Configurations.Add(new TestStepMap(schema));

            return modelBuilder;
        }
    }
}

