using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dandara2.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ClienteCadastro> ClienteCadastro { get; set; }
        public DbSet<CadastroVendedor> CadastroVendedor { get; set; }
        public DbSet<Produto> Produto { get; set; }


    }
    } 

