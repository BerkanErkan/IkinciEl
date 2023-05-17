using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class VitesTipiDAL
    {
        Model1 db = new Model1();

        public List<VitesTipiVM> VitesTipiDoldur()
        {

            var result = (from c in db.VitesTipi
                          select new VitesTipiVM
                          {
                                VitesTipiID = c.VitesTipiiID,
                               VitesTipiAdi = c.VitesTipiAdi
                          }).ToList();




            return result;


        }
    }
}