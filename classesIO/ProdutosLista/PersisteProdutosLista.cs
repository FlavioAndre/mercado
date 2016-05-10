using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using Mercado.Util;
using ListaMercados.classesIO.ProdutosLista;

namespace Mercado.classesIO.ProdutosLista
{
    class PersisteProdutosLista
    {
        public static ListaProdutosLista loadProdutosLista()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,descricao,data from produtosLista order by ID", conn))
                    {
                        conn.Open();
                        ListaProdutosLista lista = new ListaProdutosLista();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProdutoLista produtosLista = new ProdutoLista();
                                produtosLista.Codigo = (int)dr["ID"];
                                produtosLista.Descricao = (String)dr["descricao"];
                                produtosLista.Data = (DateTime)dr["data"];
                                lista.addListaMercados(produtosLista);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar produtosLista " + ex.Message);
            }
        }

        public static ProdutoLista selectProdutoLista(int codigo)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,descricao,data from produtosLista Where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", codigo);
                        conn.Open();
                        ProdutoLista produtosLista = new ProdutoLista();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                produtosLista.Codigo = (int)dr["ID"];
                                produtosLista.Descricao = (String)dr["descricao"];
                                produtosLista.Data = (DateTime)dr["data"];
                            }
                        }
                        return produtosLista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar mercado " + ex.Message);
            }
        }
        public static void inserirProdutoLista(ProdutoLista produtosLista)
        {
            try
            {
                String sql = "INSERT INTO produtosLista (descricao,data) VALUES (@descricao,@data)";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", produtosLista.Descricao);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now.Date);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir produtosLista " + ex.Message);
            }
        }

        public static void updateProdutoLista(ProdutoLista produtosLista)
        {
            try
            {
                String sql = "UPDATE produtosLista SET descricao= @descricao WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", produtosLista.Descricao);
                        cmd.Parameters.AddWithValue("@id", produtosLista.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar produtosLista " + ex.Message);
            }
        }

        public static void deleteProdutoLista(ProdutoLista produtosLista)
        {
            try
            {
                String sql = "DELETE FROM produtosLista WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", produtosLista.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir produtosLista " + ex.Message);
            }
        }


    }
}
