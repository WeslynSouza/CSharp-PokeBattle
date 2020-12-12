using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.Pokemons
{
    public class Pokemon
    {
        public string Nome { get; private set; }
        public int QntVida { get; private set; }
        public Ataque[] Ataques { get; private set; }

        public Pokemon(string nome, int vida, Ataque primeiroAtaque, Ataque segundoAtaque)
        {
            Nome = nome;
            QntVida = vida;
            Ataques = new Ataque[2] {primeiroAtaque, segundoAtaque};
        }

        public void ExibirPokemon()
        {
            Console.WriteLine("Nome do pokemon: " + Nome);
            Console.WriteLine("Quandidade de vida do pokemon: " + Nome);
            Console.WriteLine("Ataques do pokemon: ");
            Ataques[0].ExibirAtaque();
            Ataques[1].ExibirAtaque();
        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void PerderVida(int qntVida)
        {
            QntVida -= qntVida;
        }

        public void ReceberVida(int qntVida)
        {
            QntVida += qntVida;
        }

        public void AlterarAtaque(int indice, string nome, int dano, int acerto)
        {
            Ataques[indice].AlterarNome(nome);
            Ataques[indice].AlterarDano(dano);
            Ataques[indice].AlterarAcerto(acerto);
        }
    }
}
