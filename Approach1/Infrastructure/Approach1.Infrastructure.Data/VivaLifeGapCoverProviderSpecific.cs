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
    
    public partial class VivaLifeGapCoverProviderSpecific
    {
        public int VivaLifeGapCoverProviderSpecificId { get; set; }
        public int OrderItemId { get; set; }
        public int MedicalAidId { get; set; }
        public string MedicalAidNumber { get; set; }
        public bool HasLifeInsurance { get; set; }
        public bool HasDreadDiseaseCover { get; set; }
        public bool HasDisabilityCover { get; set; }
        public int CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        public virtual MedicalAid MedicalAid { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
