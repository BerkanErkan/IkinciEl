//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IkinciEl.DF
{
    using System;
    using System.Collections.Generic;
    
    public partial class AldigimArac
    {
        public int AldigimAracId { get; set; }
        public System.DateTime AldigimTarih { get; set; }
        public int KullaniciID { get; set; }
        public int AracID { get; set; }
    
        public virtual Arac Arac { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
