using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bai_EF1__Entity_Framework_Core_Code_First.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bai_EF1__Entity_Framework_Core_Code_First.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
