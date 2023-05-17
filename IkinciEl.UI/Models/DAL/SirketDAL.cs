using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class SirketDAL
    {

        Model1 db = new Model1();

        public List<SirketVM> SirketDoldur()
        {

            var result = (from c in db.SirketBilgisi
                          select new SirketVM
                          {
                               SirketID = c.SirketBİlgisiID,
                               SirketAdi = c.FirmaAdi
                          }).ToList();




            return result;


        }


    }
}