using IkinciEl.CF.Models.Context;
using IkinciEl.CF.Models.Entities;
using IkinciEl.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkinciEl.UI.Models.DAL
{
    public class GirisDAL
    {
        ProjectContext db = new ProjectContext();

        public KullaniciVM KullaniciKontrolu(KullaniciVM vM)
        {

            var kullanici = db.Kullanicis
                .Join(db.Rols, k => k.RolID, r => r.RolID, (k, r) => new { Kullanici = k, Rol = r })
                .SingleOrDefault(kr => kr.Kullanici.Mail == vM.Mail && kr.Kullanici.Sifre == vM.Sifre);

            if (kullanici != null)
            {
                if (/*kullanici.Rol.RolID==3*/ true)
                {
                    return new KullaniciVM
                    {
                         
                        Mail = kullanici.Kullanici.Mail,
                        AdveSoyad = kullanici.Kullanici.AdVeSoyad,
                         YetkiAdi = kullanici.Rol.RolAdi,
                          KullaniciID=kullanici.Kullanici.KullaniciID
                           
                    };
                }
                else
                {
                    return null;
                }
                
            }
            else
            {

                return null;
            }


        }
        public string KullaniciRol(string ad)
        {

            var kullanici = db.Kullanicis
                .Join(db.Rols, k => k.RolID, r => r.RolID, (k, r) => new { Kullanici = k, Rol = r })
                .SingleOrDefault(kr => kr.Kullanici.Mail == ad);

            return kullanici.Rol.RolAdi;

        }
    }
}