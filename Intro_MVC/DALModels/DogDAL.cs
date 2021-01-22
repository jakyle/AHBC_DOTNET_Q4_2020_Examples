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
    }
}
