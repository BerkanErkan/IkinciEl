﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkinciEl.CF.Models.Entities
{
    public class AldigimArac
    {
        [Key]
        public int AldigimAracId { get; set; }
        public DateTime AldigimTarih { get; set; }
        public int KullaniciID { get; set; }
        public int AracID { get; set; }

        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(AracID))]
        public Arac Arac { get; set; }
    }
}