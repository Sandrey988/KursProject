//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medications()
        {
            this.Analogs = new HashSet<Analogs>();
            this.Drugs = new HashSet<Drugs>();
        }
    
        public string Name { get; set; }
        public string PharmachologicEffect { get; set; }
        public string IndicationsForUse { get; set; }
        public string ModeOfApplication { get; set; }
        public string SideEffects { get; set; }
        public string Contraindications { get; set; }
        public string Pregnancy { get; set; }
        public string DrugInteractions { get; set; }
        public string Overdose { get; set; }
        public string Composition { get; set; }
        public string PharmacologicalGroup { get; set; }
        public string ActiveSubstance { get; set; }
        public string LeaveConditions { get; set; }
        public string IssueForm { get; set; }
        public string StorageConditions { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analogs> Analogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drugs> Drugs { get; set; }
        public virtual PharmacologicalGroup PharmacologicalGroup1 { get; set; }
    }
}
