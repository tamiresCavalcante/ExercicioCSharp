using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio2
{
    class Product
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Product()
        {

        }

        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade;  }
        }

        public double ValorEmEstoque
        {
            get { return _preco * _quantidade; }
        }

        public void AddProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return ($"Name: {_nome}, R${_preco.ToString("F2")} , {_quantidade} unities, Total: R${ValorEmEstoque.ToString("F2")}");
        }
    }
}
