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
    
    public partial class Drugs
    {
        public int DrugID { get; set; }
        public string Name { get; set; }
        public System.DateTime ManufactureDate { get; set; }
        public System.DateTime DisposeDate { get; set; }
        public double Cost { get; set; }
        public int ProducerId { get; set; }
        public int Count { get; set; }
    
        public virtual Discount Discount { get; set; }
        public virtual Medications Medications { get; set; }
        public virtual Producers Producers { get; set; }
    }
}
