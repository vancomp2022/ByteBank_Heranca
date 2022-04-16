﻿using _01_ByteBank.Sistemas;
using ByteBank_Parte3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            :base(salario, cpf)
        {

        }
    
    } public bool Autenticar(string senha)
    {
        return Senha == senha;
    }

}
