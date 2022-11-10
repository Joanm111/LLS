using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;

namespace ExamenParcial2.Models
{
    public class TiendaContext : DbContext

    {
        public TiendaContext()
        {

        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<libros> Libros { get; set; }

        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=Parcial2-be5f7bca-bca1-45a3-8269-b07cf81075aa; Trusted_Connection=True;");
            }
        }


    }
}
