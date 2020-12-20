namespace UserInterface.Controls
{
    partial class UserSituacaoCTRL
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rbtInactive = new System.Windows.Forms.RadioButton();
            this.rbtActive = new System.Windows.Forms.RadioButton();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rbtInactive);
            this.grpStatus.Controls.Add(this.rbtActive);
            this.grpStatus.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.Location = new System.Drawing.Point(10, 10);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(80, 80);
            this.grpStatus.TabIndex = 0;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rbtInactive
            // 
            this.rbtInactive.AutoSize = true;
            this.rbtInactive.Location = new System.Drawing.Point(6, 47);
            this.rbtInactive.Name = "rbtInactive";
            this.rbtInactive.Size = new System.Drawing.Size(69, 20);
            this.rbtInactive.TabIndex = 1;
            this.rbtInactive.TabStop = true;
            this.rbtInactive.Text = "Inativo";
            this.rbtInactive.UseVisualStyleBackColor = true;
            this.rbtInactive.CheckedChanged += new System.EventHandler(this.RbtInactive_CheckedChanged);
            // 
            // rbtActive
            // 
            this.rbtActive.AutoSize = true;
            this.rbtActive.Location = new System.Drawing.Point(6, 21);
            this.rbtActive.Name = "rbtActive";
            this.rbtActive.Size = new System.Drawing.Size(58, 20);
            this.rbtActive.TabIndex = 0;
            this.rbtActive.TabStop = true;
            this.rbtActive.Text = "Ativo";
            this.rbtActive.UseVisualStyleBackColor = true;
            this.rbtActive.CheckedChanged += new System.EventHandler(this.RbtActive_CheckedChanged);
            // 
            // UserSituacaoCTRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpStatus);
            this.Name = "UserSituacaoCTRL";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.UserSituacaoCTRL_Load);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rbtInactive;
        private System.Windows.Forms.RadioButton rbtActive;
    }
}
