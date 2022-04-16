using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Sistemas
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Senha { get; set; }
        public virtual bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
