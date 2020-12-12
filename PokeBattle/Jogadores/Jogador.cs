using PokeBattle.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.Jogadores
{
    class Jogador : Treinador
    {
        public int ContadorDeVitorias { get; private set; }

        public Jogador(string nome, Pokemon primeiroPokemon, Pokemon segundoPokemon) : base(nome, primeiroPokemon, segundoPokemon)
        {
        }

        public void AumentarContadorDeVitorias()
        {
            this.ContadorDeVitorias++;
        }
    }
}
