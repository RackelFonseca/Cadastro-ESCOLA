using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula7._1
{
    public partial class FRESCOLA : Form
    {
        public FRESCOLA()
        {
            InitializeComponent();
        }
       
         
         int acao;
         int id;

        private void statusInicio()
        {
            GBDESCRIÇAO.Enabled = true;
            bntgravar.Enabled = true;
            bntalterar.Enabled = true;
            bntdeletar.Enabled = true;
            BNTSAIR.Enabled = true;
        }
       
     
        private void FRESCOLA_Load(object sender, EventArgs e)
        {
            //this.agendaTableAdapter.Fill(this.agendaDataSet.Agenda);
            statusInicio();
            carregaGrid();
        }


        //GRAVAR
        private void bntgravar_Click(object sender, EventArgs e)
        {
            if (TXTNOME.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
                TXTNOME.Focus();
                return;

            }

            if (CMBSTATUS.Text == "")
            {
                MessageBox.Show("Preencha o campo Status");
                CMBSTATUS.Focus();
                return;

            }
            if (txtmatricula.Text == "")
            {
                MessageBox.Show("Preencha o campo Matricula");
                txtmatricula.Focus();
                return;

            }

            if (txtcurso.Text == "")
            {
                MessageBox.Show("Preencha o campo Curso");
                txtcurso.Focus();
                return;

            }

            if (maskcpf.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF");
                maskcpf.Focus();
                return;

            }
            if (maskRG.Text == "")
            {
                MessageBox.Show("Preencha o campo RG");
                maskRG.Focus();
                return;

            }
            if (maskData.Text == "")
            {
                MessageBox.Show("Preencha o campo DATA");
                maskData.Focus();
                return;

            }

            if (acao == 0)
            {

                Gravarregistro();
            }
            else if (acao == 1)
            {

                atualizaRegitro();
            }

            carregaGrid();//onde vai aparecer a lista
          //  TXTNOME.Text = "";
          //  TXTcodigo.Text = "";
          //  CMBSTATUS.Text = "";
          //  txtcurso.Text = "";
          //  txtemail.Text = "";
          //  txtmatricula.Text = "";
          //  maskcpf.Text = "";
          //  maskRG.Text = "";
          //  maskData.Text = "";

            TXTNOME.Focus();
            statusInicio();//volta no inicio

        }

        private void atualizaRegitro()
        {
            if (MessageBox.Show("Deseja realmente alterar?", "Mensagem do sistema",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                
                try
                {
                    if (id <= 0)
                    {
                        MessageBox.Show("Aluno nao encontrada");
                        return;
                    }

                    conexao.fecharConexao();
                    string sql = "UPDATE Agenda SET Nome=@Nome,RG=@RG,CPF=@CPF,Data_Nascimento=@Data_Nascimento,Status=@Status,Matricula=@Matricula,Email=@Email,Curso= @Curso WHERE id_aluno = @id";
                    
                    conexao.abrirConexao();

                    conexao.comando = new System.Data.SqlClient.SqlCommand(sql, conexao.conecta);

                    conexao.comando.Parameters.AddWithValue("@id", id);//txtcodigo.convert
                    conexao.comando.Parameters.AddWithValue("@nome", TXTNOME.Text);//txtcodigo.convert
                    conexao.comando.Parameters.AddWithValue("@RG", maskRG.Text);
                    conexao.comando.Parameters.AddWithValue("@CPF", maskcpf.Text);
                    conexao.comando.Parameters.AddWithValue("@Data_Nascimento", maskData.Text);
                    conexao.comando.Parameters.AddWithValue("@Status", CMBSTATUS.Text);
                    conexao.comando.Parameters.AddWithValue("@Email", txtemail.Text);
                    conexao.comando.Parameters.AddWithValue("@Matricula", txtmatricula.Text);
                    conexao.comando.Parameters.AddWithValue("@Curso", txtcurso.Text);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
        
            
    }



        private void Gravarregistro()
        {


            try
            {
                conexao.fecharConexao();

               // string sql = "INSERT INTO Agenda (Nome,RG,CPF,Data_Nascimento,Status,Email,Matricula,Curso) VALUES (@Nome,@RG,@" +
                  // "@CPF,@Data_Nascimento,@Status,@Matricula,@Email,@Curso)";

                string sql = "INSERT INTO Agenda (" +
                                    " Nome," +
                                    " RG," +
                                    " CPF," +
                                    " Data_Nascimento," +
                                    " Status," +
                                    " Email," +
                                    " Matricula," +
                                    " Curso" +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    " @Nome," +
                                    " @RG," +
                                    " @CPF," +
                                    " @Data_Nascimento," +
                                    " @Status," +
                                    " @Email," +
                                    " @Matricula," +
                                    " @Curso," +
                                    " )";



                conexao.abrirConexao();
                conexao.comando = new System.Data.SqlClient.SqlCommand(sql, conexao.conecta);


                // PARAMETROS
                conexao.comando.Parameters.AddWithValue("@id", TXTcodigo.Text);//txtcodigo.convert
                conexao.comando.Parameters.AddWithValue("@Nome", TXTNOME.Text);//txtcodigo.convert
                conexao.comando.Parameters.AddWithValue("@RG", maskRG.Text);
                conexao.comando.Parameters.AddWithValue("@CPF", maskcpf.Text);
                conexao.comando.Parameters.AddWithValue("@Data_Nascimento", maskData.Text);
                conexao.comando.Parameters.AddWithValue("@Status", CMBSTATUS.Text);
                conexao.comando.Parameters.AddWithValue("@Email", txtemail.Text);
                conexao.comando.Parameters.AddWithValue("@Matricula", txtmatricula.Text);
                conexao.comando.Parameters.AddWithValue("@Curso", txtcurso.Text);

                MessageBox.Show("Dados gravados com sucesso.");

                carregaGrid();
                statusInicio();





            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }




        // STATUS DE ALTERACAO
        private void statusAltera()
        {

            GBDESCRIÇAO.Enabled = true;
            bntgravar.Enabled = true;
            bntalterar.Enabled = false;
            BNTSAIR.Enabled = true;

            TXTNOME.Focus();


            
        }



        //alteraR

        private void bntalterar_Click(object sender, EventArgs e)
        {
            statusAltera();


            atualizaRegitro();
            carregaGrid();

          
        }

        private void bntdeletar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "DELETE FROM Agenda WHERE id_aluno = @id";
                conexao.abrirConexao();

                conexao.comando = new System.Data.SqlClient.SqlCommand(sql, conexao.conecta);

                // PARAMETROS
                conexao.comando.Parameters.AddWithValue("@id", Convert.ToInt32(TXTcodigo.Text));

                conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluido.");
                carregaGrid();

                TXTNOME.Text = "";
                CMBSTATUS.Text = "";
                maskData.Text = "";
                maskRG.Text = "";
                maskcpf.Text = "";
                txtmatricula.Text = "";
                txtemail.Text = "";
                txtcurso.Text = "";
                TXTcodigo.Text = "";

                TXTNOME.Focus();

                statusInicio();//volta ao inicio
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exlcuir registro.");
            }

        }
        //CONSULTA
        private void bntconsulta_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.fecharConexao();
                string sql = "SELECT* FROM Agenda  WHERE  0=0 AND Nome=@Nome OR CPF = @CPF";

                conexao.abrirConexao();
                conexao.comando = new System.Data.SqlClient.SqlCommand(sql, conexao.conecta);

                conexao.comando.Parameters.AddWithValue("@Nome", TXTCONSULTA.Text.Trim());//parametro
                conexao.comando.Parameters.AddWithValue("@CPF", TXTCONSULTA.Text.Trim());//parametro

                conexao.leitor = conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                //cabeçalho de minha tabela
                dt.Columns.Add("Cod", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("RG", typeof(string));
                dt.Columns.Add("CPF", typeof(string));
                dt.Columns.Add("Data_Nascimento", typeof(string));
                dt.Columns.Add("Status", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Matricula", typeof(string));
                dt.Columns.Add("Curso", typeof(string));

                while (conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    //cabeçalho de minha tabela
                    dr["Cod"] = conexao.leitor["id_aluno"].ToString();
                    dr["Nome"] = conexao.leitor["Nome"].ToString();
                    dr["RG"] = conexao.leitor["RG"].ToString();
                    dr["CPF"] = conexao.leitor["CPF"].ToString();
                    dr["Data_Nascimento"] = conexao.leitor["Data_Nascimento"].ToString();
                    dr["Status"] = conexao.leitor["Status"].ToString();
                    dr["Email"] = conexao.leitor["Email"].ToString();
                    dr["Matricula"] = conexao.leitor["Matricula"].ToString();
                    dr["Curso"] = conexao.leitor["Curso"].ToString();


                    dt.Rows.Add(dr);

                }

                GRDESCOLA.DataSource = dt;
                GRDESCOLA.Update();


            }
            catch (Exception)
            {
                throw;
            }


        }

        private void BNTSAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void GRDESCOLA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega tudo da tabela e joga para meu grid,e converte pois aqui muda
            id = Convert.ToInt32( GRDESCOLA.CurrentRow.Cells[0].Value.ToString());
            TXTcodigo.Text = GRDESCOLA.CurrentRow.Cells[1].Value.ToString();//passa para o campo
            TXTNOME.Text = GRDESCOLA.CurrentRow.Cells[2].Value.ToString();
            maskRG.Text = GRDESCOLA.CurrentRow.Cells[3].Value.ToString();
            maskcpf.Text = GRDESCOLA.CurrentRow.Cells[4].Value.ToString();
            maskData.Text = GRDESCOLA.CurrentRow.Cells[5].Value.ToString();
            CMBSTATUS.Text = GRDESCOLA.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = GRDESCOLA.CurrentRow.Cells[7].Value.ToString();
            txtmatricula.Text = GRDESCOLA.CurrentRow.Cells[8].Value.ToString();
            txtcurso.Text = GRDESCOLA.CurrentRow.Cells[9].Value.ToString();

            bntalterar.Enabled = true;
            bntdeletar.Enabled = true;
        }

        private void carregaGrid()//meu metodo
        {
            conexao.fecharConexao();
            
            string sql = "SELECT* FROM Agenda ORDER BY id_aluno";

            conexao.abrirConexao();
            conexao.comando = new System.Data.SqlClient.SqlCommand(sql, conexao.conecta);

            conexao.leitor = conexao.comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("RG", typeof(string));
            dt.Columns.Add("CPF", typeof(string));
            dt.Columns.Add("Data_Nascimento", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Matricula", typeof(string));
            dt.Columns.Add("Curso", typeof(string));


            while (conexao.leitor.Read())
            {
                DataRow dr = dt.NewRow();
                
                dr["Codigo"] = conexao.leitor["id_aluno"].ToString();
                dr["Nome"] = conexao.leitor["Nome"].ToString();
                dr["RG"] = conexao.leitor["RG"].ToString();
                dr["CPF"] = conexao.leitor["CPF"].ToString();
                dr["Data_Nascimento"] = conexao.leitor["Data_Nascimento"].ToString();
                dr["Status"] = conexao.leitor["Status"].ToString();
                dr["Email"] = conexao.leitor["Email"].ToString();
                dr["Matricula"] = conexao.leitor["Matricula"].ToString();
                dr["Curso"] = conexao.leitor["Curso"].ToString();



                dt.Rows.Add(dr);

            }

            GRDESCOLA.DataSource = dt;
            GRDESCOLA.Update();

        }

        private void BNTSAIR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
    
    
    

