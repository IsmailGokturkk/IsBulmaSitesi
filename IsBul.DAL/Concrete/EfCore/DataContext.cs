using IsBul.Entitty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsBul.DAL.Concrete.EfCore
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-J44951SB\\SQLEXPRESS; Database=IsBul; Integrated Security=true; TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CompanyDetail> CompanyDetails { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobDetail> JobDetails { get; set; }
        public DbSet<WhoWeAre>WhoWeAres { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        

    }

}
