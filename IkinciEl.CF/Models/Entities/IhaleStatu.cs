using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class IhaleStatu
    {
        [Key]
        public int IhaleStatuID { get; set; }
        public string IhaleStatuAdi { get; set; }

        public List<Ihale> Ihale { get; set; }
    }
}