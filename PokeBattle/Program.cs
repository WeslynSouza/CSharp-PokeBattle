using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();

            Console.ReadLine();
        }

        static void MenuInicial()
        {
            Console.WriteLine("Selecione uma opção\n");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Iniciar batalha.");
            Console.WriteLine("2 - Visualizar pokemon cadastrados.");
            Console.WriteLine("3 - Cadastrar novos prokemon.");
            Console.WriteLine("4 - Alterar pokemon cadastrado.");
            Console.WriteLine("0 - Fechar programa.");
            Console.WriteLine(" ");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1: 
                    Console.WriteLine("Batalha iniciada");
                    Console.ReadLine();   
                    break;

                case 2:
                    Console.WriteLine("Pokemon cadastrados");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Cadastrar novo prokemon");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Alterar pokemon cadastrado");
                    Console.ReadLine();
                    break;

                case 0:
                    break;

                default:
                    Console.Clear();
                    MenuInicial();
                    break;

            }
        }
    }
}
