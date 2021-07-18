namespace SistemaNunesPc
{
    partial class CST_do_PISCOFINS
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbBasecalculo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewCst = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usocst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basecalculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reducaobase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cbxCst = new System.Windows.Forms.ComboBox();
            this.txtReducaobase = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCst)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(68, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(82, 68);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(489, 20);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uso do CST:";
            // 
            // ckbBasecalculo
            // 
            this.ckbBasecalculo.AutoSize = true;
            this.ckbBasecalculo.Location = new System.Drawing.Point(21, 134);
            this.ckbBasecalculo.Name = "ckbBasecalculo";
            this.ckbBasecalculo.Size = new System.Drawing.Size(176, 17);
            this.ckbBasecalculo.TabIndex = 7;
            this.ckbBasecalculo.Text = "Sugere o Valor do Produto/Item";
            this.ckbBasecalculo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base de Calculo PIS/COFINS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Redução de Base de Calculo";
            // 
            // dataGridViewCst
            // 
            this.dataGridViewCst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.usocst,
            this.basecalculo,
            this.reducaobase});
            this.dataGridViewCst.Location = new System.Drawing.Point(21, 157);
            this.dataGridViewCst.Name = "dataGridViewCst";
            this.dataGridViewCst.Size = new System.Drawing.Size(550, 297);
            this.dataGridViewCst.TabIndex = 11;
            this.dataGridViewCst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 400;
            // 
            // usocst
            // 
            this.usocst.DataPropertyName = "usocst";
            this.usocst.HeaderText = "Uso do CST";
            this.usocst.Name = "usocst";
            this.usocst.Width = 200;
            // 
            // basecalculo
            // 
            this.basecalculo.DataPropertyName = "basecalculo";
            this.basecalculo.HeaderText = "Base de Calculo PIS/COFINS";
            this.basecalculo.Name = "basecalculo";
            // 
            // reducaobase
            // 
            this.reducaobase.DataPropertyName = "reducaobase";
            this.reducaobase.HeaderText = "Redução de Base de Calculo";
            this.reducaobase.Name = "reducaobase";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_delete_48762;
            this.btnExcluir.Location = new System.Drawing.Point(325, 460);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 41);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_edit_48763;
            this.btnEditar.Location = new System.Drawing.Point(279, 460);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 41);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_add_48761;
            this.btnSalvar.Location = new System.Drawing.Point(233, 460);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalvar.Size = new System.Drawing.Size(40, 41);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::SistemaNunesPc.Properties.Resources.iconfinder_file_48760;
            this.btnNovo.Location = new System.Drawing.Point(187, 460);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 41);
            this.btnNovo.TabIndex = 35;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(427, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 17);
            this.radioButton3.TabIndex = 60;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Redução Base de Calculo";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(427, 94);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 17);
            this.radioButton4.TabIndex = 59;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Descrição";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(427, 131);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisa.TabIndex = 58;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(515, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "Pesquisar:";
            // 
            // cbxCst
            // 
            this.cbxCst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCst.FormattingEnabled = true;
            this.cbxCst.Items.AddRange(new object[] {
            "",
            "Entrada",
            "Saída"});
            this.cbxCst.Location = new System.Drawing.Point(297, 31);
            this.cbxCst.Name = "cbxCst";
            this.cbxCst.Size = new System.Drawing.Size(130, 21);
            this.cbxCst.TabIndex = 61;
            this.cbxCst.SelectedIndexChanged += new System.EventHandler(this.cbxCst_SelectedIndexChanged);
            // 
            // txtReducaobase
            // 
            this.txtReducaobase.Location = new System.Drawing.Point(222, 134);
            this.txtReducaobase.Name = "txtReducaobase";
            this.txtReducaobase.Size = new System.Drawing.Size(163, 20);
            this.txtReducaobase.TabIndex = 62;
            this.txtReducaobase.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtReducaobase_MaskInputRejected);
            // 
            // CST_do_PISCOFINS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 510);
            this.Controls.Add(this.txtReducaobase);
            this.Controls.Add(this.cbxCst);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridViewCst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbBasecalculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Name = "CST_do_PISCOFINS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CST do PIS/COFINS";
            this.Load += new System.EventHandler(this.CST_do_PISCOFINS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbBasecalculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewCst;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cbxCst;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usocst;
        private System.Windows.Forms.DataGridViewTextBoxColumn basecalculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reducaobase;
        private System.Windows.Forms.MaskedTextBox txtReducaobase;
    }
}