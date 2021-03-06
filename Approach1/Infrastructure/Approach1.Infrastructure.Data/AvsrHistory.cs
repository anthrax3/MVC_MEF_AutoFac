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
    
    public partial class AvsrHistory
    {
        public int AvsrHistoryId { get; set; }
        public string IdNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public int AvsrBankId { get; set; }
        public string BranchCode { get; set; }
        public Nullable<int> Attempt { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CampaignId { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<int> ResponseCode { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public string ResponseDescription { get; set; }
    
        public virtual Campaign Campaign { get; set; }
        public virtual User User { get; set; }
    }
}
