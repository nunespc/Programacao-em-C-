namespace SistemaNunesPc
{
    partial class NaturezaOperacao
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxICMS = new System.Windows.Forms.CheckBox();
            this.dataGridViewCfop = new System.Windows.Forms.DataGridView();
            this.codigo_cfop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destacaricms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cfop_consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cfop_revenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cfop_fora_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_revenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_fora_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uso_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbxUso = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCFOPConsu = new System.Windows.Forms.TextBox();
            this.btnCFOPConsu = new System.Windows.Forms.Button();
            this.btnCFOPRev = new System.Windows.Forms.Button();
            this.txtCFOPRev = new System.Windows.Forms.TextBox();
            this.btnCFOPForaEsta = new System.Windows.Forms.Button();
            this.txtCFOPForaEsta = new System.Windows.Forms.TextBox();
            this.pnCFOPRev = new System.Windows.Forms.Panel();
            this.lblCFOPRev = new System.Windows.Forms.Label();
            this.pnCFOPConsu = new System.Windows.Forms.Panel();
            this.lblCFOPConsu = new System.Windows.Forms.Label();
            this.pnCFOPForaEsta = new System.Windows.Forms.Panel();
            this.lblCFOPForaEsta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCfop)).BeginInit();
            this.pnCFOPRev.SuspendLayout();
            this.pnCFOPConsu.SuspendLayout();
            this.pnCFOPForaEsta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Uso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CFOP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(224, 33);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(482, 20);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 20);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "CFOP Fora do estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "CFOP Revenda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "CFOP Consumo:";
            // 
            // checkBoxICMS
            // 
            this.checkBoxICMS.AutoSize = true;
            this.checkBoxICMS.Location = new System.Drawing.Point(712, 35);
            this.checkBoxICMS.Name = "checkBoxICMS";
            this.checkBoxICMS.Size = new System.Drawing.Size(98, 17);
            this.checkBoxICMS.TabIndex = 28;
            this.checkBoxICMS.Text = "Destacar ICMS";
            this.checkBoxICMS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCfop
            // 
            this.dataGridViewCfop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCfop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_cfop,
            this.destacaricms,
            this.id,
            this.id_cfop_consumo,
            this.id_cfop_revenda,
            this.id_cfop_fora_estado,
            this.descricao,
            this.cfop_consumo,
            this.cfop_revenda,
            this.cfop_fora_estado,
            this.uso_,
            this.tipo_});
            this.dataGridViewCfop.Location = new System.Drawing.Point(23, 177);
            this.dataGridViewCfop.Name = "dataGridViewCfop";
            this.dataGridViewCfop.Size = new System.Drawing.Size(787, 353);
            this.dataGridViewCfop.TabIndex = 29;
            this.dataGridViewCfop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codigo_cfop
            // 
            this.codigo_cfop.DataPropertyName = "codigo_cfop";
            this.codigo_cfop.HeaderText = "Codigo";
            this.codigo_cfop.Name = "codigo_cfop";
            // 
            // destacaricms
            // 
            this.destacaricms.DataPropertyName = "destacaricms";
            this.destacaricms.HeaderText = "Destacar ICMS";
            this.destacaricms.Name = "destacaricms";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // id_cfop_consumo
            // 
            this.id_cfop_consumo.DataPropertyName = "id_cfop_consumo";
            this.id_cfop_consumo.HeaderText = "Id Cfop Consumo";
            this.id_cfop_consumo.Name = "id_cfop_consumo";
            // 
            // id_cfop_revenda
            // 
            this.id_cfop_revenda.DataPropertyName = "id_cfop_revenda";
            this.id_cfop_revenda.HeaderText = "Id Cfop Revenda";
            this.id_cfop_revenda.Name = "id_cfop_revenda";
            // 
            // id_cfop_fora_estado
            // 
            this.id_cfop_fora_estado.DataPropertyName = "id_cfop_fora_estado";
            this.id_cfop_fora_estado.HeaderText = "Id Cfop Fora Estado";
            this.id_cfop_fora_estado.Name = "id_cfop_fora_estado";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cfop_consumo
            // 
            this.cfop_consumo.DataPropertyName = "cfop_consumo";
            this.cfop_consumo.HeaderText = "CFOP Consumo";
            this.cfop_consumo.Name = "cfop_consumo";
            // 
            // cfop_revenda
            // 
            this.cfop_revenda.DataPropertyName = "cfop_revenda";
            this.cfop_revenda.HeaderText = "CFOP Revenda";
            this.cfop_revenda.Name = "cfop_revenda";
            // 
            // cfop_fora_estado
            // 
            this.cfop_fora_estado.DataPropertyName = "cfop_fora_estado";
            this.cfop_fora_estado.HeaderText = "CFOP Fora do Estado";
            this.cfop_fora_estado.Name = "cfop_fora_estado";
            // 
            // uso_
            // 
            this.uso_.DataPropertyName = "uso";
            this.uso_.HeaderText = "Uso";
            this.uso_.Name = "uso_";
            // 
            // tipo_
            // 
            this.tipo_.DataPropertyName = "tipo";
            this.tipo_.HeaderText = "Tipo";
            this.tipo_.Name = "tipo_";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_delete_48762;
            this.btnExcluir.Location = new System.Drawing.Point(466, 545);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 41);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_edit_48763;
            this.btnEditar.Location = new System.Drawing.Point(420, 545);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 41);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_add_48761;
            this.btnSalvar.Location = new System.Drawing.Point(374, 545);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalvar.Size = new System.Drawing.Size(40, 41);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_48760;
            this.btnNovo.Location = new System.Drawing.Point(328, 545);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 41);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbxUso
            // 
            this.cbxUso.AutoCompleteCustomSource.AddRange(new string[] {
            "Codigo",
            "Descrição"});
            this.cbxUso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbxUso.FormattingEnabled = true;
            this.cbxUso.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbxUso.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbxUso.Location = new System.Drawing.Point(693, 133);
            this.cbxUso.Name = "cbxUso";
            this.cbxUso.Size = new System.Drawing.Size(117, 21);
            this.cbxUso.TabIndex = 40;
            this.cbxUso.SelectedIndexChanged += new System.EventHandler(this.cbxUso_SelectedIndexChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Codigo",
            "Descrição"});
            this.cbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbxTipo.Items.AddRange(new object[] {
            "Fora do Estado",
            "Dentro do Estado"});
            this.cbxTipo.Location = new System.Drawing.Point(476, 133);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(176, 21);
            this.cbxTipo.TabIndex = 41;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Codigo",
            "Descrição"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Items.AddRange(new object[] {
            "                                    "});
            this.comboBox1.Location = new System.Drawing.Point(520, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // txtCFOPConsu
            // 
            this.txtCFOPConsu.Location = new System.Drawing.Point(110, 80);
            this.txtCFOPConsu.Name = "txtCFOPConsu";
            this.txtCFOPConsu.Size = new System.Drawing.Size(47, 20);
            this.txtCFOPConsu.TabIndex = 43;
            this.txtCFOPConsu.TextChanged += new System.EventHandler(this.txtCFOPConsumo_TextChanged);
            // 
            // btnCFOPConsu
            // 
            this.btnCFOPConsu.Location = new System.Drawing.Point(156, 80);
            this.btnCFOPConsu.Name = "btnCFOPConsu";
            this.btnCFOPConsu.Size = new System.Drawing.Size(32, 20);
            this.btnCFOPConsu.TabIndex = 44;
            this.btnCFOPConsu.Text = "...";
            this.btnCFOPConsu.UseVisualStyleBackColor = true;
            this.btnCFOPConsu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCFOPRev
            // 
            this.btnCFOPRev.Location = new System.Drawing.Point(562, 80);
            this.btnCFOPRev.Name = "btnCFOPRev";
            this.btnCFOPRev.Size = new System.Drawing.Size(32, 20);
            this.btnCFOPRev.TabIndex = 46;
            this.btnCFOPRev.Text = "...";
            this.btnCFOPRev.UseVisualStyleBackColor = true;
            this.btnCFOPRev.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCFOPRev
            // 
            this.txtCFOPRev.Location = new System.Drawing.Point(515, 80);
            this.txtCFOPRev.Name = "txtCFOPRev";
            this.txtCFOPRev.Size = new System.Drawing.Size(47, 20);
            this.txtCFOPRev.TabIndex = 45;
            this.txtCFOPRev.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // btnCFOPForaEsta
            // 
            this.btnCFOPForaEsta.Location = new System.Drawing.Point(179, 132);
            this.btnCFOPForaEsta.Name = "btnCFOPForaEsta";
            this.btnCFOPForaEsta.Size = new System.Drawing.Size(32, 20);
            this.btnCFOPForaEsta.TabIndex = 48;
            this.btnCFOPForaEsta.Text = "...";
            this.btnCFOPForaEsta.UseVisualStyleBackColor = true;
            this.btnCFOPForaEsta.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCFOPForaEsta
            // 
            this.txtCFOPForaEsta.Location = new System.Drawing.Point(133, 132);
            this.txtCFOPForaEsta.Name = "txtCFOPForaEsta";
            this.txtCFOPForaEsta.Size = new System.Drawing.Size(47, 20);
            this.txtCFOPForaEsta.TabIndex = 47;
            this.txtCFOPForaEsta.TextChanged += new System.EventHandler(this.txtCFOPForaEsta_TextChanged);
            // 
            // pnCFOPRev
            // 
            this.pnCFOPRev.BackColor = System.Drawing.Color.Silver;
            this.pnCFOPRev.Controls.Add(this.lblCFOPRev);
            this.pnCFOPRev.Location = new System.Drawing.Point(595, 80);
            this.pnCFOPRev.Name = "pnCFOPRev";
            this.pnCFOPRev.Size = new System.Drawing.Size(215, 20);
            this.pnCFOPRev.TabIndex = 50;
            // 
            // lblCFOPRev
            // 
            this.lblCFOPRev.AutoSize = true;
            this.lblCFOPRev.Location = new System.Drawing.Point(5, 3);
            this.lblCFOPRev.Name = "lblCFOPRev";
            this.lblCFOPRev.Size = new System.Drawing.Size(55, 13);
            this.lblCFOPRev.TabIndex = 1;
            this.lblCFOPRev.Text = "Descrição";
            // 
            // pnCFOPConsu
            // 
            this.pnCFOPConsu.BackColor = System.Drawing.Color.Silver;
            this.pnCFOPConsu.Controls.Add(this.lblCFOPConsu);
            this.pnCFOPConsu.Location = new System.Drawing.Point(189, 80);
            this.pnCFOPConsu.Name = "pnCFOPConsu";
            this.pnCFOPConsu.Size = new System.Drawing.Size(215, 20);
            this.pnCFOPConsu.TabIndex = 51;
            this.pnCFOPConsu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCFOPConsu_Paint);
            // 
            // lblCFOPConsu
            // 
            this.lblCFOPConsu.AutoSize = true;
            this.lblCFOPConsu.Location = new System.Drawing.Point(5, 3);
            this.lblCFOPConsu.Name = "lblCFOPConsu";
            this.lblCFOPConsu.Size = new System.Drawing.Size(55, 13);
            this.lblCFOPConsu.TabIndex = 0;
            this.lblCFOPConsu.Text = "Descrição";
            this.lblCFOPConsu.Click += new System.EventHandler(this.label9_Click);
            // 
            // pnCFOPForaEsta
            // 
            this.pnCFOPForaEsta.BackColor = System.Drawing.Color.Silver;
            this.pnCFOPForaEsta.Controls.Add(this.lblCFOPForaEsta);
            this.pnCFOPForaEsta.Location = new System.Drawing.Point(212, 132);
            this.pnCFOPForaEsta.Name = "pnCFOPForaEsta";
            this.pnCFOPForaEsta.Size = new System.Drawing.Size(215, 20);
            this.pnCFOPForaEsta.TabIndex = 52;
            // 
            // lblCFOPForaEsta
            // 
            this.lblCFOPForaEsta.AutoSize = true;
            this.lblCFOPForaEsta.Location = new System.Drawing.Point(5, 3);
            this.lblCFOPForaEsta.Name = "lblCFOPForaEsta";
            this.lblCFOPForaEsta.Size = new System.Drawing.Size(55, 13);
            this.lblCFOPForaEsta.TabIndex = 2;
            this.lblCFOPForaEsta.Text = "Descrição";
            // 
            // NaturezaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 598);
            this.Controls.Add(this.pnCFOPForaEsta);
            this.Controls.Add(this.pnCFOPConsu);
            this.Controls.Add(this.pnCFOPRev);
            this.Controls.Add(this.btnCFOPForaEsta);
            this.Controls.Add(this.txtCFOPForaEsta);
            this.Controls.Add(this.btnCFOPRev);
            this.Controls.Add(this.txtCFOPRev);
            this.Controls.Add(this.btnCFOPConsu);
            this.Controls.Add(this.txtCFOPConsu);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxUso);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridViewCfop);
            this.Controls.Add(this.checkBoxICMS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Name = "NaturezaOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natureza da Operação";
            this.Load += new System.EventHandler(this.CFOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCfop)).EndInit();
            this.pnCFOPRev.ResumeLayout(false);
            this.pnCFOPRev.PerformLayout();
            this.pnCFOPConsu.ResumeLayout(false);
            this.pnCFOPConsu.PerformLayout();
            this.pnCFOPForaEsta.ResumeLayout(false);
            this.pnCFOPForaEsta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxICMS;
        private System.Windows.Forms.DataGridView dataGridViewCfop;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodCFOP;
        private System.Windows.Forms.ComboBox cbxUso;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCFOPConsu;
        private System.Windows.Forms.Button btnCFOPConsu;
        private System.Windows.Forms.Button btnCFOPRev;
        private System.Windows.Forms.TextBox txtCFOPRev;
        private System.Windows.Forms.Button btnCFOPForaEsta;
        private System.Windows.Forms.TextBox txtCFOPForaEsta;
        private System.Windows.Forms.Panel pnCFOPRev;
        private System.Windows.Forms.Panel pnCFOPConsu;
        private System.Windows.Forms.Panel pnCFOPForaEsta;
        private System.Windows.Forms.Label lblCFOPConsu;
        private System.Windows.Forms.Label lblCFOPRev;
        private System.Windows.Forms.Label lblCFOPForaEsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cfop;
        private System.Windows.Forms.DataGridViewTextBoxColumn destacaricms;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cfop_consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cfop_revenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cfop_fora_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_revenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_fora_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn uso_;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_;
    }
}