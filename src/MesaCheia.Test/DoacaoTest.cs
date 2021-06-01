using MesaCheia.Domain;
using MesaCheia.Test.Util;
using System;
using Xunit;

namespace MesaCheia.Test
{
    public class DoacaoTest
    {
        [Fact]
        public void Doacao_instancia()
        {
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();
            Assert.IsType<Doacao>(doacao);
        }
        [Fact]
        public void Doacao_instancia_direto()
        {
            CompraDoacao compraDoacao = InstanciasClasses.ObterInstanciaCompraDoacao();
            Receptor receptor = InstanciasClasses.ObterInstanciaReceptor();

            Doacao doacao = Doacao.Create(compraDoacao.IdCompraDoacao, receptor.IdReceptor, InstanciasClasses.DOACAO_DATADOACAO, InstanciasClasses.DOACAO_DATARETIRADA);

            Assert.IsType<Doacao>(doacao);
        }
        [Fact]
        public void Doacao_createdatadoacao()
        {
            DateTime dataDoacao = DateTime.Now.AddDays(8);
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();
            doacao.CreateDataDoacao(dataDoacao);

            Assert.Equal(dataDoacao, doacao.DataDoacao);
        }
        [Fact]
        public void Doacao_createdataretirada()
        {
            DateTime dataRetirada = DateTime.Now.AddDays(10);
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();
            doacao.CreateDataRetirada(dataRetirada);

            Assert.Equal(dataRetirada, doacao.DataRetirada);
        }
        [Fact]
        public void Doacao_validardoacao()
        {
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();
            bool validarDoacao = doacao.ValidarDoacao();
            Assert.True(validarDoacao);
        }
        [Fact]
        public void Doacao_iddoacao_gerado()
        {
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();

            Assert.True(doacao.IdDoacao > 0);
        }
        [Fact]
        public void Doacao_idcompradoacao_preenchido()
        {
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();

            Assert.True(doacao.IdCompraDoacao > 0);
        }
        [Fact]
        public void Doacao_idreceptor_preenchido()
        {
            Doacao doacao = InstanciasClasses.ObterInstanciaDoacao();

            Assert.True(doacao.IdReceptor > 0);
        }
    }
}
