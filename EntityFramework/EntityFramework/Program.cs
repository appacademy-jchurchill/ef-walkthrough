using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        //static bool Test(Person person)
        //{
        //    return person.IsStarWarsFan;
        //}

        static void Main(string[] args)
        {
            Database.SetInitializer(new DatabaseInitializer());

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());

            using (var context = new Context())
            {
                context.Database.Log = (message) => Console.WriteLine(message);

                // Adding new records...

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

                // Queries...

                // select * from People
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

                //var people = context.People
                //    .Where(p => p.IsStarWarsFan || p.Name.Contains("j"))
                //    .OrderByDescending(p => p.Name)
                //    .ThenBy(p => p.BirthDate)
                //    .ThenByDescending(p => p.Weight)
                //    .ToList();

                //// Single, First, FirstOrDefault
                //var james = context.People
                //    .SingleOrDefault(p => p.Id == 1);

                // http://localhost:55443/Person/Add

                // CRUD Operations

                // Add...

                //context.People.Add(new Person()
                //{
                //    Name = "Sam Smith",
                //    BirthDate = new DateTime(2000, 1, 1),
                //    Weight = 100
                //});
                //context.SaveChanges();

                // Update...

                //var sam = context.People.Find(2);
                //var samEntry = context.Entry(sam);
                //sam.Weight = 150;
                //context.ChangeTracker.DetectChanges();
                //context.SaveChanges();

                // http://localhost:55443/People/Edit/1

                // MVC controller POST action method
                //var person = new Person()
                //{
                //    Id = 1,
                //    Name = "Sam Smith",
                //    BirthDate = new DateTime(2019, 1, 1),
                //    Weight = 140,
                //    IsStarWarsFan = true
                //};

                //context.People.Attach(person);
                //var entry = context.Entry(person);
                //entry.State = EntityState.Modified;
                //entry.Property(p => p.IsStarWarsFan).IsModified = true;
                //context.SaveChanges();

                // Delete...

                //var sam = context.People.Find(1);
                //context.People.Remove(sam);
                //context.SaveChanges();

                //var sam = new Person() { Id = 1 };
                //context.Entry(sam).State = EntityState.Deleted;
                //context.SaveChanges();

                var people = context.People.ToList();

                foreach (var p in people)
                {
                    Console.WriteLine(p);
                }
            }

            Console.ReadKey();
        }
    }
}
