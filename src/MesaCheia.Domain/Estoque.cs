using System;

namespace MesaCheia.Domain
{
    public class Estoque
    {
        #region Properties
        private int idEstoque;
        private int idSupermercado;
        private string produto;
        private string quantidade;
        private decimal valor;
        private DateTime dataDisponivel;
        private DateTime validade;
        private string localRetirada;
        private string horaRetirada;
        #endregion

        #region Get/Set
        public string Produto
        {
            get { return produto; }
            private set { produto = value; }
        }
        public string HoraRetirada
        {
            get { return horaRetirada; }
            private set { horaRetirada = value; }
        }
        public string LocalRetirada
        {
            get { return localRetirada; }
            private set { localRetirada = value; }
        }
        public DateTime Validade
        {
            get { return validade; }
            private set { validade = value; }
        }
        public DateTime DataDisponivel
        {
            get { return dataDisponivel; }
            private set { dataDisponivel = value; }
        }
        public decimal Valor
        {
            get { return valor; }
            private set { valor = value; }
        }
        public string Quantidade
        {
            get { return quantidade; }
            private set { quantidade = value; }
        }
        public int IdSupermercado
        {
            get { return idSupermercado; }
            private set { idSupermercado = value; }
        }
        public int IdEstoque
        {
            get { return idEstoque; }
            private set { idEstoque = value; }
        }
        #endregion

        public static Estoque Create(string produto, int idSupermecado, string quantidade, decimal valor, DateTime dataDisponivel, DateTime validade, string localRetirada, string horaRetirada)
        {
            //Gerando idEstoque randômico
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000); //for ints

            Estoque estoque = new Estoque()
            {
                Produto = produto,
                IdEstoque = numeroAleatorio,
                IdSupermercado = idSupermecado,
                Quantidade = quantidade,
                Valor = valor,
                DataDisponivel = dataDisponivel,
                Validade = validade,
                LocalRetirada = localRetirada,
                HoraRetirada = horaRetirada
            };

            return estoque;
        }

        public void NomeProduto(string produto)
        {
            Produto = produto;
        }

        public bool ValidarEstoque()
        {
            //Estamos verificando a melhor maneira de desenvolver este método. À princípio, validar quantidade de compras feitas em banco de dados.
            return true;
        }

        public void DisponibilizarRetirada(DateTime dataDisponivel)
        {
            DataDisponivel = dataDisponivel;
        }

    }
}
