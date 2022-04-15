// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using _01_ByteBank.Funcionarios;
using ByteBank_Parte3.Funcionarios;
using _01_ByteBank;
using _01_ByteBank.Sistemas;

namespace _ByteBank_Parte3
{
    class Program
    { 
        public static void Main(string[] args)
        {
            //
            //CalcularBonificacao();

            UsarSistema(
            SistemaInterno);

            Console.ReadLine();

            /*   carlos.Nome = "Carlos";
               //carlos.Salario = 2000;
               gerenciador.Registrar(carlos);
               carlos.AumentarSalario();


               jose.Nome = "Jose";
   //            jose.Salario = 20000;
               jose.AumentarSalario();
               gerenciador.Registrar(jose);

               Console.WriteLine(carlos.Nome);
               Console.WriteLine(carlos.GetBonificacao());
               Console.WriteLine("Total de Bonificacao: " + gerenciador.GetTotalBonificacao());


               Console.WriteLine(jose.Nome);
               Console.WriteLine(jose.GetBonificacao());

               Console.WriteLine("Bonificacao de uma referencia de diretor: " + jose.GetBonificacao());
               Console.WriteLine("Bonificacao de uma referencia de funcionario: " + joseTeste.GetBonificacao());

               Console.WriteLine(Funcionario.TotalDeFuncionarios);
               Console.WriteLine("Novo salario do carlos: " + carlos.Salario);
               Console.WriteLine("Novo salario do Jose: " + jose.Salario);*/

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Designer pedro = new Designer("333.333.333 - 88");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("545.666.333.52");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("999.888.333-77");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("777.555.888-66");
            camila.Nome = "Camila";

            GerenciadorBonificacao.Registrar(pedro);
            GerenciadorBonificacao.Registrar(roberta);
            GerenciadorBonificacao.Registrar(igor);
            GerenciadorBonificacao.Registrar(camila);


            Console.WriteLine("Total de Bonificações do mês" + GerenciadorBonificacao.GetTotalBonificacao());

        }

        public static void UsarSistema(SistemaInterno sistemaInterno)
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor roberta = new Diretor("444.555.222-99");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("4251");
            camila.Nome = "Camila';
            camila.Senha = "123" ;

            Funcionario pedro = new Designer("833.555.777.-99");
            pedro.Nome = "Pedro";
            sistemaInterno.Logar(pedro, "djfadsoif");
            sistema.Logar(roberta, "123");
            sistema.Logar(camila, "sbc");
        }


    }
}