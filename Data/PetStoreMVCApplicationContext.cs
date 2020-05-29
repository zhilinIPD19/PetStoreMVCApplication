using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetStoreMVCApplication.Models;

namespace PetStoreMVCApplication.Data
{
    public class PetStoreMVCApplicationContext : DbContext
    {
        public PetStoreMVCApplicationContext (DbContextOptions<PetStoreMVCApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<PetStoreMVCApplication.Models.Owner> Owner { get; set; }

        public DbSet<PetStoreMVCApplication.Models.Pet> Pet { get; set; }
    }
}
