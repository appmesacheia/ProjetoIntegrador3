using MesaCheia.Domain;
using MesaCheia.Test.Util;
using System;
using Xunit;

namespace MesaCheia.Test
{
    public class EstoqueTest
    {
        [Fact]
        public void Estoque_instancia()
        {
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();
            Assert.IsType<Estoque>(estoque);
        }
        [Fact]
        public void Estoque_instancia_direto()
        {
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();

            Estoque estoque = Estoque.Create(InstanciasClasses.ESTOQUE_PRODUTO, supermercado.IdSupermercado,
                    InstanciasClasses.ESTOQUE_QUANTIDADE, InstanciasClasses.ESTOQUE_VALOR, InstanciasClasses.ESTOQUE_DATADISPONIVEL,
                    InstanciasClasses.ESTOQUE_VALIDADE, InstanciasClasses.ESTOQUE_LOCALRETIRADA, InstanciasClasses.ESTOQUE_HORARETIRADA);

            Assert.IsType<Estoque>(estoque);
        }
        [Fact]
        public void Estoque_disponibilizarretirada()
        {
            DateTime dataRetirada = DateTime.Now.AddDays(15);
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();
            estoque.DisponibilizarRetirada(dataRetirada);

            Assert.Equal(dataRetirada, estoque.DataDisponivel);
        }
        [Fact]
        public void Estoque_nomeproduto()
        {
            string produtoNovoNome = "Novo Nome Produto";
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();
            estoque.NomeProduto(produtoNovoNome);

            Assert.Equal(produtoNovoNome, estoque.Produto);
        }
        [Fact]
        public void Estoque_validarestoque()
        {
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();
            bool estoqueValido = estoque.ValidarEstoque();

            Assert.True(estoqueValido);
        }
        [Fact]
        public void Estoque_idestoque_gerado()
        {
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();

            Assert.True(estoque.IdEstoque > 0);
        }
        [Fact]
        public void Estoque_idsupermercado_valido()
        {
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();

            Assert.True(estoque.IdSupermercado > 0);
        }
        [Fact]
        public void Estoque_camposvalidos()
        {
            Estoque estoque = InstanciasClasses.ObterInstanciaEstoque();

            Assert.Equal(InstanciasClasses.ESTOQUE_VALOR, estoque.Valor);
            Assert.Equal(InstanciasClasses.ESTOQUE_HORARETIRADA, estoque.HoraRetirada);
            Assert.Equal(InstanciasClasses.ESTOQUE_LOCALRETIRADA, estoque.LocalRetirada);
            Assert.Equal(InstanciasClasses.ESTOQUE_VALIDADE, estoque.Validade);
            Assert.Equal(InstanciasClasses.ESTOQUE_QUANTIDADE, estoque.Quantidade);
        }
    }
}
