using _01_ByteBank.Sistemas;
using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios
{
    public class Diretor : Autenticar
    {
        public string Senha { get; set; }
        public Diretor(string CPF) : base(20000, CPF) { 
        Console.WriteLine("Criando diretor." + CPF);
        }
        public override double GetBonificacao()
        {
           return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
               
        }

    }
}
