using IkinciEl.CF.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciEl.CF.Models.Entities
{
    public class IhaleFiyatKullanici
    {
        public int IhaleFiyatKullaniciID { get; set; }
        public int KullaniciID { get; set; }
        public int IhaleFiyatID { get; set; }

        [ForeignKey(nameof(KullaniciID))]
        public Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(IhaleFiyatID))]
        public IhaleFiyat IhaleFiyat { get; set; }
    }
}
