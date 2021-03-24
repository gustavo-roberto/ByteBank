
using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; } = 0;

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            TotalFuncionarios++;
            Salario = salario;
            CPF = cpf;
            Console.WriteLine("Funcioanario número " + TotalFuncionarios + " criado");
        }

        public abstract double GetBonificacao();        

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
