using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tetaix_circuit.Modele;

namespace Api.PackDbContext
{
    public class PackContext : IdentityDbContext<User, Role, Guid>
    {
        public PackContext(DbContextOptions<PackContext> options) : base(options)
        {

        }

        public DbSet<Pack> Pack { get; set; }

        public DbSet<Circuit> Circuit { get; set; }

        public DbSet<Voiture> Voiture { get; set; }
    }
}
