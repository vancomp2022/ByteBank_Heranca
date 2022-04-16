using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Sistemas
{
    public interface IAutenticavel {
        //private string CPF;

        public void Autenticavel(int v, string CPF)
        {
            this.v = v;
            this.CPF = CPF;
        }

        public void Autenticavel(double salario, string cpf)
            //: base(salario, cpf)
        {

        }
        public string Senha { get; set; }

        public static bool Autenticar(string senha)
        {
            return true;
        }
    } 
    
}
