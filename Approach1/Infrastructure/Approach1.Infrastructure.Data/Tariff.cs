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
    
    public partial class Tariff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tariff()
        {
            this.Deals = new HashSet<Deal>();
        }
    
        public int TariffID { get; set; }
        public int ProvIderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Duration { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> PayIn { get; set; }
        public Nullable<int> MonthsFree { get; set; }
        public Nullable<int> Active { get; set; }
        public byte[] Picture { get; set; }
        public string TopBillingProductName { get; set; }
        public Nullable<int> TopBillingLookupId { get; set; }
        public Nullable<decimal> Limit { get; set; }
        public string RatePlan { get; set; }
        public string ExternalReference { get; set; }
    
        public virtual TopBillingLookup TopBillingLookup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deal> Deals { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
