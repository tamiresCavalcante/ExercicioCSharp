using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio3
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorEmEstoque
        {
            get { return Preco * Quantidade; }
        }
        public void AddProdutos(int quanmtidade)
        {
            Quantidade += Quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return ($"Name: {_nome}, R${Preco.ToString("F2")} , {Quantidade} unities, Total: R${ValorEmEstoque.ToString("F2")}");
        }
    }
}
