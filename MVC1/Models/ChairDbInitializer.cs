using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC1.Models
{
    public class ChairDbInitializer : DropCreateDatabaseAlways<ChairContext>
    {
        protected override void Seed(ChairContext db)
        {
            db.Chairs.Add(new Chair { Name = "Стул простой", Height = 65, Width = 40, Price = 1200 });
            db.Chairs.Add(new Chair { Name = "Стул не простой", Height = 110, Width = 50, Price = 2500 });
            base.Seed(db);
        }
    }
}