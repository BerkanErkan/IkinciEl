using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class DonanimDAL
    {
        Model1 db = new Model1();

        public List<DonanimVM> DonanimDoldur()
        {

            var result = (from c in db.Donanim
                          select new DonanimVM
                          {
                               DonanimID = c.DonanimID,
                               DonanimAdi = c.DonanimAdi
                          }).ToList();




            return result;


        }
    }
}