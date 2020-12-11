using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeBattle.Pokemons;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMenuInicial();

            Console.ReadLine();
        }

        static void ExibirMenuInicial()
        {
            Console.WriteLine("Selecione uma opção\n");

            Console.WriteLine("1 - Iniciar batalha.");
            Console.WriteLine("2 - Visualizar pokemon cadastrados.");
            Console.WriteLine("3 - Cadastrar novos prokemon.");
            Console.WriteLine("4 - Alterar pokemon cadastrado.");
            Console.WriteLine("0 - Fechar programa.");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    IniciarBatalha(); 
                    break;

                case 2:
                    ExibirPokemon();
                    break;

                case 3:
                    CadastrarPokemon();
                    break;

                case 4:
                    AlterarPokemon();
                    break;

                case 0:
                    break;

                default:
                    Console.Clear();
                    ExibirMenuInicial();
                    break;

            }
        }

        static void IniciarBatalha()
        {
            Console.Clear();
            Console.WriteLine("Batalha iniciada!");
            Console.ReadLine();
        }

        static void ExibirPokemon()
        {
            Console.Clear();
            Console.WriteLine("Galeria prokemon.\n");
            Console.ReadLine();
        }

        static void CadastrarPokemon()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar prokemon.");
            Console.ReadLine();
        }

        static void AlterarPokemon()
        {
            Console.Clear();
            Console.WriteLine("Alterar prokemon.");
            Console.ReadLine();
        }

        static Pokemon CarregarPokemon()
        {
            Ataque ataque1 = new Ataque("teste", 30, 70);
            Ataque ataque2 = new Ataque("teste", 30, 70);
            Pokemon teste = new Pokemon("Teste", 100, ataque1, ataque2);

            return teste;
        }
    }
}
