using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.DAL.ContextDB
{
    public class UsedDbContext : DbContext
    {
        public DbSet<Entrant> Entrants { get; set; }
        public DbSet<HEI> HEIs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RankedListApplicants> RankedListApplicants {get;set;}
        public UsedDbContext(DbContextOptions<UsedDbContext> options) : base(options) { }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=Test.db");*/
    }
}
