using IkinciEl.CF.Models.Context;
using IkinciEl.CFDB;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class TramerDAL
    {
        Model1 db = new Model1();

        public List<TramerBilgisiDurumVM> TramerBilgisiDurumDoldur()
        {

            var result = (from c in db.TramerBilgisiDurum
                          select new TramerBilgisiDurumVM
                          {
                               TramerBilgisiDurumID = c.TramerBilgisiDurumID,
                               TramerBilgisiDurumAdi = c.TramerBilgisiDurumAdi
                               
                          }).ToList();




            return result;


        }
    }
}