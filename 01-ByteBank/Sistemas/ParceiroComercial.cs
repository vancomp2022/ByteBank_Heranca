﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Sistemas
{
    public class ParceiroComercial
    {
        public string Senha { get; set; }
        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
