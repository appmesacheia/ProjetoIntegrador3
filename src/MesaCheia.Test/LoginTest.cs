using MesaCheia.Domain;
using MesaCheia.Test.Util;
using Xunit;

namespace MesaCheia.Test
{
    public class LoginTest
    {
        [Fact]
        public void Login_validar_usuario_criado()
        {
            Login loginCriado = InstanciasClasses.ObterInstanciaLogin();

            Assert.Equal(InstanciasClasses.USUARIO_LOGIN, loginCriado.Usuario);
        }
        [Fact]
        public void Login_validar_senha_gerada()
        {
            Login loginCriado = InstanciasClasses.ObterInstanciaLogin();

            Assert.Equal(6, loginCriado.Senha.Length);
        }
    }
}
