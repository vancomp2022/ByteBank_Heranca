using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string CPF) : base(20000, CPF) { 
        Console.WriteLine("Criando desenvolvedor." + CPF);
        }
        public override double GetBonificacao()
        {
           return Salario * 0.15;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.1;
        }

    }
}
