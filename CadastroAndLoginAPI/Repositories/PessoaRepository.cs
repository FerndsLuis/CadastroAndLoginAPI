using CadastroAndLoginAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAndLoginAPI.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        public readonly PessoaContext _context;

        public PessoaRepository(PessoaContext context)
        {
            _context = context;
        }

        //trabalhanso com async para lidar com grandes volumes de dados
        public async Task<Pessoa> Create(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return pessoa;
        }

        public async Task<Pessoa> Get(int id)
        {
            return await _context.Pessoas.FindAsync(id);
        }

        public async Task<Pessoa> GetLogin(string email)
        {
            return await _context.Pessoas.FindAsync(email);
        }



    }
}
