using MesaCheia.Domain;
using MesaCheia.Test.Util;
using Xunit;

namespace MesaCheia.Test
{
    public class ReceptorTest
    {
        [Fact]
        public void Receptor_instancia()
        {
            Receptor receptor = InstanciasClasses.ObterInstanciaReceptor();
            Assert.IsType<Receptor>(receptor);
        }
        [Fact]
        public void Receptor_instancia_direto()
        {
            Receptor receptor = Receptor.Create(InstanciasClasses.RECEPTOR_NOME, InstanciasClasses.RECEPTOR_TELEFONE, InstanciasClasses.RECEPTOR_CPF, InstanciasClasses.RECEPTOR_ENDERECO, InstanciasClasses.RECEPTOR_NUMERO, InstanciasClasses.RECEPTOR_CIDADE, InstanciasClasses.RECEPTOR_ESTADO, InstanciasClasses.RECEPTOR_EMAIL, InstanciasClasses.RECEPTOR_RENDA);
            Assert.IsType<Receptor>(receptor);
        }
        [Fact]
        public void Receptor_validarcpf_valido()
        {
            bool cpfValido = Receptor.ValidarCpf(InstanciasClasses.RECEPTOR_CPF);
            Assert.True(cpfValido);

        }
        [Fact]
        public void Receptor_validarcpf_invalido()
        {
            bool cpfValido = Receptor.ValidarCpf("12345678902");
            Assert.False(cpfValido);
        }
        [Fact]
        public void Receptor_excluirconta()
        {
            Receptor receptor = InstanciasClasses.ObterInstanciaReceptor();
            receptor.ExcluirConta();
            Assert.False(receptor.Ativo);
        }
        [Fact]
        public void Receptor_alterardados()
        {
            string nome = "Teste565";
            string telefone = "11-2222-3333";
            string cpf = "66735956044";
            string endereco = "Rua escura";
            int numero = 2;
            string cidade = "Tiradentes";
            string estado = "Brasilia";
            string email = "teste@terra.com.br";
            decimal renda = 23.67m;

            Receptor receptor = InstanciasClasses.ObterInstanciaReceptor();
            receptor.AlterarDados(nome, telefone, cpf, endereco, numero, cidade, estado, email, renda);
            Assert.Equal(nome, receptor.Nome);
            Assert.Equal(telefone, receptor.Telefone);
            Assert.Equal(cpf, receptor.CPF);
            Assert.Equal(endereco, receptor.Endereco);
            Assert.Equal(numero, receptor.Numero);
            Assert.Equal(cidade, receptor.Cidade);
            Assert.Equal(estado, receptor.Estado);
            Assert.Equal(email, receptor.Email);
            Assert.Equal(renda, receptor.Renda);
        }
        [Fact]
        public void Receptor_usuariogerado()
        {
            Receptor receptor = InstanciasClasses.ObterInstanciaReceptor();
            Assert.Equal(receptor.Usuario, receptor.CPF);
        }
        [Fact]
        public void Receptor_idreceptor_gerado()
        {
            Receptor receptor = InstanciasClasses.ObterInstanciaReceptor();
            Assert.True(receptor.IdReceptor > 0);
        }

    }
}
