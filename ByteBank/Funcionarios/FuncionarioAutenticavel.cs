
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
