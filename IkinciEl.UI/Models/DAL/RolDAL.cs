using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class RolDAL
    {
        Model1 db = new Model1();

        public List<RolVM> RolDoldur()
        {

            var result = (from c in db.Rol
                          select new RolVM
                          {
                               RolID = c.RolID,
                               RolAdi = c.RolAdi
                          }).ToList();




            return result;


        }
    }
}