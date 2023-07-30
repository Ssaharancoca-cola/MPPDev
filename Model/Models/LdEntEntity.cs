﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class LdEntEntity
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string EntEntityCode { get; set; }
        public string EntEntityLongName { get; set; }
        public string EntEntityShortName { get; set; }
        public string ActiveFlag { get; set; }
        public string DummyFlag { get; set; }
        public string SourceSystemCode { get; set; }
        public decimal? SortOrder { get; set; }
        public string ErrorMessage { get; set; }
        public string WarningMessage { get; set; }
        public string SessionId { get; set; }
        public int InputRowId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? RowSecFlag { get; set; }
        public string ApproverId { get; set; }
        public string UserId { get; set; }
        public string Comments { get; set; }
        public string UserLevel { get; set; }
        public string ApproverLevel { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? LdOid { get; set; }
        public int? RowStatus { get; set; }
        public int? RecLockFlag { get; set; }
        public int? TreatNullsAsNulls { get; set; }
        public int? CurrentEditLevel { get; set; }
        public string EntGroupCode { get; set; }
        public string EntEntityDesc { get; set; }
    }
}