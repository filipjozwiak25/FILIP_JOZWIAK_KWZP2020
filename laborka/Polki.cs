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
    
    public partial class Polki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Polki()
        {
            this.Zawartosc = new HashSet<Zawartosc>();
        }
    
        public string ID_Polka { get; set; }
        public Nullable<int> ID_Rozmiar_Polki { get; set; }
    
        public virtual Polki_Rozmiary Polki_Rozmiary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zawartosc> Zawartosc { get; set; }
    }
}
