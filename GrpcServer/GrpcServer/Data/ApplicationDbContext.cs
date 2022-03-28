using GrpcServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
         public DbSet<Aposta> Apostas { get; set; }
        public DbSet<Numeros> Numeros { get; set; }

        public DbSet<Estrelas> Estrelas { get; set; }
    }
}
