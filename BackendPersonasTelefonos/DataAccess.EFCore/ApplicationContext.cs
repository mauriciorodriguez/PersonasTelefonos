using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.EFCore
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Telefonos> Telefonos { get; set; }
    }
}
