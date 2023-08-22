using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program
    {
        public class Aluno
        {
            // atributos da classe aluno
            public string nome;
            public string rg;
            public string dt_nascimento;

            //Associação de classe porque turma_aluno é do tipo Turma, igual o nome que é do tipo string
            public Turma turma_aluno;
        }

        public class Funcionario
        {
            public string matricula;
            public string nome;
            public string cargo;
            public double salario;

            //A seguir é um constructor, ele ta com o mesmo nome da classe porém ta inicializando o salário em 2000. Porém eu deixei ele sem void, double ou algo assim porque não entendi se precisa colocar.
            public Funcionario()
            {
                salario = 2000;

            }

            // Esses dois AumentaSalario é uma sobrecarga de método, porém eu não entendi do porque seria necessário já que ambos fazem as mesmas coisas, então para deixar diferente eu deixei um com void e outro com double e return.
            public void AumentaSalario()
            {
                salario += salario * 0.1;
            }

          
            public double AumentaSalario(double valor)
            {
                salario = valor;
                salario += salario * 0.1;
                return salario;
            }



            public void ConsultaDados()
            {
                Console.WriteLine($"Matricula: {this.matricula}\nNome do Funcionario: {this.nome}\nCargo: {this.cargo}.\nSalário: {this.salario}");
            }
        }


        public class Turma
        {
            public string periodo;
            public string serie;
            public string sigla;
            public string tipo_ensino;
        }

        public class Banco
        {
            public int numeroConta;
            public double Limite;
            public double Saldo;

            public double Depositar(int valor)
            {
                return Saldo += valor;
            }

            public double Sacar(int valor)
            {
                return Saldo -= valor;
            }

            public void Extrato()
            {
                Console.WriteLine("Saldo da Conta é: " + Saldo);
            }
        }






        static void Main(string[] args)
        {

            //novo objeto criado
            Aluno aluno1 = new Aluno()
            {
                //propriedades
                nome = "Robson",
                rg = "12345x",
                dt_nascimento = "01/ 01 / 01",
                turma_aluno = new Turma()
                {
                    periodo = "Matutino",
                    serie = "1",
                    sigla = "EM",
                    tipo_ensino = "Ensino Médio"
                }
            };
            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("RG:" + aluno1.rg);
            Console.WriteLine("Data de Nascimento: " + aluno1.dt_nascimento);
            Console.WriteLine("Período: {0}", aluno1.turma_aluno.periodo);
            Console.WriteLine("Série: {0}", aluno1.turma_aluno.serie);
            Console.WriteLine("Sigla: {0}", aluno1.turma_aluno.sigla);
            Console.WriteLine("Tipo de Ensino: {0}", aluno1.turma_aluno.tipo_ensino);


            Console.WriteLine("__________________________________________________________");

            //novo objeto criado
            Aluno aluno2 = new Aluno()
            {
                //propriedades
                nome = "Adriana",
                rg = "54321x",
                dt_nascimento = "02 / 02/ 02",

                //uma forma mais fácil de atribuir os valores de cada atributo da classe, separando os valores com vírgulas, de vez de usar aluno2.periodo
                turma_aluno = new Turma()
                {
                    periodo = "Noturno",
                    serie = "2",
                    sigla = "EM",
                    tipo_ensino = "Ensino Médio"
                }
            };
            Console.WriteLine("Nome: " + aluno2.nome);
            Console.WriteLine("RG:" + aluno2.rg);
            Console.WriteLine("Data de Nascimento: " + aluno2.dt_nascimento);
            Console.WriteLine("Período: {0}", aluno2.turma_aluno.periodo);
            Console.WriteLine("Série: {0}", aluno2.turma_aluno.serie);
            Console.WriteLine("Sigla: {0}", aluno2.turma_aluno.sigla);
            Console.WriteLine("Tipo de Ensino: {0}", aluno2.turma_aluno.tipo_ensino);



            Console.WriteLine("__________________________________________________________");






            Funcionario funcionario1 = new Funcionario()
            {
                matricula = "f5641",
                nome = "Marcia",
                cargo = "Professor(a)",
            };
            funcionario1.AumentaSalario();


            Console.WriteLine("Matricula:" + funcionario1.matricula);
            Console.WriteLine("Funcionário:" + funcionario1.nome);
            Console.WriteLine("Cargo do Funcionário:" + funcionario1.cargo);
            Console.WriteLine(funcionario1.salario);
            


            Console.WriteLine("__________________________________________________________");

            Funcionario funcionario2 = new Funcionario()
            {
                matricula = "f5789",
                nome = "João",
                cargo = "Secrataria",
            };
            funcionario2.AumentaSalario();

            funcionario2.ConsultaDados();

            Console.WriteLine("__________________________________________________________");






            Banco conta1 = new Banco()
            {
                numeroConta = 4789,
                Limite = 500,
                Saldo = 150
            };
            Console.WriteLine("Escolha opção:\n1 - Depositar \n2 - Sacar  \n3 - Imprimir extrato \n4- Sair");
            int opcao = int.Parse(Console.ReadLine());
            int dinheiro;

            switch (opcao)
            {
                case 1:
                    {
                        Console.WriteLine("Valor que será depositado:");
                        dinheiro = int.Parse(Console.ReadLine());
                        Console.WriteLine("Saldo atual da conta: "+ conta1.Depositar(dinheiro));
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Valor que será sacado:");
                        dinheiro=int.Parse(Console.ReadLine());
                        Console.WriteLine("Saldo atual da conta: " + conta1.Sacar(dinheiro));

                        break;
                    }

                case 3:
                    {
                        conta1.Extrato();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Obrigada.");
                        break;
                    }
            }


            Console.WriteLine("__________________________________________________________");

            Funcionario funcionario3 = new Funcionario();
            Console.WriteLine("Nome do funcionário: ");
            funcionario3.nome = Console.ReadLine();
            Console.WriteLine("1 - Alterar nome \n2- Alterar salário \n3- Visualizar dados do funcionario \n4- Sair");
            int menuOpcao = int.Parse(Console.ReadLine());

            switch (menuOpcao)
            {
                case 1:
                    {
                        Console.WriteLine($"Nome anterior: {funcionario3.nome}Novo nome: ");
                        funcionario3.nome = Console.ReadLine();
                        Console.WriteLine("Nome Atual: " + funcionario3.nome);
                        break;
                    }
                case 2:
                {
                    Console.WriteLine("Salário: ");
                       funcionario3.salario = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Salário do funcionario {funcionario3.nome} é de {funcionario3.salario}.");
                    break;
                }
                case 3:
                    {
                        Console.WriteLine($"Dados do Funcionário \nNome: {funcionario3.nome} \nSalário: {funcionario3.salario}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Dados do Funcionário \nNome: {funcionario3.nome} \nSalário: {funcionario3.salario}");
                        break;
                    }
            }



            Console.ReadKey();
        }
    }
}
