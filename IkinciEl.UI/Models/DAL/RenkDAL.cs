using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class RenkDAL
    {
        Model1 db = new Model1();

        public List<RenkVM> RenkDoldur()
        {

            var result = (from c in db.Renk
                          select new RenkVM
                          {
                               RenkID = c.RenkID,
                               RenkAdi = c.RenkAdi
                          }).ToList();




            return result;


        }
    }
}