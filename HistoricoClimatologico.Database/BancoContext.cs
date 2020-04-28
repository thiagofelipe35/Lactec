using Microsoft.EntityFrameworkCore;
using System;

namespace HistoricoClimatologico.Database
{
    public class HistoricoClimatologicoContext : DbContext
    {
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Cidade> Cidade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=./SqliteDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 1, Codigo = "3662762", Nome = "Porto Velho" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 2, Codigo = "3663517", Nome = "Manaus" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 3, Codigo = "3662574", Nome = "Rio Branco" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 4, Codigo = "3467747", Nome = "Campo Grande" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 5, Codigo = "3396016", Nome = "Macapá" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 6, Codigo = "3469058", Nome = "Brasília" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 7, Codigo = "3469745", Nome = "Boa Vista" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 8, Codigo = "3465038", Nome = "Cuiabá" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 9, Codigo = "3455459", Nome = "Palmas" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 10, Codigo = "3386496", Nome = "Teresina" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 11, Codigo = "3448439", Nome = "São Paulo" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 12, Codigo = "3451190", Nome = "Rio de Janeiro" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 13, Codigo = "3405863", Nome = "Belém" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 14, Codigo = "3388368", Nome = "São Luís" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 15, Codigo = "3462377", Nome = "Goiânia" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 16, Codigo = "3450554", Nome = "Salvador" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 17, Codigo = "6320645", Nome = "Maceió" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 18, Codigo = "3452925", Nome = "Porto Alegre" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 19, Codigo = "3464975", Nome = "Curitiba" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 20, Codigo = "6323121", Nome = "Florianópolis" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 21, Codigo = "2270968", Nome = "Belo Horizonte" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 22, Codigo = "3399415", Nome = "Fortaleza" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 23, Codigo = "3390760", Nome = "Recife" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 24, Codigo = "3397277", Nome = "João Pessoa" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 25, Codigo = "3471872", Nome = "Aracaju" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 26, Codigo = "3394023", Nome = "Natal" });
            modelBuilder.Entity<Cidade>().HasData(new Cidade { Id = 27, Codigo = "3444924", Nome = "Vitória" });
        }
    }
}
