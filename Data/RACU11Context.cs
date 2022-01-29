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

        public DbSet<RACU11.Models.IRF> IRF { get; set; }
        public DbSet<RACU11.Models.ReportingPerson> ReportingPeople { get; set; }
        public DbSet<RACU11.Models.Suspect> Suspect { get; set; }
    }
