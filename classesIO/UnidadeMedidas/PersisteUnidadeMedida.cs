using System;
using System.Collections.Generic;
using System.Text;
using Mercado.Util;
using System.Data.OleDb;


namespace Mercado.classesIO.UnidadeMedidas
{
    class PersisteUnidadeMedida
    {
        public static ListaUnidadeMedida loadUnidadeMedidas()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,abreviatura,descricao from unidadeMedida order by descricao", conn))
                    {
                        conn.Open();
                        ListaUnidadeMedida lista = new ListaUnidadeMedida();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                UnidadeMedida unidadeMedida = new UnidadeMedida();
                                unidadeMedida.Codigo = (int)dr["ID"];
                                unidadeMedida.Descricao = (String)dr["descricao"];
                                unidadeMedida.Abreviatura = (String)dr["abreviatura"];
                                lista.addUnidadeMedida(unidadeMedida);
                            }
                        }
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar unidadeMedida " + ex.Message);
            }
        }

        public static UnidadeMedida selectUnidadeMedida(int codigo)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand command = new OleDbCommand("Select id,abreviatura,descricao from unidadeMedida Where id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", codigo);
                        conn.Open();
                        UnidadeMedida unidadeMedida = new UnidadeMedida();
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                unidadeMedida.Codigo = (int)dr["ID"];
                                unidadeMedida.Descricao = (String)dr["descricao"];
                                unidadeMedida.Abreviatura = (String)dr["abreviatura"];
                            }
                        }
                        return unidadeMedida;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar unidadeMedida " + ex.Message);
            }
        }
        public static void inserirUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            try
            {
                String sql = "INSERT INTO unidadeMedida (abreviatura,descricao) VALUES (@abreviatura,@descricao)";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@abreviatura", unidadeMedida.Abreviatura);
                        cmd.Parameters.AddWithValue("@descricao", unidadeMedida.Descricao);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir unidadeMedida " + ex.Message);
            }
        }

        public static void updateUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            try
            {
                String sql = "UPDATE unidadeMedida SET descricao= @descricao,abreviatura =@abreviatura WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@descricao", unidadeMedida.Descricao);
                        cmd.Parameters.AddWithValue("@abreviatura", unidadeMedida.Abreviatura);
                        cmd.Parameters.AddWithValue("@id", unidadeMedida.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar unidadeMedida " + ex.Message);
            }
        }

        public static void deleteUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            try
            {
                String sql = "DELETE FROM unidadeMedida WHERE id = @id ";
                using (OleDbConnection con = new OleDbConnection(Conexao.Instance.StringConexao))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", unidadeMedida.Codigo);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir unidadeMedida " + ex.Message);
            }
        }



    }
}
