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
    
    public partial class Czesci_Obsluga
    {
        public int ID_Obslugi { get; set; }
        public int ID_Element { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Elementy Elementy { get; set; }
        public virtual Obsluga_Techniczna Obsluga_Techniczna { get; set; }
    }
}