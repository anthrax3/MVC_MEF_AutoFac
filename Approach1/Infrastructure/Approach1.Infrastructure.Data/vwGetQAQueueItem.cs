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
    
    public partial class vwGetQAQueueItem
    {
        public int QAQueueID { get; set; }
        public int OrderID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateStarted { get; set; }
        public Nullable<System.DateTime> DateFinished { get; set; }
        public string AssignedTo { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int QAQuestionTypeID { get; set; }
        public string QAQuestionType { get; set; }
    }
}
