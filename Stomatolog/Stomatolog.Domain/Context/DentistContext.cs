using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stomatolog.Domain.Models;
using Stomatolog.Domain.Mappings;

namespace Stomatolog.Domain
{
    public class DentistContext : DbContext
    {
        public DentistContext()
            : base("name=StomatologDBSQLite")
        {
            //Database.SetInitializer<DentistContext>(new CreateDatabaseIfNotExists<DentistContext>());
            //Database.SetInitializer<DentistContext>(new DropCreateDatabaseIfModelChanges<DentistContext>());
            Database.SetInitializer<DentistContext>(new DropCreateDatabaseAlways<DentistContext>());
            //Database.SetInitializer<DentistContext>(new SchoolDBInitializer());
        }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<Diagram> Diagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new VisitMap());
            modelBuilder.Configurations.Add(new DiagramMap());
            base.OnModelCreating(modelBuilder);
        }

    } // class
} // namespace
