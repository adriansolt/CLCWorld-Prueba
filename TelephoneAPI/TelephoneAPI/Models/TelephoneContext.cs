using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneAPI.Models
{
    public class TelephoneContext:DbContext
    {
        public TelephoneContext(DbContextOptions<TelephoneContext> options):base(options)
        {

        }

        public DbSet<Telephone> Telephones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telephone>().HasData(
                        new Telephone
                        {
                            id = 1,
                            number = "612345678"
                        },
                        new Telephone
                        {
                            id = 2,
                            number = "667345698"
                        },
                        new Telephone
                        {
                            id = 3,
                            number = "668956112"
                        },
                        new Telephone
                        {
                            id = 4,
                            number = "600254627"
                        },
                        new Telephone
                        {
                            id = 5,
                            number = "667984452"
                        },
                        new Telephone
                        {
                            id = 6,
                            number = "604571529"
                        }
                );
        }
    }
}
