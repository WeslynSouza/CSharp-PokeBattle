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
        public int QntVidaMaxima { get; private set; }
        public int QntVida { get; private set; }
        public Ataque[] Ataques { get; private set; }

        public Pokemon(string nome, int vida, Ataque primeiroAtaque, Ataque segundoAtaque)
        {
            this.Nome = nome;
            this.QntVidaMaxima = vida;
            this.QntVida = vida;
            this.Ataques = new Ataque[2] {primeiroAtaque, segundoAtaque};
        }

        public void ExibirPokemon()
        {
            Console.WriteLine("Nome do pokemon: " + this.Nome);
            Console.WriteLine("Quantidade de vida maxima do prokemon: " + this.QntVidaMaxima);
            Console.WriteLine("Quandidade de vida atual do pokemon: " + this.QntVida);
            Console.WriteLine("Ataques do pokemon: ");
            this.Ataques[0].ExibirAtaque();
            this.Ataques[1].ExibirAtaque();
        }

        public void AlterarNome(string novoNome)
        {
            this.Nome = novoNome;
        }

        public void AumentarVidaMaxima(int qnt)
        {
            this.QntVidaMaxima += qnt;
            this.QntVida += qnt;
        }

        public void PerderVida(int qntVida)
        {
            this.QntVida -= qntVida;
        }

        public void ReceberVida(int qntVida)
        {
            QntVida += qntVida;
        }

        public void AlterarAtaque(int indice, string nome, int dano, int acerto)
        {
            this.Ataques[indice].AlterarNome(nome);
            this.Ataques[indice].AlterarDano(dano);
            this.Ataques[indice].AlterarAcerto(acerto);
        }
    }
}
