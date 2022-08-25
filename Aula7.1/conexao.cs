using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula7._1
{
    class conexao
    {
     
        //DEFINIMOS UMA STRING DE CAONEXAO COM O BANCO AULA NO SQL SERVER
        public static SqlConnection conecta = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial" +
                                                                " Catalog= Agenda; Integrated Security=SSPI");

        public static SqlCommand comando;
        public static SqlDataReader leitor;

        //abrir conexao

        public static void abrirConexao()
        {
            try
            {
                conecta.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel conectar no banco de dados.");
            }
        }

        //fechar conexao
        public static void fecharConexao()
        {

            try
            {
                conecta.Close();
            }
            catch (Exception)
            {

            }

        }
    }
}
