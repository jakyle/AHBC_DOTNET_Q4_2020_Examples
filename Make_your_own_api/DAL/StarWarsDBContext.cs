using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Make_your_own_api.DAL
{
    public class StarWarsDBContext : DbContext
    {
        public StarWarsDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<StarWarsFanDAL> Fans { get; set; } 
    }

    public class StarWarsFanDAL
    {
        // this will be a foriegn key to the star wars api

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string StarWarsCharacterId { get; set; }
        public string PeronalNotes { get; set; }
        public bool IsAFan { get; set; }
    }
}
