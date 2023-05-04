
using Microsoft.EntityFrameworkCore;
namespace BackendFinal
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=BloodDonorApp;Integrated Security=True;");
        }
        public DbSet<User_Working> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment>Appointments{get;set;}
        public DbSet<Location> Locations { get; set; }
    }

}