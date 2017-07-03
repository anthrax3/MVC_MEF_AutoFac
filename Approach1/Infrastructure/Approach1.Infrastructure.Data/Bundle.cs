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
    
    public partial class Bundle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bundle()
        {
            this.OrderBundles = new HashSet<OrderBundle>();
            this.BundleCampaignMappings = new HashSet<BundleCampaignMapping>();
            this.BundleDealMappings = new HashSet<BundleDealMapping>();
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int BundleID { get; set; }
        public string BundleName { get; set; }
        public decimal DealsTotal { get; set; }
        public decimal BundleDiscount { get; set; }
        public decimal BundleAmount { get; set; }
        public bool BundleActive { get; set; }
        public Nullable<int> InsertedUserId { get; set; }
        public Nullable<int> ModifiedUserId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.DateTime DbInsertDate { get; set; }
        public Nullable<int> ExportToBilling { get; set; }
        public Nullable<int> TopBillingLookupId { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderBundle> OrderBundles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BundleCampaignMapping> BundleCampaignMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BundleDealMapping> BundleDealMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
