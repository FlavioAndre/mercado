using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace Mercado.Util
{
    public sealed class Conexao
    {
        private static readonly Conexao instance = new Conexao();
        private Conexao() { }
        public static Conexao Instance
        {
            get
            {
                return instance;
            }
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private string banco;

        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        private OleDbConnection connection;

        public OleDbConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        private OleDbCommand cmd;

        public OleDbCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }


        public string StringConexao
        {
            get { return String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", this.Banco, this.Usuario, this.Senha);  }
        }

        
        public void Open()
        {
            string conexao = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", this.Banco, this.Usuario, this.Senha);
            try
            {
                this.Connection = new OleDbConnection(conexao);

                /*OleDbCommand cmdDB = connection.CreateCommand();
                cmdDB.CommandTimeout = 0;
                this.Cmd = (OleDbCommand)cmdDB;
                this.Cmd.Connection.Open();*/
               // this.Connection.Open();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Close()
        {
            this.Connection.Close();
            this.Connection.Dispose();
        }

    }
}
