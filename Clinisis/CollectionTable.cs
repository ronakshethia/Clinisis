//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinisis
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollectionTable
    {
        public long CollectionID { get; set; }
        public long id { get; set; }
        public int Fee { get; set; }
        public int Outstanding { get; set; }
        public string Treatment { get; set; }
        public string Rx { get; set; }
        public string Date { get; set; }
    
        public virtual PatientEntryTable PatientEntryTable { get; set; }
    }
}
