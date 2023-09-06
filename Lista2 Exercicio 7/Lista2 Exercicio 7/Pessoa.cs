using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Exercicio_7
{
    internal class Pessoa
    {
        //constructor para adicionar sempre adicionar a quantidade de pessoas novas
        public Pessoa()
        {
            Pessoa.TotalPessoas++;
        }
        public static int TotalPessoas { get; private set; }

    }
}
