using MesaCheia.Domain;
using System;

namespace MesaCheia.Test.Util
{
    public static class InstanciasClasses
    {
        #region Variáveis Login
        public static string USUARIO_LOGIN { get; } = "Teste123";
        #endregion
        #region Variáveis Receptor
        public static string RECEPTOR_NOME { get; } = "Teste222";
        public static string RECEPTOR_TELEFONE { get; } = "55-4444-3333";
        public static string RECEPTOR_CPF { get; } = "18688388032";
        public static string RECEPTOR_ENDERECO { get; } = "Rua clara";
        public static int RECEPTOR_NUMERO { get; } = 1;
        public static string RECEPTOR_CIDADE { get; } = "Belo Horizonte";
        public static string RECEPTOR_ESTADO { get; } = "Minas Gerais";
        public static string RECEPTOR_EMAIL { get; } = "teste@outlook.com";
        public static decimal RECEPTOR_RENDA { get; } = 10.32m;
        #endregion
        #region Variaveis Doador
        public static string DOADOR_NOME { get; } = "Teste987";
        public static string DOADOR_TELEFONE { get; } = "21-5454-5454";
        public static string DOADOR_CPF { get; } = "57671663077";
        public static string DOADOR_ENDERECO { get; } = "Rua do bem";
        public static int DOADOR_NUMERO { get; } = 1;
        public static string DOADOR_CIDADE { get; } = "Belo Horizonte";
        public static string DOADOR_ESTADO { get; } = "Minas Gerais";
        public static string DOADOR_EMAIL { get; } = "teste@globo.com";
        #endregion
        #region Variáveis Supermercado
        public static string SUPERMERCADO_RAZAOSOCIAL { get; } = "Teste123";
        public static string SUPERMERCADO_TELEFONE { get; } = "31-99999-9999";
        public static string SUPERMERCADO_CNPJ { get; } = "24230790000160";
        public static string SUPERMERCADO_ENDERECO { get; } = "Rua bem me quer";
        public static int SUPERMERCADO_NUMERO { get; } = 1;
        public static string SUPERMERCADO_CIDADE { get; } = "BELO HORIZONTE";
        public static string SUPERMERCADO_ESTADO { get; } = "MINAS GERAIS";
        public static string SUPERMERCADO_EMAIL { get; } = "teste@gmail.com";
        #endregion
        #region Variáveis Compra para Doacao
        public static string COMPRA_FORMAPAGAMENTO { get; } = "debito";
        public static DateTime COMPRA_DATA { get; } = DateTime.Now;
        public static string COMPRA_COMENTARIO { get; } = "este é um teste instancia classes";
        public static int COMPRA_RECIBO { get; } = 12345;
        #endregion
        #region Estoque
        public static int ESTOQUE_IDESTOQUE { get; } = 1234;
        public static string ESTOQUE_PRODUTO { get; } = "Cesta";
        public static string ESTOQUE_QUANTIDADE { get; } = "10 unidades";
        public static decimal ESTOQUE_VALOR { get; } = 50.0m;
        public static DateTime ESTOQUE_DATADISPONIVEL { get; } = DateTime.Now.AddDays(5);
        public static DateTime ESTOQUE_VALIDADE { get; } = DateTime.Now.AddDays(365);
        public static string ESTOQUE_LOCALRETIRADA { get; } = "Rua bem me quer, 12, Belo Horizonte";
        public static string ESTOQUE_HORARETIRADA { get; } = "12:00";
        #endregion
        #region Variáveis Doacao
        public static DateTime DOACAO_DATADOACAO { get; } = DateTime.Now.AddDays(7);
        public static DateTime DOACAO_DATARETIRADA { get; } = DateTime.Now.AddDays(6);
        #endregion
        public static Login ObterInstanciaLogin()
        {
            return Login.Create(USUARIO_LOGIN);
        }

        public static Receptor ObterInstanciaReceptor()
        {
            return Receptor.Create(RECEPTOR_NOME, RECEPTOR_TELEFONE, RECEPTOR_CPF, RECEPTOR_ENDERECO, RECEPTOR_NUMERO, RECEPTOR_CIDADE, RECEPTOR_ESTADO, RECEPTOR_EMAIL, RECEPTOR_RENDA);
        }
        public static Supermercado ObterInstanciaSupermercado()
        {
            return Supermercado.Create(SUPERMERCADO_RAZAOSOCIAL, SUPERMERCADO_TELEFONE, SUPERMERCADO_CNPJ, SUPERMERCADO_ENDERECO, SUPERMERCADO_NUMERO, SUPERMERCADO_CIDADE, SUPERMERCADO_ESTADO, SUPERMERCADO_EMAIL);
        }
        public static Doador ObterInstanciaDoador()
        {
            return Doador.Create(DOADOR_NOME, DOADOR_TELEFONE, DOADOR_CPF, DOADOR_ENDERECO, DOADOR_NUMERO, DOADOR_CIDADE, DOADOR_ESTADO, DOADOR_EMAIL);
        }

        public static Estoque ObterInstanciaEstoque()
        {
            Supermercado supermercado = ObterInstanciaSupermercado();

            return Estoque.Create(ESTOQUE_PRODUTO, supermercado.IdSupermercado, ESTOQUE_QUANTIDADE, ESTOQUE_VALOR, ESTOQUE_DATADISPONIVEL, ESTOQUE_VALIDADE, ESTOQUE_LOCALRETIRADA, ESTOQUE_HORARETIRADA);
        }

        public static CompraDoacao ObterInstanciaCompraDoacao()
        {
            Doador doador = ObterInstanciaDoador();
            Estoque estoque = ObterInstanciaEstoque();

            return CompraDoacao.Create(doador.IdDoador, estoque.IdEstoque, COMPRA_FORMAPAGAMENTO, COMPRA_DATA, COMPRA_COMENTARIO, COMPRA_RECIBO);
        }

        public static Doacao ObterInstanciaDoacao()
        {
            CompraDoacao compraDoacao = ObterInstanciaCompraDoacao();
            Receptor receptor = ObterInstanciaReceptor();

            return Doacao.Create(compraDoacao.IdCompraDoacao, receptor.IdReceptor, DOACAO_DATADOACAO, DOACAO_DATARETIRADA);
        }
    }
}
