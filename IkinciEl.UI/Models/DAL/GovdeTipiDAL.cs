using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class GovdeTipiDAL
    {
        Model1 db = new Model1();

        public List<GovdeTipiVM> GovdeTipiDoldur()
        {

            var result = (from c in db.GovdeTipi
                          select new GovdeTipiVM
                          {
                               GovdeTipiID = c.GovdeTipiID,
                               GovdeTipiAdi = c.GovdeTipiAdi
                          }).ToList();




            return result;


        }
    }
}