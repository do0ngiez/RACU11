using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RACU11.Models;

    public class RACU11Context : DbContext
    {
        public RACU11Context (DbContextOptions<RACU11Context> options)
            : base(options)
        {
        }

        public DbSet<IRF> IRF { get; set; }
        public DbSet<ReportingPerson> ReportingPeople { get; set; }
        public DbSet<Suspect> Suspect { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<RACU11.Models.Victim> Victim { get; set; }
    }
