using IkinciEl.CF.Models.Context;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class MarkaDAL
    {

        ProjectContext db = new ProjectContext();

        public List<MarkaVM> MarkaDoldur()
        {

            var result = (from c in db.AracMarkas
                          select new MarkaVM
                          {
                               AracMarkaID = c.AracMarkaID,
                                AracMarkaAdi = c.AracMarkaAdi
                          }).ToList();




            return result;


        }



    }
}