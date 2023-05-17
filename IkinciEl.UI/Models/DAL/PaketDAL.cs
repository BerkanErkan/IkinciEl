using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class PaketDAL
    {
        Model1 db = new Model1();

        public List<PaketVM> PaketDoldur()
        {

            var result = (from c in db.Paket
                          select new PaketVM
                          {
                               PaketID  = c.PaketID,
                               PaketAdi = c.PaketAdi
                          }).ToList();




            return result;


        }
    }
}