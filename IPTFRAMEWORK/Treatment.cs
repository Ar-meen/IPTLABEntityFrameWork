//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPTFRAMEWORK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Treatment
    {
        public string Diagnose { get; set; }
        public int HospitalId { get; set; }
        public string MedicineName { get; set; }
        public int PatientId { get; set; }
    
        public virtual Hospital Hospital { get; set; }
        public virtual Medicine Medicine { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
