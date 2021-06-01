using MesaCheia.Domain;
using MesaCheia.Test.Util;
using Xunit;

namespace MesaCheia.Test
{
    public class DoadorTest
    {
        [Fact]
        public void Doador_instancia()
        {
            Doador doador = InstanciasClasses.ObterInstanciaDoador();
            Assert.IsType<Doador>(doador);
        }
        [Fact]
        public void Doador_instancia_direto()
        {
            Doador doador = Doador.Create(InstanciasClasses.DOADOR_NOME, InstanciasClasses.DOADOR_TELEFONE, InstanciasClasses.DOADOR_CPF, InstanciasClasses.DOADOR_ENDERECO, InstanciasClasses.DOADOR_NUMERO, InstanciasClasses.DOADOR_CIDADE, InstanciasClasses.DOADOR_ESTADO, InstanciasClasses.DOADOR_EMAIL);
            Assert.IsType<Doador>(doador);
        }
        [Fact]
        public void Doador_validacpf_valido()
        {
            bool cpfValido = Doador.ValidarCpf(InstanciasClasses.DOADOR_CPF);
            Assert.True(cpfValido);
        }
        [Fact]
        public void Doador_validacpf_invalido()
        {
            string cpf = "12345678912";
            bool cpfValido = Doador.ValidarCpf(cpf);
            Assert.False(cpfValido);
        }
        [Fact]
        public void Doador_excluirconta()
        {
            Doador doador = InstanciasClasses.ObterInstanciaDoador();
            doador.ExcluirConta();

            Assert.False(doador.Ativo);
        }
        [Fact]
        public void Doador_iddoador_gerado()
        {
            Doador doador = InstanciasClasses.ObterInstanciaDoador();

            Assert.True(doador.IdDoador > 0);
        }
        [Fact]
        public void Doador_alterardados_todos()
        {
            string nome = "Teste333";
            string telefone = "88-9999-4444";
            string cpf = "31359332022";
            string endereco = "Rua do mau";
            int numero = 2;
            string cidade = "Sabará";
            string estado = "Rio de Janeiro";
            string email = "teste@uol.com.br";

            Doador doador = InstanciasClasses.ObterInstanciaDoador();
            doador.AlterarDados(nome, telefone, cpf, endereco, numero, cidade, estado, email);

            Assert.Equal(nome, doador.Nome);
            Assert.Equal(telefone, doador.Telefone);
            Assert.Equal(cpf, doador.CPF);
            Assert.Equal(endereco, doador.Endereco);
            Assert.Equal(numero, doador.Numero);
            Assert.Equal(cidade, doador.Cidade);
            Assert.Equal(estado, doador.Estado);
            Assert.Equal(email, doador.Email);
        }
        [Fact]
        public void Doador_usuariogerado()
        {
            Doador doador = InstanciasClasses.ObterInstanciaDoador();
            Assert.Equal(doador.Usuario, doador.CPF);
        }
    }
}
