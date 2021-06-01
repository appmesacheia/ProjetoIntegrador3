using System;

namespace MesaCheia.Domain
{
    public class Doacao
    {
        private int idDoacao;
        private int idCompraDoacao;
        private int idReceptor;
        private DateTime dataDoacao;
        private DateTime dataRetirada;

        #region Get/Set
        public int IdReceptor
        {
            get { return idReceptor; }
            set { idReceptor = value; }
        }
        public int IdCompraDoacao
        {
            get { return idCompraDoacao; }
            set { idCompraDoacao = value; }
        }
        public DateTime DataRetirada
        {
            get { return dataRetirada; }
            private set { dataRetirada = value; }
        }
        public DateTime DataDoacao
        {
            get { return dataDoacao; }
            private set { dataDoacao = value; }
        }
        public int IdDoacao
        {
            get { return idDoacao; }
            private set { idDoacao = value; }
        }
        #endregion

        public bool ValidarDoacao()
        {
            //estamos verificando a melhor forma de fazer esta validação
            return true;
        }

        public void CreateDataDoacao(DateTime dataDoacao)
        {
            DataDoacao = dataDoacao;
        }

        public void CreateDataRetirada(DateTime dataRetirada)
        {
            DataRetirada = dataRetirada;
        }

        public static Doacao Create(int idCompraDoacao, int idReceptor, DateTime dataDoacao, DateTime dataRetirada)
        {
            //Gerando IdDoacao randômico
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000); //for ints

            Doacao doacao = new Doacao()
            {
                IdDoacao = numeroAleatorio,
                IdCompraDoacao = idCompraDoacao,
                IdReceptor = idReceptor,
                DataDoacao = dataDoacao,
                DataRetirada = dataRetirada
            };

            return doacao;
        }
    }
}
