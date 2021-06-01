using System;

namespace MesaCheia.Domain
{
    public class CompraDoacao
    {
        #region Properties
        private int idCompraDoacao;
        private int idDoador;
        private int idEstoque;
        private DateTime data;
        private string comentario;
        private string formaPagamento;
        private int recibo;
        #endregion

        #region Get/Set
        public int IdCompraDoacao
        {
            get { return idCompraDoacao; }
            private set { idCompraDoacao = value; }
        }
        public int IdDoador
        {
            get { return idDoador; }
            private set { idDoador = value; }
        }
        public int Recibo
        {
            get { return recibo; }
            private set { recibo = value; }
        }
        public string FormaPagamento
        {
            get { return formaPagamento; }
            private set { formaPagamento = value; }
        }
        public string Comentario
        {
            get { return comentario; }
            private set { comentario = value; }
        }
        public DateTime Data
        {
            get { return data; }
            private set { data = value; }
        }
        public int IdEstoque
        {
            get { return idEstoque; }
            private set { idEstoque = value; }
        }
        #endregion

        public bool ValidarCompra()
        {
            //Discutindo funcionamento desta funcionalidade.
            return true;
        }

        public void CreateData(DateTime data)
        {
            Data = data;
        }

        public void CreateComentario(string comentario)
        {
            Comentario = comentario;
        }

        public string FornecerRecibo()
        {
            string recibo = @$"
Identificador Estoque: {idEstoque}
Data Compra: {Data}
Forma Pagamento: {FormaPagamento}
Recibo: {Recibo}
";

            return recibo;
        }

        public static CompraDoacao Create(int idDoador, int idEstoque, string formaPagamento, DateTime data, string comentario, int recibo)
        {
            //Gerando IdCompraDoacao randômico
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000); //for ints

            CompraDoacao compraDoacao = new CompraDoacao()
            {
                IdCompraDoacao = numeroAleatorio,
                IdDoador = idDoador,
                IdEstoque = idEstoque,
                FormaPagamento = formaPagamento,
                Data = data,
                Comentario = comentario,
                Recibo = recibo
            };
            return compraDoacao;
        }
    }
}
