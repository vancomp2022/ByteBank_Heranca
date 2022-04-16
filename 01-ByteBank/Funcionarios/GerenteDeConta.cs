using _01_ByteBank.Sistemas;
using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string CPF) : base(4000, CPF) { 
        Console.WriteLine("Criando Gerente de Conta." + CPF);
        }

        public String Senha { get; set; }

        public override double GetBonificacao()
        {
           return Salario * 0.25;
        }

     /*   public void AumentarSalario()
        {
            Salario *= 1.05;
        }*/

        public bool Autenticar(string senha)
        {
            return Senha == senha;

        }

       /* public override void AumentarSalario()
        {
            Salario *= 1.05;
        }*/
    }
}
