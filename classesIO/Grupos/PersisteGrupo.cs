using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using Mercado.Util;

namespace Mercado.classesIO.Grupos
{
    class PersisteGrupo
    {
        public static ListaGrupos loadGrupos()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,descricao from grupo order by ID", conn))
                    {
                        conn.Open();
                        ListaGrupos lista = new ListaGrupos();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Grupo grupo = new Grupo();
                                grupo.Codigo = (int)dr["ID"];
                                grupo.Descricao = (String)dr["descricao"];
                                lista.addGrupo(grupo);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar grupo " + ex.Message);
            }
        }

        public static Grupo selectGrupo(int codigo)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,descricao from grupo Where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", codigo);
                        conn.Open();
                        Grupo grupo = new Grupo();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                grupo.Codigo = (int)dr["ID"];
                                grupo.Descricao = (String)dr["descricao"];
                            }
                        }
                        return grupo;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar grupo " + ex.Message);
            }
        }
        public static void inserirGrupo(Grupo grupo)
        {
            try
            {
                String sql = "INSERT INTO Grupo (descricao) VALUES (@descricao)";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", grupo.Descricao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir grupo " + ex.Message);
            }
        }

        public static void updateGrupo(Grupo grupo)
        {
            try
            {
                String sql = "UPDATE Grupo SET descricao= @descricao WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", grupo.Descricao);
                        cmd.Parameters.AddWithValue("@id", grupo.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar grupo " + ex.Message);
            }
        }

        public static void deleteGrupo(Grupo grupo)
        {
            try
            {
                String sql = "DELETE FROM Grupo WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", grupo.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir grupo " + ex.Message);
            }
        }

    }
}
