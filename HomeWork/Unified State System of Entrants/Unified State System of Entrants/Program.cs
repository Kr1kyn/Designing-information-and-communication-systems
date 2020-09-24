/*using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL;
using Unified_State_System_of_Entrants.BLL.Interfaces;
using Unified_State_System_of_Entrants.DAL.ContextDB;
using Unified_State_System_of_Entrants.DAL.Repositories;

namespace Unified_State_System_of_Entrants
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UsedDbContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TestsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            using (var dbContext = new UsedDbContext(optionsBuilder.Options))
            {
                RepositoryEntrant repositoryEntrant = new RepositoryEntrant(dbContext);
                RepositoryHEI repositoryHEI = new RepositoryHEI(dbContext);

            }
            //var dbContext = new UsedDBContext(new DbContextOptions<UsedDBContext> db);
            //ApplicationCreater newApllication = new HEI_ApplicationCreater(1, 1);
            //newApllication.CreateApplication
        }
    }
}*/
