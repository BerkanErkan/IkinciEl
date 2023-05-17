using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class ExpertizMerkez
    {
        [Key]
        public int ExpertizMerkezID { get; set; }
        public string ExpertizMerkezAdi { get; set; }
        public string ExpertizMerkezAdresi { get; set; }
        public string ExpertizMerkezTelefonu { get; set; }
        public string ExpertizMerkezMaili { get; set; }
    }
}