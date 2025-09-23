namespace petSenac
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnordensServico = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnConfguraçao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Silver;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 21);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(206, 31);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Prinicipal:";
            // 
            // btnordensServico
            // 
            this.btnordensServico.BackColor = System.Drawing.Color.Silver;
            this.btnordensServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnordensServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnordensServico.Location = new System.Drawing.Point(12, 342);
            this.btnordensServico.Name = "btnordensServico";
            this.btnordensServico.Size = new System.Drawing.Size(296, 39);
            this.btnordensServico.TabIndex = 1;
            this.btnordensServico.Text = "Ordens Serviço";
            this.btnordensServico.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Silver;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(12, 387);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(296, 51);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.Silver;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(361, 342);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(320, 39);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            // 
            // btnConfguraçao
            // 
            this.btnConfguraçao.BackColor = System.Drawing.Color.Silver;
            this.btnConfguraçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfguraçao.Location = new System.Drawing.Point(361, 387);
            this.btnConfguraçao.Name = "btnConfguraçao";
            this.btnConfguraçao.Size = new System.Drawing.Size(320, 51);
            this.btnConfguraçao.TabIndex = 4;
            this.btnConfguraçao.Text = "Configuraçoes";
            this.btnConfguraçao.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::petSenac.Properties.Resources.pet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfguraçao);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnordensServico);
            this.Controls.Add(this.lblMenu);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnordensServico;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnConfguraçao;
    }
}

