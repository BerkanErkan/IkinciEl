namespace IkinciEl.CFDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExpertizMerkez")]
    public partial class ExpertizMerkez
    {
        public int ExpertizMerkezID { get; set; }

        public string ExpertizMerkezAdi { get; set; }

        public string ExpertizMerkezAdresi { get; set; }

        public string ExpertizMerkezTelefonu { get; set; }

        public string ExpertizMerkezMaili { get; set; }
    }
}
