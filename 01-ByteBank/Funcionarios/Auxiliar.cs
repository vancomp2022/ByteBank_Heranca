using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string CPF) : base(20000, CPF) { 
        Console.WriteLine("Criando auxiliar." + CPF);
        }
        public override double GetBonificacao()
        {
           return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

    }
}
