
//�������Ataw.DEv�Զ����ɵĴ��룬���н��������ƽ̨��������ϵ
using System;
using System.Collections.Generic;
using Ataw.Framework.Core;
//using System.ComponentModel.DataAnnotations.Schema;
namespace Ataw.TestCloud.Table

{
    /// <summary>
    /// TestCase
    /// </summary>
    public class TestCase : AtawBaseModel
    {


        /// <summary>
        /// UserID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// PageName
        /// </summary>
        public string PageName { get; set; }

        /// <summary>
        /// IsPass
        /// </summary>
        public bool? IsPass { get; set; }

        /// <summary>
        /// TestTime
        /// </summary>
        public DateTime? TestTime { get; set; }


        public string Title { get; set; }


    }

}
