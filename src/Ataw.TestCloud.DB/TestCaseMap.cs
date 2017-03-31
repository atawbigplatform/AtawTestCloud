
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Ataw.TestCloud.Table;

namespace Ataw.TestCloud.DB
{
    // bd_User
    public class TestCaseMap : EntityTypeConfiguration<TestCase>
    {
        public TestCaseMap(string schema = "dbo")
        {
            ToTable(schema + ".TestCase");
            HasKey(x => x.FID);
            
             Property(x => x.FID).HasColumnName("FID").IsRequired().HasMaxLength(50);

             Property(x => x.UserID).HasColumnName("UserID").IsOptional();

             Property(x => x.PageName).HasColumnName("PageName").IsOptional();

             Property(x => x.IsPass).HasColumnName("IsPass").IsOptional();

             Property(x => x.TestTime).HasColumnName("TestTime").IsOptional();

             Property(x => x.CREATE_ID).HasColumnName("CREATE_ID").IsOptional();

             Property(x => x.CREATE_TIME).HasColumnName("CREATE_TIME").IsOptional();

             Property(x => x.UPDATE_ID).HasColumnName("UPDATE_ID").IsOptional();

             Property(x => x.UPDATE_TIME).HasColumnName("UPDATE_TIME").IsOptional();

             Property(x => x.ISDELETE).HasColumnName("ISDELETE").IsOptional();

             Property(x => x.FControlUnitID).HasColumnName("FControlUnitID").IsOptional();

             Property(x => x.TIMESSTAMP).HasColumnName("TIMESSTAMP").IsOptional();

             Property(x => x.UDDATETIME).HasColumnName("UDDATETIME").IsOptional();

             Property(x => x.UDINT1).HasColumnName("UDINT1").IsOptional();

             Property(x => x.UDVARCHAR1).HasColumnName("UDVARCHAR1").IsOptional();

             Property(x => x.UDVARCHAR2).HasColumnName("UDVARCHAR2").IsOptional();
            //Title
            Property(x => x.Title).HasColumnName("Title").IsOptional();
        }
    }

}

