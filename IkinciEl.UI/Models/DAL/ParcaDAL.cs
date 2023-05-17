using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class ParcaDAL
    {
        Model1 db = new Model1();

        public List<ParcaVM> ParcaDoldur()
        {

            var result = (from c in db.Parca
                          select new ParcaVM
                          {
                               ParcaID = c.ParcaID,
                               ParcaAdi = c.ParcaAdi
                          }).ToList();




            return result;


        }
    }
}