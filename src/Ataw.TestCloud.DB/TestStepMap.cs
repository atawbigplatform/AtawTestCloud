
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Ataw.TestCloud.Table;

namespace Ataw.TestCloud.DB
{
    // bd_User
    public class TestStepMap : EntityTypeConfiguration<TestStep>
    {
        public TestStepMap(string schema = "dbo")
        {
            ToTable(schema + ".TestStep");
            HasKey(x => x.FID);
            
             Property(x => x.FID).HasColumnName("FID").IsRequired().HasMaxLength(50);

             Property(x => x.UserID).HasColumnName("UserID").IsOptional();

             Property(x => x.TestCaseFID).HasColumnName("TestCaseFID").IsOptional();

             Property(x => x.CmdName).HasColumnName("CmdName").IsOptional();

             Property(x => x.Line).HasColumnName("Line").IsOptional();

             Property(x => x.KeyStr).HasColumnName("KeyStr").IsOptional();

             Property(x => x.IsPass).HasColumnName("IsPass").IsOptional();

             Property(x => x.IsSend).HasColumnName("IsSend").IsOptional();

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


        }
    }

}

