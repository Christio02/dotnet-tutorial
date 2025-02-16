using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.data
{
    // search individual tables
    // specify tables we want
    public class ApplicationDBContext: DbContext
    {
 
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)

        {
    
        }

        // manipulate stock table
        public DbSet<Stock> Stocks {get; set;}

        public DbSet<Comment> Comments {get; set;}
        
    }
}