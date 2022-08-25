namespace Aula7._1
{
    partial class FRESCOLA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBLNOME = new System.Windows.Forms.Label();
            this.LBLSTATUS = new System.Windows.Forms.Label();
            this.LBLCPF = new System.Windows.Forms.Label();
            this.LBLEMAIL = new System.Windows.Forms.Label();
            this.bntgravar = new System.Windows.Forms.Button();
            this.bntalterar = new System.Windows.Forms.Button();
            this.bntdeletar = new System.Windows.Forms.Button();
            this.bntconsulta = new System.Windows.Forms.Button();
            this.GRDESCOLA = new System.Windows.Forms.DataGridView();
            this.idalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Aula7._1.AgendaDataSet();
            this.GBDESCRIÇAO = new System.Windows.Forms.GroupBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.maskcpf = new System.Windows.Forms.MaskedTextBox();
            this.maskRG = new System.Windows.Forms.MaskedTextBox();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.LBLRG = new System.Windows.Forms.Label();
            this.LBLMATRÍCULA = new System.Windows.Forms.Label();
            this.LBLCURSO = new System.Windows.Forms.Label();
            this.LBLDATA = new System.Windows.Forms.Label();
            this.CMBSTATUS = new System.Windows.Forms.ComboBox();
            this.TXTcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNOME = new System.Windows.Forms.TextBox();
            this.BNTSAIR = new System.Windows.Forms.Button();
            this.TXTCONSULTA = new System.Windows.Forms.TextBox();
            this.agendaTableAdapter = new Aula7._1.AgendaDataSetTableAdapters.AgendaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRDESCOLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            this.GBDESCRIÇAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLNOME
            // 
            this.LBLNOME.AutoSize = true;
            this.LBLNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNOME.Location = new System.Drawing.Point(14, 74);
            this.LBLNOME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNOME.Name = "LBLNOME";
            this.LBLNOME.Size = new System.Drawing.Size(45, 16);
            this.LBLNOME.TabIndex = 0;
            this.LBLNOME.Text = "Nome";
            // 
            // LBLSTATUS
            // 
            this.LBLSTATUS.AutoSize = true;
            this.LBLSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSTATUS.Location = new System.Drawing.Point(21, 118);
            this.LBLSTATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLSTATUS.Name = "LBLSTATUS";
            this.LBLSTATUS.Size = new System.Drawing.Size(45, 16);
            this.LBLSTATUS.TabIndex = 1;
            this.LBLSTATUS.Text = "Status";
            // 
            // LBLCPF
            // 
            this.LBLCPF.AutoSize = true;
            this.LBLCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCPF.Location = new System.Drawing.Point(262, 33);
            this.LBLCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCPF.Name = "LBLCPF";
            this.LBLCPF.Size = new System.Drawing.Size(34, 16);
            this.LBLCPF.TabIndex = 2;
            this.LBLCPF.Text = "CPF";
            // 
            // LBLEMAIL
            // 
            this.LBLEMAIL.AutoSize = true;
            this.LBLEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEMAIL.Location = new System.Drawing.Point(274, 171);
            this.LBLEMAIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLEMAIL.Name = "LBLEMAIL";
            this.LBLEMAIL.Size = new System.Drawing.Size(42, 16);
            this.LBLEMAIL.TabIndex = 3;
            this.LBLEMAIL.Text = "Email";
            // 
            // bntgravar
            // 
            this.bntgravar.BackColor = System.Drawing.Color.LightCoral;
            this.bntgravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntgravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntgravar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntgravar.Location = new System.Drawing.Point(649, 79);
            this.bntgravar.Margin = new System.Windows.Forms.Padding(4);
            this.bntgravar.Name = "bntgravar";
            this.bntgravar.Size = new System.Drawing.Size(128, 93);
            this.bntgravar.TabIndex = 5;
            this.bntgravar.Text = "Gravar";
            this.bntgravar.UseVisualStyleBackColor = false;
            this.bntgravar.Click += new System.EventHandler(this.bntgravar_Click);
            // 
            // bntalterar
            // 
            this.bntalterar.BackColor = System.Drawing.Color.LightCoral;
            this.bntalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntalterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntalterar.Location = new System.Drawing.Point(649, 180);
            this.bntalterar.Margin = new System.Windows.Forms.Padding(4);
            this.bntalterar.Name = "bntalterar";
            this.bntalterar.Size = new System.Drawing.Size(128, 87);
            this.bntalterar.TabIndex = 6;
            this.bntalterar.Text = "Alterar";
            this.bntalterar.UseVisualStyleBackColor = false;
            this.bntalterar.Click += new System.EventHandler(this.bntalterar_Click);
            // 
            // bntdeletar
            // 
            this.bntdeletar.BackColor = System.Drawing.Color.LightCoral;
            this.bntdeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdeletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntdeletar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bntdeletar.Location = new System.Drawing.Point(649, 275);
            this.bntdeletar.Margin = new System.Windows.Forms.Padding(4);
            this.bntdeletar.Name = "bntdeletar";
            this.bntdeletar.Size = new System.Drawing.Size(128, 90);
            this.bntdeletar.TabIndex = 7;
            this.bntdeletar.Text = "Deletar";
            this.bntdeletar.UseVisualStyleBackColor = false;
            this.bntdeletar.Click += new System.EventHandler(this.bntdeletar_Click);
            // 
            // bntconsulta
            // 
            this.bntconsulta.BackColor = System.Drawing.Color.LightCoral;
            this.bntconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntconsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntconsulta.Location = new System.Drawing.Point(457, 24);
            this.bntconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.bntconsulta.Name = "bntconsulta";
            this.bntconsulta.Size = new System.Drawing.Size(169, 29);
            this.bntconsulta.TabIndex = 8;
            this.bntconsulta.Text = "Consultar Aluno";
            this.bntconsulta.UseVisualStyleBackColor = false;
            this.bntconsulta.Click += new System.EventHandler(this.bntconsulta_Click);
            // 
            // GRDESCOLA
            // 
            this.GRDESCOLA.AutoGenerateColumns = false;
            this.GRDESCOLA.BackgroundColor = System.Drawing.Color.Brown;
            this.GRDESCOLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRDESCOLA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalunoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.GRDESCOLA.DataSource = this.agendaBindingSource;
            this.GRDESCOLA.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GRDESCOLA.Location = new System.Drawing.Point(13, 310);
            this.GRDESCOLA.Margin = new System.Windows.Forms.Padding(4);
            this.GRDESCOLA.Name = "GRDESCOLA";
            this.GRDESCOLA.Size = new System.Drawing.Size(613, 144);
            this.GRDESCOLA.TabIndex = 9;
            this.GRDESCOLA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRDESCOLA_CellDoubleClick);
            // 
            // idalunoDataGridViewTextBoxColumn
            // 
            this.idalunoDataGridViewTextBoxColumn.DataPropertyName = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.HeaderText = "id_aluno";
            this.idalunoDataGridViewTextBoxColumn.Name = "idalunoDataGridViewTextBoxColumn";
            this.idalunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GBDESCRIÇAO
            // 
            this.GBDESCRIÇAO.BackColor = System.Drawing.Color.Transparent;
            this.GBDESCRIÇAO.Controls.Add(this.txtmatricula);
            this.GBDESCRIÇAO.Controls.Add(this.txtcurso);
            this.GBDESCRIÇAO.Controls.Add(this.txtemail);
            this.GBDESCRIÇAO.Controls.Add(this.maskcpf);
            this.GBDESCRIÇAO.Controls.Add(this.maskRG);
            this.GBDESCRIÇAO.Controls.Add(this.maskData);
            this.GBDESCRIÇAO.Controls.Add(this.LBLRG);
            this.GBDESCRIÇAO.Controls.Add(this.LBLMATRÍCULA);
            this.GBDESCRIÇAO.Controls.Add(this.LBLCURSO);
            this.GBDESCRIÇAO.Controls.Add(this.LBLDATA);
            this.GBDESCRIÇAO.Controls.Add(this.CMBSTATUS);
            this.GBDESCRIÇAO.Controls.Add(this.TXTcodigo);
            this.GBDESCRIÇAO.Controls.Add(this.label1);
            this.GBDESCRIÇAO.Controls.Add(this.TXTNOME);
            this.GBDESCRIÇAO.Controls.Add(this.LBLNOME);
            this.GBDESCRIÇAO.Controls.Add(this.LBLSTATUS);
            this.GBDESCRIÇAO.Controls.Add(this.LBLCPF);
            this.GBDESCRIÇAO.Controls.Add(this.LBLEMAIL);
            this.GBDESCRIÇAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDESCRIÇAO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBDESCRIÇAO.Location = new System.Drawing.Point(13, 71);
            this.GBDESCRIÇAO.Margin = new System.Windows.Forms.Padding(4);
            this.GBDESCRIÇAO.Name = "GBDESCRIÇAO";
            this.GBDESCRIÇAO.Padding = new System.Windows.Forms.Padding(4);
            this.GBDESCRIÇAO.Size = new System.Drawing.Size(613, 220);
            this.GBDESCRIÇAO.TabIndex = 10;
            this.GBDESCRIÇAO.TabStop = false;
            this.GBDESCRIÇAO.Text = "Descrição";
            // 
            // txtmatricula
            // 
            this.txtmatricula.BackColor = System.Drawing.Color.Snow;
            this.txtmatricula.Location = new System.Drawing.Point(322, 111);
            this.txtmatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(240, 22);
            this.txtmatricula.TabIndex = 21;
            // 
            // txtcurso
            // 
            this.txtcurso.BackColor = System.Drawing.Color.Snow;
            this.txtcurso.Location = new System.Drawing.Point(64, 171);
            this.txtcurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(202, 22);
            this.txtcurso.TabIndex = 20;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Snow;
            this.txtemail.Location = new System.Drawing.Point(322, 168);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 22);
            this.txtemail.TabIndex = 19;
            // 
            // maskcpf
            // 
            this.maskcpf.BackColor = System.Drawing.Color.Snow;
            this.maskcpf.Location = new System.Drawing.Point(304, 30);
            this.maskcpf.Margin = new System.Windows.Forms.Padding(4);
            this.maskcpf.Mask = "000000000-00";
            this.maskcpf.Name = "maskcpf";
            this.maskcpf.Size = new System.Drawing.Size(105, 22);
            this.maskcpf.TabIndex = 18;
            // 
            // maskRG
            // 
            this.maskRG.BackColor = System.Drawing.Color.Snow;
            this.maskRG.Location = new System.Drawing.Point(453, 30);
            this.maskRG.Margin = new System.Windows.Forms.Padding(4);
            this.maskRG.Mask = "000000000-0";
            this.maskRG.Name = "maskRG";
            this.maskRG.Size = new System.Drawing.Size(109, 22);
            this.maskRG.TabIndex = 17;
            // 
            // maskData
            // 
            this.maskData.Location = new System.Drawing.Point(469, 71);
            this.maskData.Margin = new System.Windows.Forms.Padding(4);
            this.maskData.Mask = "00/00/0000";
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(93, 22);
            this.maskData.TabIndex = 14;
            this.maskData.ValidatingType = typeof(System.DateTime);
            // 
            // LBLRG
            // 
            this.LBLRG.AutoSize = true;
            this.LBLRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRG.Location = new System.Drawing.Point(417, 33);
            this.LBLRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLRG.Name = "LBLRG";
            this.LBLRG.Size = new System.Drawing.Size(28, 16);
            this.LBLRG.TabIndex = 16;
            this.LBLRG.Text = "RG";
            // 
            // LBLMATRÍCULA
            // 
            this.LBLMATRÍCULA.AutoSize = true;
            this.LBLMATRÍCULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMATRÍCULA.Location = new System.Drawing.Point(252, 116);
            this.LBLMATRÍCULA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLMATRÍCULA.Name = "LBLMATRÍCULA";
            this.LBLMATRÍCULA.Size = new System.Drawing.Size(62, 16);
            this.LBLMATRÍCULA.TabIndex = 15;
            this.LBLMATRÍCULA.Text = "Matrícula";
            // 
            // LBLCURSO
            // 
            this.LBLCURSO.AutoSize = true;
            this.LBLCURSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCURSO.Location = new System.Drawing.Point(16, 174);
            this.LBLCURSO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCURSO.Name = "LBLCURSO";
            this.LBLCURSO.Size = new System.Drawing.Size(43, 16);
            this.LBLCURSO.TabIndex = 14;
            this.LBLCURSO.Text = "Curso";
            // 
            // LBLDATA
            // 
            this.LBLDATA.AutoSize = true;
            this.LBLDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDATA.Location = new System.Drawing.Point(354, 74);
            this.LBLDATA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATA.Name = "LBLDATA";
            this.LBLDATA.Size = new System.Drawing.Size(116, 16);
            this.LBLDATA.TabIndex = 13;
            this.LBLDATA.Text = "Data_Nascimento";
            // 
            // CMBSTATUS
            // 
            this.CMBSTATUS.BackColor = System.Drawing.Color.Snow;
            this.CMBSTATUS.FormattingEnabled = true;
            this.CMBSTATUS.Items.AddRange(new object[] {
            "Matriculado",
            "Jubilado",
            "Trancado",
            "Transferido"});
            this.CMBSTATUS.Location = new System.Drawing.Point(63, 111);
            this.CMBSTATUS.Margin = new System.Windows.Forms.Padding(4);
            this.CMBSTATUS.Name = "CMBSTATUS";
            this.CMBSTATUS.Size = new System.Drawing.Size(181, 24);
            this.CMBSTATUS.TabIndex = 10;
            // 
            // TXTcodigo
            // 
            this.TXTcodigo.BackColor = System.Drawing.Color.Snow;
            this.TXTcodigo.Enabled = false;
            this.TXTcodigo.Location = new System.Drawing.Point(64, 30);
            this.TXTcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TXTcodigo.Name = "TXTcodigo";
            this.TXTcodigo.Size = new System.Drawing.Size(190, 22);
            this.TXTcodigo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // TXTNOME
            // 
            this.TXTNOME.BackColor = System.Drawing.Color.Snow;
            this.TXTNOME.Location = new System.Drawing.Point(63, 71);
            this.TXTNOME.Margin = new System.Windows.Forms.Padding(4);
            this.TXTNOME.Name = "TXTNOME";
            this.TXTNOME.Size = new System.Drawing.Size(283, 22);
            this.TXTNOME.TabIndex = 4;
            // 
            // BNTSAIR
            // 
            this.BNTSAIR.BackColor = System.Drawing.Color.LightCoral;
            this.BNTSAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNTSAIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BNTSAIR.Location = new System.Drawing.Point(649, 373);
            this.BNTSAIR.Margin = new System.Windows.Forms.Padding(4);
            this.BNTSAIR.Name = "BNTSAIR";
            this.BNTSAIR.Size = new System.Drawing.Size(128, 81);
            this.BNTSAIR.TabIndex = 11;
            this.BNTSAIR.Text = "Sair";
            this.BNTSAIR.UseVisualStyleBackColor = false;
            this.BNTSAIR.Click += new System.EventHandler(this.BNTSAIR_Click_1);
            // 
            // TXTCONSULTA
            // 
            this.TXTCONSULTA.BackColor = System.Drawing.Color.Snow;
            this.TXTCONSULTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCONSULTA.Location = new System.Drawing.Point(76, 24);
            this.TXTCONSULTA.Margin = new System.Windows.Forms.Padding(4);
            this.TXTCONSULTA.Name = "TXTCONSULTA";
            this.TXTCONSULTA.Size = new System.Drawing.Size(373, 29);
            this.TXTCONSULTA.TabIndex = 12;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar";
            // 
            // FRESCOLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(789, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTCONSULTA);
            this.Controls.Add(this.BNTSAIR);
            this.Controls.Add(this.GBDESCRIÇAO);
            this.Controls.Add(this.GRDESCOLA);
            this.Controls.Add(this.bntconsulta);
            this.Controls.Add(this.bntdeletar);
            this.Controls.Add(this.bntalterar);
            this.Controls.Add(this.bntgravar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRESCOLA";
            this.Text = "ESCOLA PATHULIPA";
            this.Load += new System.EventHandler(this.FRESCOLA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRDESCOLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            this.GBDESCRIÇAO.ResumeLayout(false);
            this.GBDESCRIÇAO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNOME;
        private System.Windows.Forms.Label LBLSTATUS;
        private System.Windows.Forms.Label LBLCPF;
        private System.Windows.Forms.Label LBLEMAIL;
        private System.Windows.Forms.Button bntgravar;
        private System.Windows.Forms.Button bntalterar;
        private System.Windows.Forms.Button bntdeletar;
        private System.Windows.Forms.Button bntconsulta;
        private System.Windows.Forms.DataGridView GRDESCOLA;
        private System.Windows.Forms.GroupBox GBDESCRIÇAO;
        private System.Windows.Forms.ComboBox CMBSTATUS;
        private System.Windows.Forms.TextBox TXTcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTNOME;
        private System.Windows.Forms.Button BNTSAIR;
        private System.Windows.Forms.TextBox TXTCONSULTA;
        private System.Windows.Forms.Label LBLRG;
        private System.Windows.Forms.Label LBLMATRÍCULA;
        private System.Windows.Forms.Label LBLCURSO;
        private System.Windows.Forms.Label LBLDATA;
        private System.Windows.Forms.MaskedTextBox maskData;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox maskcpf;
        private System.Windows.Forms.MaskedTextBox maskRG;
        private AgendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private AgendaDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}

