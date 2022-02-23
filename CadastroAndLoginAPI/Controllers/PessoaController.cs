using CadastroAndLoginAPI.Model;
using CadastroAndLoginAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroAndLoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        public readonly IPessoaRepository _pessoaRepository;
        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            return await _pessoaRepository.Get(id);
        }


        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa([FromBody] Pessoa pessoa)
        {
            var newPessoa = await _pessoaRepository.Create(pessoa);
            return CreatedAtAction(nameof(GetPessoa), new { id = newPessoa.Id}, newPessoa);
        }       

        [HttpGet("login/{email}")]
        public async Task<ActionResult<Pessoa>> LoginPessoa(string email, string senha)
        {
            var pessoaLogin = await _pessoaRepository.GetLogin(email);

            if(pessoaLogin.Senha == senha)
            {
                return pessoaLogin;
            }

            return BadRequest();

        }


    }
}
