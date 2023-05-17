using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class StatuTipi
    {
        [Key]
        public int StatuTipiID { get; set; }
        public string StatuTipiAdi { get; set; }

        public List<Statu> Statu { get; set; }
    }
}