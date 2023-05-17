using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }
        public string RolAdi { get; set; }

        public List<Kullanici> Kullanici { get; set; }
    }
}