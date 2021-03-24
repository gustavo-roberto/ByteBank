using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao = 0;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
