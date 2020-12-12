using PokeBattle.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.Jogadores
{
    class Inimigo : Treinador
    {
        public Inimigo(string nome, Pokemon primeiroPokemon, Pokemon segundoPokemon) : base(nome, primeiroPokemon, segundoPokemon)
        {
        }
    }
}
