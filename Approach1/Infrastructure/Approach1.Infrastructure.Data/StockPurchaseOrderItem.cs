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
    
    public partial class StockPurchaseOrderItem
    {
        public int StockPurchaseOrderItemsId { get; set; }
        public int StockPurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    
        public virtual StockPurchaseOrder StockPurchaseOrder { get; set; }
    }
}
