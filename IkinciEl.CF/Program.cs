using IkinciEl.CF.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciEl.CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext db = new ProjectContext();
            //db.Database.Delete();
            db.Database.Create();

            
            //db.Database.Migrate();

        }
    }
}
