using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaPrincipal
{
    class Banco
    {
        SqlConnection conexaoSQL =  null;
        MySqlConnection conexaoMysql = null;

        private string servidor;
        private string banco;
        private string usuario;
        private string senha;


        public Banco(string servidor, string banco, string usuario, string senha)
        {
            this.servidor = servidor;
            this.banco = banco;
            this.usuario = usuario;
            this.senha = senha;
        }
        public void conectaSQL()
        {
            try
            {
                conexaoSQL = new SqlConnection("Data Source=" + servidor + "; Initial Catalog=" + banco + "; User id=" + usuario + "; Password=" + senha + ";");
                conexaoSQL.Open();

                MessageBox.Show("Conexão ok");
            }
            catch
            {
                MessageBox.Show("Erro ao conectar no banco de dados.");
            }

        }
        public void conectaMysql(string servidor, string banco, string usuario, string senha)
        {
            try
            {
                conexaoMysql = new MySqlConnection("Data Source=" + servidor + "; Initial Catalog=" + banco + "; User id=" + usuario + "; Password=" + senha + ";");
                conexaoMysql.Open();

                MessageBox.Show("Conexão ok");
            }
            catch
            {
                MessageBox.Show("Erro ao conectar no banco de dados.");
            }
        }

         
    }
}
