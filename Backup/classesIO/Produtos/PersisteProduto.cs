using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using Mercado.Util;
using Mercado.classesIO.Grupos;

namespace Mercado.classesIO.Produtos
{
    class PersisteProduto
    {
        public static ListaProdutos loadProdutos()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select produto.ID,produto.descricao,produto.cod_grupo,grupo.descricao from grupo INNER JOIN produto ON grupo.ID = produto.cod_grupo order by grupo.descricao,produto.descricao", conn))
                    {
                        conn.Open();
                        ListaProdutos lista = new ListaProdutos();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Produto produto = new Produto();
                                produto.Codigo = (int)dr["ID"];
                                produto.Descricao = (String)dr["produto.descricao"];

                                Grupo grupo = new Grupo();
                                grupo.Codigo = (int)dr["cod_grupo"];
                                grupo.Descricao = (String)dr["grupo.descricao"];
                                produto.Grupo = grupo;
                                lista.addProduto(produto);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar produto " + ex.Message);
            }
        }

        public static ListaProdutos loadProdutosOrdenadosGrupoProduto()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select produto.ID,produto.descricao,produto.cod_grupo,grupo.descricao from grupo INNER JOIN produto ON grupo.ID = produto.cod_grupo order by produto.descricao,grupo.descricao", conn))
                    {
                        conn.Open();
                        ListaProdutos lista = new ListaProdutos();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Produto produto = new Produto();
                                produto.Codigo = (int)dr["ID"];
                                produto.Descricao = (String)dr["produto.descricao"];

                                Grupo grupo = new Grupo();
                                grupo.Codigo = (int)dr["cod_grupo"];
                                grupo.Descricao = (String)dr["grupo.descricao"];
                                produto.Grupo = grupo;
                                lista.addProduto(produto);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar produto " + ex.Message);
            }
        }

        public static void inserirProduto(Produto produto)
        {
            try
            {
                String sql = "INSERT INTO Produto (descricao,cod_grupo) VALUES (@descricao,@grupo)";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                        cmd.Parameters.AddWithValue("@grupo", produto.Grupo.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir produto " + ex.Message);
            }
        }

        public static void updateProduto(Produto produto)
        {
            try
            {
                String sql = "UPDATE Produto SET descricao= @descricao,cod_grupo= @grupo WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                        cmd.Parameters.AddWithValue("@grupo", produto.Grupo.Codigo);
                        cmd.Parameters.AddWithValue("@id", produto.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar produto " + ex.Message);
            }
        }

        public static void deleteProduto(Produto produto)
        {
            try
            {
                String sql = "DELETE FROM Produto WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", produto.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir produto " + ex.Message);
            }
        }

    }
}
