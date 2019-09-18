using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFramework.Data;
using EntityFramework.Models;

namespace EntityFramework
{
    internal class DatabaseInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.People.Add(new Person()
            {
                Name = "Sam Smith",
                BirthDate = new DateTime(2000, 1, 1),
                Weight = 100
            });
            context.People.Add(new Person()
            {
                Name = "James Churchill",
                BirthDate = new DateTime(1968, 1, 1),
                Weight = 200
            });
            context.People.Add(new Person()
            {
                Name = "Bob Jones",
                BirthDate = new DateTime(1999, 1, 1),
                Weight = 120
            });

            context.SaveChanges();
        }
    }
}
