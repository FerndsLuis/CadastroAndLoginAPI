using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAndLoginAPI.Model
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {
            //criando o BD
            Database.EnsureCreated();
        }   

        public DbSet<Pessoa> Pessoas { get; set; } //passa a entidade 
    }
}
