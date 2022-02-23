using System;

namespace CadastroAndLoginAPI.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Ultimo_Acesso { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}
