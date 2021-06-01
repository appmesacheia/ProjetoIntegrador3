using MesaCheia.Domain;
using MesaCheia.Test.Util;
using System;
using Xunit;

namespace MesaCheia.Test
{
    public class CompraParaDoacaoTest
    {
        [Fact]
        public void Compra_instancia()
        {
            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();

            Assert.IsType<CompraDoacao>(compra);
        }
        [Fact]
        public void Compra_instancia_direto()
        {
            Doador doador = InstanciasClasses.ObterInstanciaDoador();
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();

            CompraDoacao compra = CompraDoacao.Create(doador.IdDoador, estoque.IdEstoque, InstanciasClasses.COMPRA_FORMAPAGAMENTO, InstanciasClasses.COMPRA_DATA, InstanciasClasses.COMPRA_COMENTARIO, InstanciasClasses.COMPRA_RECIBO);
            Assert.IsType<CompraDoacao>(compra);
        }
        [Fact]
        public void Compra_createdata()
        {
            DateTime data = DateTime.Now.AddDays(-1);

            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();
            compra.CreateData(data);

            Assert.Equal(data, compra.Data);
        }
        [Fact]
        public void Compra_createcomentario()
        {
            string comentario = "este é um teste classe de teste";

            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();
            compra.CreateComentario(comentario);

            Assert.Equal(comentario, compra.Comentario);
        }

        [Fact]
        public void Compra_fornecerrecibo()
        {
            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();
            string recibo = compra.FornecerRecibo();

            Assert.Contains(compra.IdEstoque.ToString(), recibo);
            Assert.Contains(compra.Data.ToString(), recibo);
            Assert.Contains(compra.FormaPagamento.ToString(), recibo);
            Assert.Contains(compra.Recibo.ToString(), recibo);
        }

        [Fact]
        public void Compra_validarcompra()
        {
            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();
            bool compravalida = compra.ValidarCompra();

            Assert.True(compravalida);
        }
        [Fact]
        public void Compra_idcompra_gerado()
        {
            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();

            Assert.True(compra.IdCompraDoacao > 0);
        }
        [Fact]
        public void Compra_iddoador()
        {
            CompraDoacao compra = InstanciasClasses.ObterInstanciaCompraDoacao();

            Assert.True(compra.IdDoador > 0);
        }
    }
}
