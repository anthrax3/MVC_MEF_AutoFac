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
    
    public partial class QARatioLevelMapping
    {
        public int MappingId { get; set; }
        public int CampaignId { get; set; }
        public int Ratio { get; set; }
        public int LevelId { get; set; }
    
        public virtual Campaign Campaign { get; set; }
        public virtual QALevel QALevel { get; set; }
    }
}