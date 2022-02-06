using CovainfJCB.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovainfJCB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Representante> Representantes { get; set; }
        public DbSet<Infante> Infantes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
    }
}
