
//�������Ataw.DEv�Զ����ɵĴ��룬���н��������ƽ̨��������ϵ
using System;
using System.Collections.Generic;
using Ataw.Framework.Core;
//using System.ComponentModel.DataAnnotations.Schema;
namespace Ataw.TestCloud.Table
{
    /// <summary>
    /// TestStep
    /// </summary>
    public class TestStep : AtawBaseModel
    {

     
        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; } 
     
        /// <summary>
        /// TestCaseFID
        /// </summary>
        public string TestCaseFID { get; set; } 
     
        /// <summary>
        /// CmdName
        /// </summary>
        public string CmdName { get; set; } 
     
        /// <summary>
        /// Line
        /// </summary>
        public string Line { get; set; } 
     
        /// <summary>
        /// KeyStr
        /// </summary>
        public string KeyStr { get; set; } 
     
        /// <summary>
        /// IsPass
        /// </summary>
        public string IsPass { get; set; } 
     
        /// <summary>
        /// IsSend
        /// </summary>
        public string IsSend { get; set; } 
     

    }

}
