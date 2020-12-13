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
        public Pokemon pokemonEmCampo { get; private set; }

        public Treinador(string nome, Pokemon primeiroPokemon, Pokemon segundoPokemon)
        {
            this.Nome = nome;
            Pokemon PrimeiroPokemon = new Pokemon(primeiroPokemon.Nome, primeiroPokemon.QntVida, primeiroPokemon.Ataques[0], primeiroPokemon.Ataques[1]);
            Pokemon SegundoPokemon = new Pokemon(segundoPokemon.Nome, segundoPokemon.QntVida, segundoPokemon.Ataques[0], segundoPokemon.Ataques[1]);
            this.pokemons = new Pokemon[2] { PrimeiroPokemon, SegundoPokemon };
            this.EscolherPokemon(PrimeiroPokemon);
        }

        public bool EscolherPokemon(Pokemon pokemon)
        {
            if (pokemon != this.pokemons[0] && pokemon != this.pokemons[1])
            {
                Console.WriteLine("Pokemon invalido! Selecione um pokmemon valido!");
                return false;
            }
            else if(this.pokemonEmCampo == pokemon)
            {
                Console.WriteLine("O pokemon já está em campo e não pode ser selecionado!");
                return false;
            }
            else
            {
                if (pokemon.QntVida <= 0)
                {
                    Console.WriteLine("Este pokemon está inconciente e não pode ser selecionado!");
                    return false;
                }
                else
                {
                    this.pokemonEmCampo = pokemon;
                    Console.WriteLine("O pokemon " + pokemon.Nome + " foi selecionado!");
                    return true;
                }
            }
        }

        public void Atacar(int indicePokemon, int indiceAtaque, Pokemon pokemon)
        {
            Random rnd = new Random();
            int acerto = rnd.Next(0, 100);

            if( this.pokemons[indicePokemon].Ataques[indiceAtaque].ChanceDeAcerto >= acerto )
            {
                Console.WriteLine( this.pokemons[indicePokemon].Nome + " acertou o golpe " +
                    this.pokemons[indicePokemon].Ataques[indiceAtaque].Nome + " atingindo o " +
                    pokemon.Nome + ", causando " + this.pokemons[indicePokemon].Ataques[indiceAtaque].Dano + " de dano!" );
                pokemon._PerderVida( this.pokemons[indicePokemon].Ataques[indiceAtaque].Dano );
            }
            else
            {
                Console.WriteLine(pokemons[indicePokemon].Nome + " errou o golpe!");
            }
        }

        public bool Curar(int cura, Pokemon pokemon)
        {
            if(pokemon.QntVida <= 0)
            {
                Console.WriteLine("O pokemon está inconsciente e não pode receber cura!");
                return false;
            }
            else
            {
                if(pokemon.QntVida >= pokemon.QntVidaMaxima)
                {
                    Console.WriteLine("O " + pokemon.Nome + " está com a vida maxima!");
                    return false;
                }
                else
                {
                    if(pokemon.QntVida <= (pokemon.QntVidaMaxima - cura))
                    {
                        pokemon._ReceberVida(cura);
                        Console.WriteLine("O " + pokemon.Nome + " curou " + cura + " de vida!");
                        return true;
                    }
                    else
                    {
                        int maximoCura = pokemon.QntVidaMaxima - pokemon.QntVida;
                        pokemon._ReceberVida(maximoCura);
                        Console.WriteLine("O " + pokemon.Nome + " curou " + maximoCura + " de vida!");
                        return true;
                    }
                }
            }
        }
    }
}
