using System;

namespace MesaCheia.Domain
{
    public class Doador
    {
        #region Properties
        private int idDoador;
        private string nome;
        private string telefone;
        private string cpf;
        private string endereco;
        private int numero;
        private string cidade;
        private string estado;
        private string email;
        private string usuario;
        private bool ativo;
        #endregion

        #region Get/Set Properties
        public int IdDoador
        {
            get { return idDoador; }
            private set { idDoador = value; }
        }
        public string Nome
        {
            get { return nome; }
            private set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            private set { telefone = value; }
        }
        public string CPF
        {
            get { return cpf; }
            private set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            private set { endereco = value; }
        }
        public int Numero
        {
            get { return numero; }
            private set { numero = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            private set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            private set { estado = value; }
        }
        public string Email
        {
            get { return email; }
            private set { email = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            private set { usuario = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            private set { ativo = value; }
        }
        #endregion

        /// <summary>
        /// Os campos IdDoador, Ativo e Usuário não podem ser alterado por meio deste método.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        /// <param name="endereco"></param>
        /// <param name="numero"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        public void AlterarDados(string nome, string telefone, string cpf, string endereco, int numero, string cidade, string estado, string email)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Endereco = endereco;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Email = email;
        }

        public void ExcluirConta()
        {
            Ativo = false;
        }

        public static bool ValidarCpf(string cpf)
        {
            return Util.CpfIsValid(cpf);
        }

        /// <summary>
        /// Criando Doador. O usuário é gerado basedo em documento. A senha é gerada aleatoriamente.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        /// <param name="endereco"></param>
        /// <param name="numero"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Doador Create(string nome, string telefone, string cpf, string endereco, int numero, string cidade, string estado, string email)
        {
            //Gerando IdDoador randômico
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000); //for ints

            //Definindo usuário como CPF (documento)
            string usuario = cpf;

            Doador doador = new Doador()
            {
                IdDoador = numeroAleatorio,
                Nome = nome,
                Telefone = telefone,
                CPF = cpf,
                Endereco = endereco,
                Numero = numero,
                Cidade = cidade,
                Estado = estado,
                Email = email,
                Usuario = usuario,
                Ativo = true
            };
            //Criando usuário
            _ = Login.Create(usuario);

            return doador;
        }

    }
}
