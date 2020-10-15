using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace _17570
{
    class Global
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;

        public static void Conectar()
        {
            //Conecta com o server
            Conexao = new MySqlConnection("server=localhost;" +
                "uid=root;" +
                "pwd=;" +
                "SslMode=none;" +
                "charset=utf8");

            Conexao.Open();

            //Cria e usa o banco de dados
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_estoque;" +
                "USE bd_estoque", Conexao);
            Comando.ExecuteNonQuery();

            //Cria uma tabela com respectivos campos e tipos de dados
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS categorias(" +
                "id integer auto_increment primary key, " +
                "descricao char(30))", Conexao);
            //Executa a criação da tabela
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS cidades(" +
                "id integer auto_increment primary key, " +
                "nome char(40), " +
                "uf char(2))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS usuarios(" +
                "id integer auto_increment primary key, " +
                "nome char(40), " +
                "senha char(20), " +
                "administrador bool)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes(" +
                "id integer auto_increment primary key, " +
                "id_cidade int(11), " +
                "nome char(40), " +
                "endereco char(40), " +
                "bairro char(30), " +
                "cpf char(14), " +
                "rg char(12), " +
                "fone char(14), " +
                "celular char(14), " +
                "email varchar(50), " +
                "renda decimal(10,2), " +
                "data_nasc date, " +
                "foto varchar(100), " +
                "bloqueado tinyint(1))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS fornecedores(" +
                "id integer auto_increment primary key, " +
                "razao_social char(40), " +
                "fantasia char(30), " +
                "endereco char(40), " +
                "bairro char(30), " +
                "id_cidade int(11), " +
                "cnpj char(18), " +
                "ie char(15), " +
                "fone char(14), " +
                "contato char(40), " +
                "email varchar(60))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS produtos(" +
                "id integer auto_increment primary key, " +
                "descricao char(40), " +
                "codigoBarra char(14), " +
                "id_Categoria int(11), " +
                "id_Fornecedor int(11), " +
                "estoque decimal (10,3), " +
                "estoqueMinimo decimal (10,3), " +
                "valorVenda decimal(10,2), " +
                "valorCusto decimal(10,2), " +
                "foto varchar(100), " +
                "linkVideo varchar(100), " +
                "ForaLinha tinyint(1))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE table if not exists venda_det(" +
               "id integer auto_increment primary key, " +
               "id_venda integer, " +
               "id_produto integer, " +
               "qtde integer, " +
               "vlr_unit decimal(10,3))", Conexao);

            Comando = new MySqlCommand("CREATE table if not exists venda_cab(" +
                "id integer auto_increment primary key, " +
                "id_cliente integer, " +
                "data date, " +
                "total decimal(10,2), " +
                "id_vendedor integer)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE table if not exists venda_cab(" +
               "id integer auto_increment primary key, " +
               "id_cliente integer, " +
               "data date, " +
               "total decimal(10,2), " +
               "id_vendedor integer)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE table if not exists venda_det " +
                "(id integer auto_increment primary key, " +
                "id_venda integer, " +
                "id_produto integer, " +
                "qtde integer, " +
                "vlr_unit decimal(10,3))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE table if not exists contas_receber " +
                "(id integer auto_increment primary key, " +
                "id_venda integer, " +
                "id_cliente integer, " +
                "parcela integer, " +
                "data_venda date, " +
                "data_vencto date, " +
                "data_pgto date, " +
                "vlr_parcela double(10,2), " +
                "status boolean)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS caixa " +
                "(id integer auto_increment primary key, " +
                "Data date, " +
                "dinheiro decimal(10,2), " +
                "cartao decimal(10,2), " +
                "cheque decimal(10,2), " +
                "tipo tinyint)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Centro_Custo " +
                "(id integer auto_increment primary key, " +
                "descricao char(30))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Despesas " +
                "(id integer auto_increment primary key, " +
                "descricao char(30), " +
                "ID_Centro_Custo integer)", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS contas_pagar " +
                 "(id integer auto_increment primary key, " +
                 "id_despesas integer, " +
                 "nota_fiscal integer," +
                 "id_fornecedor integer, " +
                 "parcela tinyint(4), " +
                 "data_lanc date, " +
                 "data_vencto date, " +
                 "data_pgto date, " +
                 "vlr_parcela decimal(10,2), " +
                 "status tinyint(1))", Conexao);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        //Criação de um metodo de consulta, com uma variavel do tipo string chamada descrição
        public static DataTable ConsultarCategorias(String descricao)
        {
            //Comando de consulta no banco de dados
            Comando = new MySqlCommand("SELECT ID, Descricao Categoria " +
                "FROM categorias " +
                "where descricao like ?descricao " +
                "order by descricao", Conexao);
            //Parametro determinado para o where, basiado na variavél descrição, criada anteriormente
            Comando.Parameters.AddWithValue("?descricao", descricao + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            //Retorna datTabela, para receber os registro onde for usada (nesse projeto é no datagrid)
            return datTabela;
        }

        public static DataTable ConsultarCidades(String nome)
        {
            Comando = new MySqlCommand("SELECT ID, Nome Cidade, UF " +
                "FROM cidades " +
                "where nome like ?nome " +
                "order by nome", Conexao);
            Comando.Parameters.AddWithValue("?nome", nome + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarUsuarios(String nome)
        {
            Comando = new MySqlCommand("SELECT ID, Nome, Senha, Administrador ADM " +
                "FROM usuarios " +
                "where nome like ?nome " +
                "order by nome", Conexao);
            Comando.Parameters.AddWithValue("?nome", nome + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarClientes(String nome)
        {
            Comando = new MySqlCommand("SELECT cl.ID, cl.Nome, cl.data_nasc 'Data de Nascimento', " +
                "cl.CPF, cl.RG, cl.fone 'Telefone', cl.Celular, cl.email 'E-mail', cl.endereco 'Endereço', " +
                "cl.Bairro, cl.id_cidade, ci.Nome 'Cidade', ci.UF, cl.Renda, cl.Foto, cl.Bloqueado " +
                "FROM clientes cl " +
                "left join cidades ci on (cl.id_cidade = ci.id) " +
                "where cl.nome like ?nome " +
                "order by cl.nome", Conexao);
            Comando.Parameters.AddWithValue("?nome", nome + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarFornecedores(String razao_social)
        {
            Comando = new MySqlCommand("SELECT f.ID, f.Razao_social 'Razão Social', f.Fantasia, f.CNPJ, f.IE, f.Contato, " +
                "f.Email 'E-mail', f.Fone 'Telefone', f.Endereco 'Endereço', f.Bairro, f.id_cidade, c.Nome Cidade, c.UF " +
                "FROM fornecedores f " +
                "left join cidades c on (f.id_cidade = c.id) " +
                "where f.razao_social like ?razao_social " +
                "order by f.razao_social", Conexao);
            Comando.Parameters.AddWithValue("?razao_social", razao_social + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarProdutos(String descricao)
        {
            Comando = new MySqlCommand("SELECT p.ID, p.descricao 'Produto', p.codigoBarra 'Código de Barras', " +
                "p.id_Categoria, c.Descricao Categoria, p.id_Fornecedor, f.razao_social 'Fornecedor', " +
                "p.Estoque, p.estoqueMinimo 'Estoque Mínimo', p.valorVenda 'Valor de Venda', " +
                "p.valorCusto 'Valor de Compra', p.ForaLinha 'Fora de Linha', p.Foto, p.linkVideo 'Link do Vídeo' " +
                "FROM produtos p " +
                "left join categorias c on (p.id_categoria = c.id) " +
                "inner join fornecedores f on (p.id_fornecedor = f.id)" +
                "where p.descricao like ?descricao " +
                "order by p.descricao", Conexao);
            Comando.Parameters.AddWithValue("?descricao", descricao + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarCentroCusto(String descricao)
        {
            Comando = new MySqlCommand("SELECT ID, Descricao FROM Centro_Custo " +
                "where descricao like ?Descricao " +
                "order by descricao", Conexao);
            Comando.Parameters.AddWithValue("?Descricao", descricao + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarDespesas(String descricao)
        {
            Comando = new MySqlCommand("SELECT d.ID, d.Descricao, d.ID_Centro_Custo, cc.id, cc.Descricao 'Centro de Custo' " +
                "FROM Despesas d " +
                "inner join Centro_Custo cc on d.ID_Centro_Custo = cc.id " +
                "where d.descricao like ?Descricao " +
                "order by d.descricao", Conexao);
            Comando.Parameters.AddWithValue("?Descricao", descricao + "%");
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }

        public static DataTable ConsultarContasPagar()
        {
            Comando = new MySqlCommand("select cp.id, cp.id_despesas, d.Descricao, cp.id_fornecedor, f.razao_social Razao, " +
                "cp.Parcela, cp.data_lanc Lancamento, cp.data_vencto Vencimento, cp.data_pgto Pagamento, cp.vlr_parcela Valor, cp.Status " +
                "from contas_pagar cp " +
                "inner join despesas d on d.id = cp.id_despesas " +
                "inner join fornecedores f on f.id = cp.id_fornecedor " +
                "order by cp.id_despesas, cp.id_fornecedor, cp.Parcela", Conexao);
            Adaptador = new MySqlDataAdapter(Comando);
            Adaptador.Fill(datTabela = new DataTable());
            return datTabela;
        }
    }
}