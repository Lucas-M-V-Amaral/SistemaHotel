using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Suite> suites = new List<Suite>();
            List<Reserva> reservas = new List<Reserva>();
            int opcao = 0;
            int opcao2 = 0;
            string tresOpcoes = "1 - Hospede\n2 - Suíte\n3 - Reserva";

            while (opcao != 4)
            {
                Console.WriteLine("Digite o digito da opção que Deseja realizar:");
                Console.WriteLine("1 - Cadastro\n2 - Consultar\n3 - Listar\n4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"O que deseja cadastrar?");
                        Console.WriteLine(tresOpcoes);
                        while (opcao2 != 1 || opcao2 != 2 || opcao2 != 3)
                        {
                            opcao2 = int.Parse(Console.ReadLine());
                            switch (opcao2)
                            {
                                case 1:
                                    CadastrarHospede();
                                    break;
                                case 2:

                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Digito Inválido. Tente novamente!");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine($"O que deseja consultar?");
                        Console.WriteLine(tresOpcoes);
                        break;
                    case 3:
                        Console.WriteLine($"O que deseja listar?");
                        Console.WriteLine(tresOpcoes);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Digito Inválido!");
                        break;
                }

                /*void OpcoesSecundarias()
                {
                    
                }*/

                void CadastrarHospede() {
                     string nome;
                     int novoId = 1;
                     int idade;
                     string genero;
                     string profissao;

                    Console.WriteLine("Digite o nome do novo hospede:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade do novo hospede:");
                    idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o gênero do novo hospede:");
                    genero = Console.ReadLine();

                    Console.WriteLine("Digite a profissão do novo hospede:");
                    profissao = Console.ReadLine();

                    if (pessoas != null)
                    {
                        for (int i = 0; i <= pessoas.Count; i++)
                        {
                            if (pessoas[i].IdPessoa == novoId)
                            {
                                novoId++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    pessoas.Add(new Pessoa(nome, novoId, idade, genero, profissao));
                }

                void CadastrarSuite()
                {
                    int numero;
                    int andar;
                    int capacidade;
                    decimal valorDiaria;

                    Console.WriteLine("Digite o número da suíte:");
                    numero = int.Parse(Console.ReadLine());

                    if (suites != null)
                    {
                        for (int i = 0; i <= suites.Count; i++)
                        {
                            if (numero < 0)
                            {
                                Console.WriteLine(i);
                                Console.WriteLine("Não existe suíte com número negativo. Tente novamente!");
                                numero = int.Parse(Console.ReadLine());
                                i = 0;
                            }
                            if (suites[i].Numero == numero)
                            {
                                Console.WriteLine(i);
                                Console.WriteLine("Já existe uma suíte com este número. Digite novamente!");
                                numero = int.Parse(Console.ReadLine());
                                i = 0;
                            }
                        }
                    }

                    Console.WriteLine("Digite o andar da suíte:");
                    andar = int.Parse(Console.ReadLine());

                    if (suites != null)
                    {
                        while (AvaliaSuitesPorAndar(andar))
                        {
                            Console.WriteLine("Aparentemente algo está errado, não é possivel haver mais suítes" +
                                " nesse andar. Tente novamente!");
                            andar = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("Digite a capacidade (de pessoas) da suíte:");
                    capacidade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da diária da suíte:");
                    valorDiaria = decimal.Parse(Console.ReadLine());

                }

                bool AvaliaSuitesPorAndar(int andar)
                {
                    int suitesNoAndar = 0;
                    for (int i = 0; i <= suites.Count; i++)
                    {
                        if (suites[i].Andar == andar)
                        {
                            suitesNoAndar++;
                        }
                    }
                    if (suitesNoAndar > 10)
                    {
                        return true;
                    }
                    return false;
                }

                void CadastrarReserva()
                {

                }

            }
        }
    }
}
