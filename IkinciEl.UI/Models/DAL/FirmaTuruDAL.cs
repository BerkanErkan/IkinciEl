using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class FirmaTuruDAL
    {
        Model1 db = new Model1();

        public List<FirmaTuruVM> FirmaTuruDoldur()
        {

            var result = (from c in db.FirmaTuru
                          select new FirmaTuruVM
                          {
                               FirmaTuruID = c.FirmaTuruID,
                               FirmaTuruAdi = c.FiirmaTuruAdi
                          }).ToList();




            return result;


        }
    }
}