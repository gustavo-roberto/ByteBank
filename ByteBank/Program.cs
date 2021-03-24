using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.123.123-12");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "asd");
            sistemaInterno.Logar(parceiro, "12345");
        }

        public static void CalcularBonificacao()
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("312.452.232-09");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("234.533.123-09");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("847.293.022-04");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("555.524.123-09");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificação a ser paga: R$" + gerenciador.GetTotalBonificacao());
        }

        public void codigoDaAula()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario carlos = new Funcionario(1000, "345.742.554-32");

            //carlos.Nome = "Carlos Santos de Almeida";

            //Console.WriteLine("Salario do Carlos antes do aumento: " + carlos.Salario);

            //gerenciador.Registrar(carlos);

            //carlos.AumentarSalario();

            //Console.WriteLine("Salario do Carlos depois do aumento: " + carlos.Salario);

            Diretor marcela = new Diretor("132.321.123-09");

            marcela.Nome = "Marcela";

            Console.WriteLine("Salario da Marcela antes do aumento: " + marcela.Salario);

            gerenciador.Registrar(marcela);

            marcela.AumentarSalario();

            Console.WriteLine("Salario da Marcela depois do aumento: " + marcela.Salario);

            //Console.WriteLine("Bonificação de carlos: " + carlos.GetBonificacao());
            Console.WriteLine("Bonificação da marcela: " + marcela.GetBonificacao());

            Console.WriteLine("Bonificação total que a empresa deverá pagar: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Total de funcionarios criados: " + Funcionario.TotalFuncionarios);
        }
    }
}
