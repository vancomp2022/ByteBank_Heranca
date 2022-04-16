namespace _01_ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(ParceiroComercial parceiro, string senha)
        {
            bool usuarioAutenticado = ParceiroComercial.Autenticar(senha);
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
