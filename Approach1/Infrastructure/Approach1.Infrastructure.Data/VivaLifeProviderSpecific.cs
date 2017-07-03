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
    
    public partial class VivaLifeProviderSpecific
    {
        public int VivaLifeProviderSpecificId { get; set; }
        public int OrderItemId { get; set; }
        public decimal Monthly { get; set; }
        public int MaritalStatusId { get; set; }
        public string Email { get; set; }
        public int CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public string ChildName { get; set; }
        public Nullable<System.DateTime> ChildDOB { get; set; }
        public Nullable<int> Grade { get; set; }
    
        public virtual CustomerMaritalStatu CustomerMaritalStatu { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
