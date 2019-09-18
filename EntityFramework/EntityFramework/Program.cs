using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.People.Add(new Person()
                {
                    Name = "James Churchill",
                    BirthDate = new DateTime(1968, 4, 22),
                    Weight = 215
                });
                context.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
