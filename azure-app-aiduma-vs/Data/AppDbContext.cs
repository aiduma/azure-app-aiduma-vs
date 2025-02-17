﻿using Microsoft.EntityFrameworkCore;

namespace azure_app_aiduma_vs.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons{ get; set; }
    }
}
