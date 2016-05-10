using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using Mercado.Util;
using Mercado.classesIO.Produtos;
using Mercado.classesIO.Grupos;

namespace Mercado.classesIO.ItensListaProdutos
{
    /// <summary>
    /// Classe de Persitência dos itens de produtos da lista de itensProdutosLista
    /// </summary>
    class PersisteIntesProdutosLista
    {
        public static ListaItensProdutosLista loadItensProdutosLista()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,cod_produto,cod_lista from itensProdutosLista order by ID", conn))
                    {
                        conn.Open();
                        ListaItensProdutosLista lista = new ListaItensProdutosLista();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ItensProdutosLista itensProdutosLista = new ItensProdutosLista();
                                itensProdutosLista.Codigo = (int)dr["ID"];
                                itensProdutosLista.Cod_produto = (int)dr["cod_produto"];
                                itensProdutosLista.Cod_lista = (int)dr["cod_lista"];
                                
                                lista.addItensProduto(itensProdutosLista);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar itensProdutosLista " + ex.Message);
            }
        }

        public static ListaProdutos loadProdutosSelecionados(int cod_lista)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("SELECT produto.ID, produto.descricao, grupo.ID,grupo.descricao FROM grupo INNER JOIN (produto INNER JOIN itensProdutosLista ON produto.ID = itensProdutosLista.cod_produto) ON grupo.ID = produto.cod_grupo where cod_lista=@cod_lista order by grupo.descricao,produto.descricao", conn))
                    {
                        command.Parameters.AddWithValue("@cod_lista", cod_lista);
                        conn.Open();
                        ListaProdutos lista = new ListaProdutos();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Produto produto = new Produto();
                                produto.Codigo = (int)dr["produto.ID"];
                                produto.Descricao = (String)dr["produto.descricao"];

                                Grupo grupo = new Grupo();
                                grupo.Codigo = (int)dr["grupo.ID"];
                                grupo.Descricao = (String)dr["grupo.descricao"];
                                produto.Grupo = grupo;
                                produto.Selecionado = true;

                                lista.addProduto(produto);

                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar itensProdutosLista " + ex.Message);
            }
        }


        public static ItensProdutosLista selectItensProdutosLista(int codigo)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,cod_produto,cod_lista from itensProdutosLista Where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", codigo);
                        conn.Open();
                        ItensProdutosLista itensProdutosLista = new ItensProdutosLista();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                itensProdutosLista.Codigo = (int)dr["ID"];
                                itensProdutosLista.Cod_produto = (int)dr["cod_produto"];
                                itensProdutosLista.Cod_lista = (int)dr["cod_lista"];
                            }
                        }
                        return itensProdutosLista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar itensProdutosLista " + ex.Message);
            }
        }
        public static void inserirItensProdutosLista(ItensProdutosLista itensProdutosLista)
        {
            try
            {
                String sql = "INSERT INTO itensProdutosLista (cod_produto,cod_lista) VALUES (@cod_produto,@cod_lista)";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@cod_produto", itensProdutosLista.Cod_produto);
                        cmd.Parameters.AddWithValue("@cod_lista", itensProdutosLista.Cod_lista);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir itensProdutosLista " + ex.Message);
            }
        }

       
        public static void deleteItensProdutosLista(int codigo)
        {
            try
            {
                String sql = "DELETE FROM itensProdutosLista WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir itensProdutosLista " + ex.Message);
            }
        }

        public static void deleteProdutoItensProdutosLista(int cod_lista, int cod_prod)
        {
            try
            {
                String sql = "DELETE FROM itensProdutosLista WHERE cod_lista = @cod_lista and cod_produto = @cod_prod";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@cod_lista", cod_lista);
                        cmd.Parameters.AddWithValue("@cod_prod", cod_prod);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir itensProdutosLista " + ex.Message);
            }
        }

        public static void deleteAllItensProdutosLista(int codigo)
        {
            try
            {
                String sql = "DELETE FROM itensProdutosLista WHERE cod_lista = @codigo_lista ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@codigo_lista", codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir itensProdutosLista " + ex.Message);
            }
        }

    }
}
