//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplyingApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class FullSpecialityInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FullSpecialityInfo()
        {
            this.ApplyInfoes = new HashSet<ApplyInfo>();
        }
    
        public string FullspecialityId { get; set; }
        public string PlaceId { get; set; }
        public string FinancingId { get; set; }
        public string FormOfEducationId { get; set; }
        public string SpecialityId { get; set; }
        public string TermId { get; set; }
        public string PrivilegesId { get; set; }
        public int Capacity { get; set; }
        public string DateInfoId { get; set; }
        public string Color { get; set; }
        public string FirstSubject { get; set; }
        public string SecondSubject { get; set; }
        public int MinScoreFirst { get; set; }
        public int MinScoreSecond { get; set; }
        public int MinScoreThird { get; set; }
    
        public virtual Date Date { get; set; }
        public virtual Financing Financing { get; set; }
        public virtual FormOfEducation FormOfEducation { get; set; }
        public virtual Place Place { get; set; }
        public virtual Privilege Privilege { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual Term Term { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplyInfo> ApplyInfoes { get; set; }
    }
}
