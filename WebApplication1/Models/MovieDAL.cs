using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MovieDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // (1, 1)
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }

        public string UniqueId { get; set; }
    }
}
