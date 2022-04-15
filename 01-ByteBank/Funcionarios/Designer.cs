using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string CPF) : base(3000, CPF) { 
        Console.WriteLine("Criando designer." + CPF);
        }
        public override double GetBonificacao()
        {
           return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

    }
}
