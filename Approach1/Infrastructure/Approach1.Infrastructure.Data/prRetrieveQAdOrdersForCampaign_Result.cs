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
    
    public partial class prRetrieveQAdOrdersForCampaign_Result
    {
        public int OrderID { get; set; }
        public string BasketReference { get; set; }
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerIDNumber { get; set; }
        public string CustomerAddressCompany { get; set; }
        public string CustomerAddressBuilding { get; set; }
        public string CustomerAddressStreetNum { get; set; }
        public string CustomerAddressStreetName { get; set; }
        public string CustomerAddressSuburb { get; set; }
        public string CustomerAddressPostCode { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int UserID { get; set; }
        public string UserUserName { get; set; }
        public int OrderID1 { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int UserId1 { get; set; }
        public int BrandId { get; set; }
        public int CampaignId { get; set; }
        public int DialerAgentId { get; set; }
        public Nullable<int> Period { get; set; }
        public string Comments { get; set; }
        public string CallFlag { get; set; }
        public string BasketReference1 { get; set; }
        public int EscalationIndex { get; set; }
        public Nullable<int> DebitOrderDay { get; set; }
        public int CustomerId1 { get; set; }
        public Nullable<int> LeadId { get; set; }
        public Nullable<int> VerifierId { get; set; }
        public int EmailCommSentStatusId { get; set; }
        public int SMSCommSentStatusId { get; set; }
        public Nullable<bool> BillingIsPaid { get; set; }
        public Nullable<System.DateTime> BillingDate { get; set; }
        public Nullable<int> OverrideVettingUserId { get; set; }
        public Nullable<int> VettingHistoryId { get; set; }
        public Nullable<int> MSOrdermasterId { get; set; }
        public Nullable<int> EMOrdermasterId { get; set; }
        public Nullable<decimal> Affordability { get; set; }
    }
}