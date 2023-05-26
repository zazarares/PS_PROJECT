
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasMany(a => a.App).WithOne().HasForeignKey(b=>b.DoctorID).HasPrincipalKey(a=>a.id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Donator>().HasMany(a => a.App).WithOne().HasForeignKey(b => b.DonatorID).HasPrincipalKey(a => a.id).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User_Working>().HasOne(a => a.A).WithOne().HasForeignKey<Admin>(b=>b.id);
            modelBuilder.Entity<User_Working>().HasOne(a => a.D).WithOne().HasForeignKey<Doctor>(b=>b.id);
            modelBuilder.Entity<User_Working>().HasOne(a => a.DD).WithOne().HasForeignKey<Donator>(b => b.id);
        }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=BloodDonorAppRERUNFINALFRONTIER;Integrated Security=True;");
        }
        public DbSet<User_Working> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment>Appointments{get;set;}
        public DbSet<Location> Locations { get; set; }
    }

}