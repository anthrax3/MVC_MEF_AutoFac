//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Approach1.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwGetStockStatusHistory
    {
        public int StockStatusHistoryID { get; set; }
        public int UserID { get; set; }
        public string Status { get; set; }
        public System.DateTime StatusChangeDate { get; set; }
        public string IMEI { get; set; }
    }
}