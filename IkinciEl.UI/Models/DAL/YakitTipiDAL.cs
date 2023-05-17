using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class YakitTipiDAL
    {
        Model1 db = new Model1();

        public List<YakitTipiVM> YakitTipiDoldur()
        {

            var result = (from c in db.YakitTipi
                          select new YakitTipiVM
                          {
                               YakitTipiID = c.YakitTipiID,
                               YakitTipiAdi = c.YakitTipiAdi
                          }).ToList();




            return result;


        }
    }
}