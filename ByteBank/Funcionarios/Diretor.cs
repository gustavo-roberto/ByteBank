using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    public class Diretor :  FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Diretor criado.");

        }
        public override double GetBonificacao()
        {
            return Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }

    
}
