using IkinciEl.CF.Models.Context;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class ModelDAL
    {
        ProjectContext db = new ProjectContext();

        public List<ModelVM> ModelDoldur()
        {

            var result = (from c in db.AracModels
                          select new ModelVM
                          {
                               AracModelID = c.AracModelID,
                               AracModelAdi = c.AracModelAdi
                          }).ToList();




            return result;


        }
    }
}