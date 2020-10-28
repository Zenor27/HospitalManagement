using HospitalEntities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;

namespace HospitalServer.Repositories
{
    /*
     * Application database context
     */
    public class ApplicationDatabaseContext : DbContext
    {
        // Add your DbSet here
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Workaround for null connection string with Nuget PM
            // Try to load web.config
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = "web.config"
            };
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            var connectionStringCollection = configuration.ConnectionStrings.ConnectionStrings["MyConnectionString"];
            string connectionString;
            // If does not work, try classic method
            if (connectionStringCollection == null)
            {
                connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            }
            else
            {
                connectionString = connectionStringCollection.ConnectionString;
            }
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add constraints here
            modelBuilder.Entity<User>()
                        .HasIndex(u => u.Email)
                        .IsUnique();

            modelBuilder.Entity<User>()
                .HasDiscriminator(u => u.UserType)
                .HasValue<Staff>(UserTypeEnum.STAFF)
                .HasValue<Patient>(UserTypeEnum.PATIENT);

            new Seeder(modelBuilder).Seed();
        }
    }
}