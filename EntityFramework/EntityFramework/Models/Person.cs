using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Person
    {
        // Id, ID, PersonId, PersonID <-- primary keys
        // And if the data type is `int` or `guid`
        // then EF will make the primary key an identity column.
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Weight { get; set; }
        public bool IsStarWarsFan { get; set; }

        // This property doesn't have a setter
        // so EF will ignore it when generating the database.
        public string Info
        {
            get
            {
                return $"{Name} ({BirthDate})";
            }
        }
    }
}
