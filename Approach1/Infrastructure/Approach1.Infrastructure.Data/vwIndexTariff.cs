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
    
    public partial class vwIndexTariff
    {
        public int ProviderID { get; set; }
        public string ProviderDisplayName { get; set; }
        public int TariffID { get; set; }
        public string TariffName { get; set; }
        public string TariffDescription { get; set; }
        public decimal TariffPrice { get; set; }
        public Nullable<decimal> TariffPayIn { get; set; }
        public Nullable<int> TariffActive { get; set; }
        public Nullable<int> TariffMonthsFree { get; set; }
        public Nullable<int> TariffDuration { get; set; }
    }
}
