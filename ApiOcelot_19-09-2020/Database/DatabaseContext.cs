using ApiOcelot_19_09_2020.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOcelot_19_09_2020.Database
{
    public class DatabaseContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-J3RI057\SQLEXPRESS;initial catalog=OcelotDb;persist security info=True;user id=sa;password=raju@123;");
        }
    }
}
