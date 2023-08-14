﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class EntityTypeAttr
    {
        public EntityTypeAttr()
        {
            EntityTypeAttrLov = new HashSet<EntityTypeAttrLov>();
        }

        public int EntityTypeId { get; set; }
        public string AttrName { get; set; }
        public string AttrDataType { get; set; }
        public int ColumnSequence { get; set; }
        public int? IsMandatoryFlag { get; set; }
        public string Derivation { get; set; }
        public int AttrLength { get; set; }
        public int? AttrPrecision { get; set; }
        public decimal? IsPartOfCode { get; set; }
        public int? IsDerived { get; set; }
        public int EditLevel { get; set; }
        public int? ParentEntityTypeId { get; set; }
        public string ListBoxQuery { get; set; }
        public string AttrDisplayName { get; set; }
        public string AttrDisplayOrder { get; set; }
        public string DisplayType { get; set; }
        public int? IsSearchable { get; set; }
        public int? IsListable { get; set; }
        public string HistoryQuery { get; set; }
        public int? IsHyperlinked { get; set; }
        public string Isvisible { get; set; }
        public string CasQuery { get; set; }
        public string CasDrop { get; set; }

        public virtual ICollection<EntityTypeAttrLov> EntityTypeAttrLov { get; set; }
    }
}