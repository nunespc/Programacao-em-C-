namespace SistemaNunesPc
{
    partial class Localizar
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
            this.dataGridViewLoca = new System.Windows.Forms.DataGridView();
            this.codigo_cfop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cfop_consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_revenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cfop_revenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfop_fora_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cfop_fora_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uso_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoca
            // 
            this.dataGridViewLoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_cfop,
            this.descricao,
            this.cfop_consumo,
            this.id_cfop_consumo,
            this.cfop_revenda,
            this.id_cfop_revenda,
            this.cfop_fora_estado,
            this.id_cfop_fora_estado,
            this.uso_,
            this.tipo_});
            this.dataGridViewLoca.Location = new System.Drawing.Point(11, 59);
            this.dataGridViewLoca.Name = "dataGridViewLoca";
            this.dataGridViewLoca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoca.Size = new System.Drawing.Size(501, 334);
            this.dataGridViewLoca.TabIndex = 0;
            this.dataGridViewLoca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codigo_cfop
            // 
            this.codigo_cfop.DataPropertyName = "codigo_cfop";
            this.codigo_cfop.HeaderText = "Codigo";
            this.codigo_cfop.Name = "codigo_cfop";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // cfop_consumo
            // 
            this.cfop_consumo.DataPropertyName = "cfop_consumo";
            this.cfop_consumo.HeaderText = "Cfop Consumo";
            this.cfop_consumo.Name = "cfop_consumo";
            // 
            // id_cfop_consumo
            // 
            this.id_cfop_consumo.DataPropertyName = "id_cfop_consumo";
            this.id_cfop_consumo.HeaderText = "Id Cfop Consumo";
            this.id_cfop_consumo.Name = "id_cfop_consumo";
            // 
            // cfop_revenda
            // 
            this.cfop_revenda.DataPropertyName = "cfop_revenda";
            this.cfop_revenda.HeaderText = "Cfop Revenda";
            this.cfop_revenda.Name = "cfop_revenda";
            // 
            // id_cfop_revenda
            // 
            this.id_cfop_revenda.DataPropertyName = "id_cfop_revenda";
            this.id_cfop_revenda.HeaderText = "Id Cfop Revenda";
            this.id_cfop_revenda.Name = "id_cfop_revenda";
            // 
            // cfop_fora_estado
            // 
            this.cfop_fora_estado.DataPropertyName = "cfop_fora_estado";
            this.cfop_fora_estado.HeaderText = "Cfop Fora Estado";
            this.cfop_fora_estado.Name = "cfop_fora_estado";
            // 
            // id_cfop_fora_estado
            // 
            this.id_cfop_fora_estado.DataPropertyName = "id_cfop_fora_estado";
            this.id_cfop_fora_estado.HeaderText = "Id Cfop Fora Estado";
            this.id_cfop_fora_estado.Name = "id_cfop_fora_estado";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procurar Por:";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(210, 26);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(303, 20);
            this.txtCriterio.TabIndex = 4;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtDescricaoLoca_TextChanged);
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID",
            "Descrição"});
            this.cbxBuscar.Location = new System.Drawing.Point(83, 25);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbxBuscar.TabIndex = 5;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 444);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLoca);
            this.Name = "Localizar";
            this.Text = "Localizar";
            this.Load += new System.EventHandler(this.Localizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cfop;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cfop_consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_revenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cfop_revenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfop_fora_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cfop_fora_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn uso_;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_;
    }
}