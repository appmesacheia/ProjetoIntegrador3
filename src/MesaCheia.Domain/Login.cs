namespace MesaCheia.Domain
{
    public class Login
    {
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            private set { usuario = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            private set { senha = value; }
        }

        public static Login Create(string usuario)
        {
            Login login = new Login() {
                Usuario = usuario,
            };

            login.Senha = Util.GeneratePassword(6);

            return login;
        }

    }
}
