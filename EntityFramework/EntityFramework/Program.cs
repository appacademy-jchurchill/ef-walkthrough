using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static bool Test(Person person)
        {
            return person.IsStarWarsFan;
        }

        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());

            using (var context = new Context())
            {
                //context.People.Add(new Person()
                //{
                //    Name = "James Churchill",
                //    BirthDate = new DateTime(1968, 4, 22),
                //    Weight = 215,
                //    IsStarWarsFan = true
                //});
                //context.People.Add(new Person()
                //{
                //    Name = "Jenny Churchill",
                //    BirthDate = new DateTime(1966, 5, 9),
                //    Weight = 145,
                //    IsStarWarsFan = false
                //});
                //context.SaveChanges();

                // select * from People
                //var people = context.People.ToList();

                context.Database.Log = (message) => Console.WriteLine(message);


                //var people = context.People.ToList();

                ////Func<Person, bool> test = p => p.IsStarWarsFan;

                //Func<Person, bool> test = (p) =>
                //{
                //    return p.IsStarWarsFan;
                //};

                //var filteredPeople = new List<Person>();

                //foreach (var person in people)
                //{
                //    if (Test(person))
                //    {
                //        filteredPeople.Add(person);
                //    }
                //}

                //var people2 = context.People
                //    .Where(Test)
                //    .ToList();



                var people = context.People
                    .Where(p => p.IsStarWarsFan || p.Name.Contains("j"))
                    .OrderByDescending(p => p.Name)
                    .ThenBy(p => p.BirthDate)
                    .ThenByDescending(p => p.Weight)
                    .ToList();

                // Single, First, FirstOrDefault
                var james = context.People
                    .SingleOrDefault(p => p.Id == 1);


                foreach (var person in people)
                {
                    Console.WriteLine(person.Name);
                }
            }

            Console.ReadKey();
        }
    }
}
