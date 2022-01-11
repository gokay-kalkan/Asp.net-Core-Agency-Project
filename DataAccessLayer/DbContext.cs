using EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbContext:IdentityDbContext<AppUser>
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U1FS87R\SQLEXPRESS; database=AgencyCore; integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Istatistic> Istatistics { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
