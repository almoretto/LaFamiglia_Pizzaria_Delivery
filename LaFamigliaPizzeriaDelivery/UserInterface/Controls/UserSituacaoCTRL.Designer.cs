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
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStatus.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.Location = new System.Drawing.Point(10, 10);
            this.grpStatus.Margin = new System.Windows.Forms.Padding(8);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Padding = new System.Windows.Forms.Padding(8);
            this.grpStatus.Size = new System.Drawing.Size(157, 152);
            this.grpStatus.TabIndex = 0;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rbtInactive
            // 
            this.rbtInactive.AutoSize = true;
            this.rbtInactive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtInactive.Location = new System.Drawing.Point(12, 62);
            this.rbtInactive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtInactive.Name = "rbtInactive";
            this.rbtInactive.Padding = new System.Windows.Forms.Padding(4);
            this.rbtInactive.Size = new System.Drawing.Size(77, 28);
            this.rbtInactive.TabIndex = 1;
            this.rbtInactive.TabStop = true;
            this.rbtInactive.Text = "Inativo";
            this.rbtInactive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtInactive.UseVisualStyleBackColor = true;
            this.rbtInactive.CheckedChanged += new System.EventHandler(this.RbtInactive_CheckedChanged);
            // 
            // rbtActive
            // 
            this.rbtActive.AutoSize = true;
            this.rbtActive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtActive.Location = new System.Drawing.Point(12, 26);
            this.rbtActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtActive.Name = "rbtActive";
            this.rbtActive.Padding = new System.Windows.Forms.Padding(4);
            this.rbtActive.Size = new System.Drawing.Size(66, 28);
            this.rbtActive.TabIndex = 0;
            this.rbtActive.TabStop = true;
            this.rbtActive.Text = "Ativo";
            this.rbtActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtActive.UseVisualStyleBackColor = true;
            this.rbtActive.CheckedChanged += new System.EventHandler(this.RbtActive_CheckedChanged);
            // 
            // UserSituacaoCTRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpStatus);
            this.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximumSize = new System.Drawing.Size(195, 195);
            this.MinimumSize = new System.Drawing.Size(137, 137);
            this.Name = "UserSituacaoCTRL";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(177, 172);
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
