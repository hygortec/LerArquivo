using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TelaPrincipal
{
    class Banco
    {
        SqlConnection conexao =  null;  

        public Banco(string servidor, string banco, string usuario, string senha)
        {
            try
            {
                conexao = new SqlConnection("Data Source=" + servidor + "; Initial Catalog=" + banco + "; User id=" + usuario + "; Password=" + senha + ";");
                conexao.Open();
                
                MessageBox.Show("Conexão ok");
            }
            catch {
                MessageBox.Show("Erro ao conectar no banco de dados.");
            }          

        }

         
    }
}
