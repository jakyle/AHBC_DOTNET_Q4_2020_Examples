using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.DALModels
{
    public class DogDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public int DogID { get; set; }
        public string Name { get; set; }
        public string DayOfTheWeek { get; set; }
        // valuetype? <--- the "?" makes your value type nullable, example = 
        // int? num = null;
        // int? numTwo = 3;
        public int? Age { get; set; }

        [ForeignKey("User")]
        public string Id { get; set; }
        public IdentityUser User { get; set; }

        [ForeignKey("Owner")]
        public int OwnerID { get; set; }

        public DogOwnerDAL Owner { get; set; }
    }


    public class DogOwnerDAL
    {
        [Key]
        public int OwnerID { get; set; }
        public string Name { get; set; }

        public IEnumerable<DogDAL> Dogs { get; set; }
    }
}
