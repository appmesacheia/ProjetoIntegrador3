using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaCheia.Domain
{
    public class Receptor
    {
        #region Properties
        private int idReceptor;
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
        private decimal renda;
        #endregion

        #region Get/Set Properties
        public int IdReceptor
        {
            get { return idReceptor; }
            private set { idReceptor = value; }
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
        public decimal Renda
        {
            get { return renda; }
            private set { renda = value; }
        }
        #endregion

        /// <summary>
        /// Os campos IdReceptor, usuario, ativo  e renda não podem ser alterados
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        /// <param name="endereco"></param>
        /// <param name="numero"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        public void AlterarDados(string nome, string telefone, string cpf, string endereco, int numero, string cidade, string estado, string email, decimal renda)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Endereco = endereco;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Email = email;
            Renda = renda;
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
        /// Criando Receptor. O usuário é gerado basedo em documento. A senha é gerada aleatoriamente.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        /// <param name="endereco"></param>
        /// <param name="numero"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        /// <param name="renda"></param>
        /// <returns></returns>
        public static Receptor Create(string nome, string telefone, string cpf, string endereco, int numero, string cidade, string estado, string email, decimal renda)
        {
            //Gerando IdReceptor randômico
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000); //for ints

            //Definindo usuário como CPF (documento)
            string usuario = cpf;

            Receptor receptor = new Receptor()
            {
                IdReceptor = numeroAleatorio,
                Nome = nome,
                Telefone = telefone,
                CPF = cpf,
                Endereco = endereco,
                Numero = numero,
                Cidade = cidade,
                Estado = estado,
                Email = email,
                Usuario = usuario,
                Ativo = true,
                Renda = renda
            };
            //Criando usuário
            _ = Login.Create(usuario);

            return receptor;
        }
    }
}
