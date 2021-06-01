using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaCheia.Domain
{
    public class Supermercado
    {
        #region Properties
        private int idSupermercado;
        private string razaoSocial;
        private string telefone;
        private string cnpj;
        private string endereco;
        private int numero;
        private string cidade;
        private string estado;
        private string email;
        private string usuario;
        private bool ativo;
        #endregion

        #region Get/Set Properties
        public int IdSupermercado
        {
            get { return idSupermercado; }
            private set { idSupermercado = value; }
        }
        public string RazaoSocial
        {
            get { return razaoSocial; }
            private set { razaoSocial = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            private set { telefone = value; }
        }
        public string CNPJ
        {
            get { return cnpj; }
            private set { cnpj = value; }
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
        /// Os campos IdSupermercado, Usuario e Ativo não podem ser aalterados por meio deste método.
        /// </summary>
        /// <param name="razaoSocial"></param>
        /// <param name="telefone"></param>
        /// <param name="cnpj"></param>
        /// <param name="endereco"></param>
        /// <param name="numero"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        public void AlterarDados(string razaoSocial, string telefone, string cnpj, string endereco, int numero, string cidade, string estado, string email)
        {
            RazaoSocial = razaoSocial;
            Telefone = telefone;
            CNPJ = cnpj;
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

        public static bool ValidarCnpj(string cnpj)
        {
            return Util.CnpjIsValid(cnpj);
        }

        /// <summary>
        /// Criando Supermercado. O usuário é gerado basedo em documento. A senha é gerada aleatoriamente.
        /// </summary>
        /// <param name="razaosocial"></param>
        /// <param name="telefone"></param>
        /// <param name="cnpj"></param>
        /// <param name="endereco"></param>
        /// <param name="numero"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Supermercado Create(string razaosocial, string telefone, string cnpj, string endereco, int numero, string cidade, string estado, string email)
        {
            //Gerando IdDoador randômico
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 10000); //for ints

            //Definindo usuário como CNPJ (documento)
            string usuario = cnpj;

            Supermercado supermercado = new Supermercado()
            {
                IdSupermercado = numeroAleatorio,
                RazaoSocial = razaosocial,
                Telefone = telefone,
                CNPJ = cnpj,
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

            return supermercado;
        }
    }
}
