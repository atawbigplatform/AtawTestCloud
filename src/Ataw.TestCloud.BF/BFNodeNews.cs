using Ataw.Framework.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataw.TestCloud.BF
{
    public class BFNodeNews
    {
        public void SendCommandFunBySql(string userId, string line, string key = "", string CmdName = "")
        {
            using (AtawDbContext db = new AtawDbContext(AtawAppContext.Current.DefaultConnString))
            {
                string sql = "insert into NodeNews (FID,CmdName,IsSend,KeyStr,Line,UserID,InsertTime) values (@FID ,@CmdName,@IsSend,@KeyStr,@Line,@UserID,@InsertTime)";

                SqlParameter[] sqlParas = {
                new SqlParameter("@FID",db.GetUniId()),
                new SqlParameter ("@CmdName",CmdName),
                //1为未发送  2为已发送
                new SqlParameter ("@IsSend","1"),
                new SqlParameter ("@KeyStr",key),
                new SqlParameter ("@Line",line),
                new SqlParameter ("@UserID",userId),
                new SqlParameter ("@InsertTime",DateTime.Now.ToString("yyyy/MM/dd hh:mm:ssss")),
                };


                db.ExecuteSqlCommand(sql, sqlParas);

                db.Submit();
            }
        }

    }
}
