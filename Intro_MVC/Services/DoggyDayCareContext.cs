using Intro_MVC.DALModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC.Services
{
    // your DB Context, rerpresents your entire "interaction" with your Database
    public class DoggyDayCareContext : IdentityDbContext
    {
        public DoggyDayCareContext(DbContextOptions options) : base(options)
        {

        }

        // DBSets represents your table in your DB
        public DbSet<DogDAL> Dogs { get; set; }
    }
}
