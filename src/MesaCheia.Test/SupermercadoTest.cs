using MesaCheia.Domain;
using MesaCheia.Test.Util;
using Xunit;

namespace MesaCheia.Test
{
    public class SupermercadoTest
    {

        [Fact]
        public void Supermercado_instancia_criada()
        {
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();

            Assert.NotNull(supermercado);
        }
        [Fact]
        public void Supermercado_instancia()
        {
            Supermercado supermercado = Supermercado.Create(InstanciasClasses.SUPERMERCADO_RAZAOSOCIAL, InstanciasClasses.SUPERMERCADO_TELEFONE, InstanciasClasses.SUPERMERCADO_CNPJ, InstanciasClasses.SUPERMERCADO_ENDERECO, InstanciasClasses.SUPERMERCADO_NUMERO, InstanciasClasses.SUPERMERCADO_CIDADE, InstanciasClasses.SUPERMERCADO_ESTADO, InstanciasClasses.SUPERMERCADO_EMAIL);

            Assert.IsType<Supermercado>(supermercado);
        }
        [Fact]
        public void Supermercado_alterardados_propriedade_razaosocial_correta()
        {
            string novaRazaoSocial = "Teste456";
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();
            supermercado.AlterarDados(novaRazaoSocial, supermercado.Telefone, supermercado.CNPJ, supermercado.Endereco, supermercado.Numero, supermercado.Cidade, supermercado.Estado, supermercado.Email);

            Assert.Equal(novaRazaoSocial, supermercado.RazaoSocial);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_TELEFONE, supermercado.Telefone);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_CNPJ, supermercado.CNPJ);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_ENDERECO, supermercado.Endereco);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_NUMERO, supermercado.Numero);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_CIDADE, supermercado.Cidade);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_ESTADO, supermercado.Estado);
            Assert.Equal(InstanciasClasses.SUPERMERCADO_EMAIL, supermercado.Email);
        }
        [Fact]
        public void Supermercado_alterardados_todas_propriedades()
        {
            string novaRazaoSocial = "Teste456";
            string telefone = "3232-3232";
            string cnpj = "60775958000186";
            string endereco = "Rua mau me quer";
            int numero = 2;
            string cidade = "Contagem";
            string estado = "São Paulo";
            string email = "teste@yahoo.com";
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();
            supermercado.AlterarDados(novaRazaoSocial, telefone, cnpj, endereco, numero, cidade, estado, email);

            Assert.Equal(novaRazaoSocial, supermercado.RazaoSocial);
            Assert.Equal(telefone, supermercado.Telefone);
            Assert.Equal(cnpj, supermercado.CNPJ);
            Assert.Equal(endereco, supermercado.Endereco);
            Assert.Equal(numero, supermercado.Numero);
            Assert.Equal(cidade, supermercado.Cidade);
            Assert.Equal(estado, supermercado.Estado);
            Assert.Equal(email, supermercado.Email);
        }
        [Fact]
        public void Supermercado_excluirconta()
        {
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();

            supermercado.ExcluirConta();

            Assert.False(supermercado.Ativo);
        }
        [Fact]
        public void Supermercado_validarcnpj_valido()
        {
            bool cnpjValido = Supermercado.ValidarCnpj(InstanciasClasses.SUPERMERCADO_CNPJ);
            Assert.True(cnpjValido);
        }
        [Fact]
        public void Supermercado_validarcnpj_invalido()
        {
            bool cnpjValido = Supermercado.ValidarCnpj("12345678912");
            Assert.False(cnpjValido);
        }
        [Fact]
        public void Supermercado_usuario_criado()
        {
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();
            Assert.Equal(supermercado.CNPJ, supermercado.Usuario);
        }
        [Fact]
        public void Supermercado_idsupermercado_gerado()
        {
            Supermercado supermercado = InstanciasClasses.ObterInstanciaSupermercado();
            Assert.True(supermercado.IdSupermercado > 0);
        }
    }
}
