using PokeBattle.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.Jogadores
{
    class Treinador
    {
        public string Nome { get; private set; }
        public Pokemon[] pokemons { get; private set; }

        public Treinador(string nome, Pokemon primeiroPokemon, Pokemon segundoPokemon)
        {
            Nome = nome;
            Pokemon PrimeiroPokemon = new Pokemon(primeiroPokemon.Nome, primeiroPokemon.QntVida, primeiroPokemon.Ataques[0], primeiroPokemon.Ataques[1]);
            Pokemon SegundoPokemon = new Pokemon(segundoPokemon.Nome, segundoPokemon.QntVida, segundoPokemon.Ataques[0], segundoPokemon.Ataques[1]);
            pokemons = new Pokemon[2] { PrimeiroPokemon, SegundoPokemon };
        }

        public void Atacar(int indicePokemon, int indiceAtaque, Pokemon pokemon)
        {
            Random rnd = new Random();
            int acerto = rnd.Next(0, 100);

            if(pokemons[indicePokemon].Ataques[indiceAtaque].ChanceDeAcerto >= acerto)
            {
                Console.WriteLine( pokemons[indicePokemon].Nome + " acertou o golpe " +
                    pokemons[indicePokemon].Ataques[indiceAtaque].Nome + " atingindo o " +
                    pokemon.Nome + ", causando " + pokemons[indicePokemon].Ataques[indiceAtaque].Dano + " de dano!");
                pokemon.PerderVida(pokemons[indicePokemon].Ataques[indiceAtaque].Dano);
            }
            else
            {
                Console.WriteLine(pokemons[indicePokemon].Nome + "Errou o golpe!");
            }
        }
    }
}
