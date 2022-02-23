using CadastroAndLoginAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAndLoginAPI.Repositories
{
    public interface IPessoaRepository
    {
        Task<Pessoa> Get(int id);

        Task<Pessoa> Create(Pessoa pessoa);

   
        Task<Pessoa> GetLogin(string email);

    }
}
