using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Parte3.Funcionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // N - ...

        private int _tipo;
        public string Nome { get; set; }
        private string CPF { get; set; }
        public double Salario { get; protected set; }

        //public String Senha { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public Funcionario(double salario, string CPF)
        {
            Console.WriteLine("Criando Funcionario."  + CPF);
            CPF = CPF;
            Salario = salario;  
            TotalDeFuncionarios++;
        }

       /* public bool Autenticar(string senha)
        {
            return Senha == senha;*/

             public bool Logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("senha Incorreta!");
                return false;
            }
 
        }
        public void abstract void AumentarSalario();
   /*     {
            Salario *= 1.1;
        }*/

        public abstract double GetBonificacao();
        /*{
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }*/
    }
}
