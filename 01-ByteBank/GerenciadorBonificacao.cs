using _01_ByteBank.Funcionarios;
using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ByteBank_Parte3
{
    public class GerenciadorBonificacao
    {
        private static double _totalBonificacao;
        public static void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public static void Registrar(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }

        public static void Registrar(Auxiliar auxiliar)
        {
            _totalBonificacao += auxiliar.GetBonificacao();
        }

        public static void Registrar(Designer designer)
        {
            _totalBonificacao += designer.GetBonificacao();
        }

        public static void Registrar(GerenteDeConta ger_conta)
        {
            _totalBonificacao += ger_conta.GetBonificacao();
        }
        public static double GetTotalBonificacao()
        {
            return _totalBonificacao;   
        }
    }
}
