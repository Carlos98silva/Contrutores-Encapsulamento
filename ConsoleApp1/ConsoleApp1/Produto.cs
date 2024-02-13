using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Produto {

        public string Nome;
        public double Preco;           // Atributos
        public int Quantidade;

        // Sobrecarga com dois construtores, um com 3 argumentos e outro com 2 argumentos
        public Produto() { //Construtor padrão
            Quantidade = 0;
        }
        
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;                                    // Construtor (atributo = construtor)
            Quantidade = quantidade;
        }
        
        /*public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //Qualquer valor pode ser incluído aqui
        }*/

        public Produto(string nome, double preco) : this() { //Referenciar outro construtor em um contrutor, sendo possível referenciar dentro dos parênteses argumentos de outros construtores
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
