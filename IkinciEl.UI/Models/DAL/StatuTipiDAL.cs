using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class StatuTipiDAL
    {
        Model1 db = new Model1();

        public List<StatuTipiVM> StatuTipiDoldur()
        {

            var result = (from c in db.StatuTipi
                          select new StatuTipiVM
                          {
                               StatuTipiID = c.StatuTipiID,
                               StatuTipiAdi = c.StatuTipiAdi
                          }).ToList();




            return result;


        }
    }
}