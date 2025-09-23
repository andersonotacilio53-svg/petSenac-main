namespace petSenac
{
    partial class FormCaixa
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
            this.dgvDescricao = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescricao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDescricao
            // 
            this.dgvDescricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescricao.Location = new System.Drawing.Point(806, -1);
            this.dgvDescricao.Name = "dgvDescricao";
            this.dgvDescricao.Size = new System.Drawing.Size(372, 564);
            this.dgvDescricao.TabIndex = 0;
            this.dgvDescricao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescricao_CellClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Red;
            this.btnFinalizar.Location = new System.Drawing.Point(1, 504);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(296, 59);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar Comanda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Red;
            this.btnListar.Location = new System.Drawing.Point(366, 143);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(306, 63);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(379, 9);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(282, 31);
            this.lblComanda.TabIndex = 3;
            this.lblComanda.Text = "Numero da comanda";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(45, 86);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(119, 42);
            this.lblCaixa.TabIndex = 4;
            this.lblCaixa.Text = "Caixa";
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(12, 319);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(164, 33);
            this.chbPagamento.TabIndex = 5;
            this.chbPagamento.Text = "Pagamento";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.Click += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(376, 69);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(285, 40);
            this.txbComanda.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 423);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 31);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "R$ - ";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::petSenac.Properties.Resources.pet;
            this.ClientSize = new System.Drawing.Size(1176, 565);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvDescricao);
            this.Name = "FormCaixa";
            this.Text = "Caixa petSenac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescricao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDescricao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblTotal;
    }
}