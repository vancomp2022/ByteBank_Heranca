using _01_ByteBank.Funcionarios;
using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticar funcionario, string senha)
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



            SistemaInterno sistema =  public bool Logar(Diretor funcionario, string senha)
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
        
            SistemaInterno sistemaInterno = new SistemaInterno("159753");



            public bool Logar(GerenteDeConta funcionario, string senha)
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
        }
}
