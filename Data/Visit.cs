//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int PhysicianId { get; set; }
        public int HosptialId { get; set; }
        public int HosptialEHRSystemId { get; set; }
        public System.DateTime DateTime { get; set; }
        public string PointerToSpecificEHRecord { get; set; }
    
        public virtual HospitalEHRSystem HospitalEHRSystem { get; set; }
        public virtual Hosptial Hosptial { get; set; }
        public virtual Person Person { get; set; }
        public virtual Physician Physician { get; set; }
    }
}
