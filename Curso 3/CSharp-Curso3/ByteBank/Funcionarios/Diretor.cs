﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Construtor de DIRETOR");
        }
        public override double GetBonificacao()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
