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
    
    public partial class OrderBillLimit
    {
        public int OrderBillLimitId { get; set; }
        public int OrderId { get; set; }
        public decimal OriginalValue { get; set; }
        public Nullable<decimal> NewValue { get; set; }
        public int CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
    
        public virtual Order Order { get; set; }
    }
}