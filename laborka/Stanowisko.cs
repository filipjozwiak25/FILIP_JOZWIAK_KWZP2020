//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laborka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stanowisko
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stanowisko()
        {
            this.Pracownicy_Zatrudnienie = new HashSet<Pracownicy_Zatrudnienie>();
        }
    
        public int ID_Stanowiska { get; set; }
        public string Stanowisko1 { get; set; }
        public string Opis { get; set; }
        public Nullable<int> ID_Pensji { get; set; }
    
        public virtual Pensja Pensja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_Zatrudnienie> Pracownicy_Zatrudnienie { get; set; }
    }
}
