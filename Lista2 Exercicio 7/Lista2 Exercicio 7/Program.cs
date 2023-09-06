using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Construa uma classe chamada Pessoa em C# com uma propriedade estática
            chamada TotalPessoas que guarda o número total de instâncias da classe criadas.
            O valor de TotalPessoas deve ser atualizado sempre que uma nova instância de
            Pessoa for criada.*/


            Pessoa v = new Pessoa();
            Pessoa v2 = new Pessoa();
            Pessoa v3 = new Pessoa();
            Console.WriteLine("Total de pessoas: " + Pessoa.TotalPessoas);

            Console.ReadKey();
        }
    }
}
