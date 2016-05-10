using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using Mercado.Util;

namespace Mercado.classesIO.Mercados
{
    class PersisteMercado
    {
        public static ListaSuperMercado loadMercados()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,descricao from mercado order by ID", conn))
                    {
                        conn.Open();
                        ListaSuperMercado lista = new ListaSuperMercado();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                SuperMercado mercado = new SuperMercado();
                                mercado.Codigo = (int)dr["ID"];
                                mercado.Descricao = (String)dr["descricao"];
                                lista.addMercado(mercado);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar mercado " + ex.Message);
            }
        }

        public static SuperMercado selectMercado(int codigo)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,descricao from mercado Where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", codigo);
                        conn.Open();
                        SuperMercado mercado = new SuperMercado();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                mercado.Codigo = (int)dr["ID"];
                                mercado.Descricao = (String)dr["descricao"];
                            }
                        }
                        return mercado;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar mercado " + ex.Message);
            }
        }
        public static void inserirMercado(SuperMercado mercado)
        {
            try
            {
                String sql = "INSERT INTO SuperMercado (descricao) VALUES (@descricao)";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", mercado.Descricao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir mercado " + ex.Message);
            }
        }

        public static void updateMercado(SuperMercado mercado)
        {
            try
            {
                String sql = "UPDATE SuperMercado SET descricao= @descricao WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", mercado.Descricao);
                        cmd.Parameters.AddWithValue("@id", mercado.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar mercado " + ex.Message);
            }
        }

        public static void deleteMercado(SuperMercado mercado)
        {
            try
            {
                String sql = "DELETE FROM SuperMercado WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", mercado.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir mercado " + ex.Message);
            }
        }


    }
}
