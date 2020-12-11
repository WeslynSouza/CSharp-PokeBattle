using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.Pokemons
{
    public class Ataque
    {
        public string Nome { get; private set; }
        public int Dano { get; private set; }
        public int ChanceDeAcerto { get; private set; }

        public Ataque(string nome, int dano, int acerto)
        {
            Nome = nome;
            Dano = dano;
            ChanceDeAcerto = acerto;
        }

        public void ExibirAtaque()
        {
            Console.WriteLine("Nome do ataque: " + Nome);
            Console.WriteLine("Dano do ataque: " + Dano);
            Console.WriteLine("Chande de acerto do ataque: " + ChanceDeAcerto);
        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void AlterarDano(int dano)
        {
            Dano = dano;
        }

        public void AlterarAcerto(int acerto)
        {
            ChanceDeAcerto = acerto;
        }
    }
}
