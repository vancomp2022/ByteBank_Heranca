using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Sistemas
{
    public class Autenticar : Funcionario
    {
        private int v;
        private string cPF;

        public Autenticar(int v, string cPF)
        {
            this.v = v;
            this.cPF = cPF;
        }

        public string Senha { get; set; }

        public static bool Autenticar(string senha)
        {
            return Senha == senha ;   
        }
    }
}
