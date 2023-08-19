using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapp.DB.Models;

namespace webapp.DB.Models
{

    public class WEBAPPDBCONTEXT : DbContext
    {
        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public DbSet<ItemDB> ItemDB { get; set; }
        public DbSet<EmployeeCardDetails> EmployeeCardDetails { get; set; }
        public DbSet<EmployeeIssueDetails> employeeIssueDetails { get; set; }
        public DbSet<LoanCardMaster> LoanCardMaster { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"server=WINDOWS-BVQNF6J\Administrator;database=LoanManagementDB;trusted_connection=true;encrypt=false");
        }
    }

   
}

