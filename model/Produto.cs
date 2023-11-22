﻿namespace model
{
    public class Produto
    {
        private int id = 0;
        private string descricao = "";
        private double prcCusto = 0.0;
        private double prcVenda = 0.0;
        private int quantidade = 0;
        private int categoria = new();

        public Produto() { }

        public Produto(int id, string descricao, double prcCusto, double prcVenda, int quantidade, int categoria)
        {
            Id = id;
            Descricao = descricao;
            PrcCusto = prcCusto;
            PrcVenda = prcVenda;
            Quantidade = quantidade;
            Categoria = categoria;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O id não pode ser menor do que 0.");
                else
                    id = value;
            }
        }

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("A descrição não pode ter um valor vazio.");
                else if (value.Length > 50)
                    throw new ArgumentException("A descrição não pode ter mais de 50 caracteres.");
                else
                    descricao = value;
            }
        }

        public double PrcCusto
        {
            get { return prcCusto; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço de custo não pode ser menor do que zero.");
                else
                    prcCusto = value;
            }
        }

        public double PrcVenda
        {
            get { return prcVenda; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço de venda não pode ser menor do que zero.");
                else
                    prcVenda = value;
            }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("A quantidade não pode ser negativa.");
                else
                    quantidade = value;
            }
        }

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}