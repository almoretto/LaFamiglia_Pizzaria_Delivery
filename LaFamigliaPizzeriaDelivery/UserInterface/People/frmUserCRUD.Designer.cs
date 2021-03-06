namespace UserInterface.People
{
    partial class FrmUserCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserCRUD));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.btnUserTypeSearch = new System.Windows.Forms.Button();
            this.lblDspUserType = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.lblUserPasswordConfirmation = new System.Windows.Forms.Label();
            this.uscStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.lblSaveOptimize = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(474, 271);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(255, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 51);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::UserInterface.Properties.Resources.RedTrash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(136, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 51);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(17, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 51);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserId.Location = new System.Drawing.Point(15, 46);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(148, 28);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserId_Validating);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSearch.Image")));
            this.btnUserSearch.Location = new System.Drawing.Point(174, 46);
            this.btnUserSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(33, 29);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.BtnUserSearch_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserId.Location = new System.Drawing.Point(9, 12);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(71, 20);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "Codigo:";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserLogin.Location = new System.Drawing.Point(249, 82);
            this.lblUserLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(57, 20);
            this.lblUserLogin.TabIndex = 4;
            this.lblUserLogin.Text = "Login:";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserPassword.Location = new System.Drawing.Point(634, 82);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(63, 20);
            this.lblUserPassword.TabIndex = 5;
            this.lblUserPassword.Text = "Senha:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserName.Location = new System.Drawing.Point(255, 47);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(589, 28);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserLogin.Location = new System.Drawing.Point(255, 112);
            this.txtUserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(364, 28);
            this.txtUserLogin.TabIndex = 7;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserPassword.Location = new System.Drawing.Point(640, 112);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(204, 28);
            this.txtUserPassword.TabIndex = 8;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserType.Location = new System.Drawing.Point(249, 150);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(131, 20);
            this.lblUserType.TabIndex = 9;
            this.lblUserType.Text = "Tipo de Usuário";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Location = new System.Drawing.Point(249, 12);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 20);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Nome:";
            // 
            // txtUserType
            // 
            this.txtUserType.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserType.Location = new System.Drawing.Point(255, 180);
            this.txtUserType.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(176, 28);
            this.txtUserType.TabIndex = 11;
            this.txtUserType.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserType_Validating);
            // 
            // btnUserTypeSearch
            // 
            this.btnUserTypeSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnUserTypeSearch.Image")));
            this.btnUserTypeSearch.Location = new System.Drawing.Point(456, 180);
            this.btnUserTypeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserTypeSearch.Name = "btnUserTypeSearch";
            this.btnUserTypeSearch.Size = new System.Drawing.Size(33, 28);
            this.btnUserTypeSearch.TabIndex = 12;
            this.btnUserTypeSearch.UseVisualStyleBackColor = true;
            this.btnUserTypeSearch.Click += new System.EventHandler(this.BtnUserTypeSearch_Click);
            // 
            // lblDspUserType
            // 
            this.lblDspUserType.BackColor = System.Drawing.Color.Bisque;
            this.lblDspUserType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDspUserType.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDspUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDspUserType.Location = new System.Drawing.Point(255, 219);
            this.lblDspUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDspUserType.Name = "lblDspUserType";
            this.lblDspUserType.Size = new System.Drawing.Size(589, 32);
            this.lblDspUserType.TabIndex = 13;
            this.lblDspUserType.Text = "label6";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.BackColor = System.Drawing.Color.SeaShell;
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(640, 180);
            this.txtPasswordConfirmation.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(204, 28);
            this.txtPasswordConfirmation.TabIndex = 15;
            // 
            // lblUserPasswordConfirmation
            // 
            this.lblUserPasswordConfirmation.AutoSize = true;
            this.lblUserPasswordConfirmation.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPasswordConfirmation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserPasswordConfirmation.Location = new System.Drawing.Point(634, 150);
            this.lblUserPasswordConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPasswordConfirmation.Name = "lblUserPasswordConfirmation";
            this.lblUserPasswordConfirmation.Size = new System.Drawing.Size(168, 20);
            this.lblUserPasswordConfirmation.TabIndex = 14;
            this.lblUserPasswordConfirmation.Text = "Confirmação Senha:";
            // 
            // uscStatus
            // 
            this.uscStatus.BackColor = System.Drawing.Color.Bisque;
            this.uscStatus.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscStatus.Location = new System.Drawing.Point(45, 113);
            this.uscStatus.Margin = new System.Windows.Forms.Padding(4);
            this.uscStatus.MaximumSize = new System.Drawing.Size(195, 195);
            this.uscStatus.MinimumSize = new System.Drawing.Size(137, 137);
            this.uscStatus.Name = "uscStatus";
            this.uscStatus.Padding = new System.Windows.Forms.Padding(10);
            this.uscStatus.Size = new System.Drawing.Size(150, 138);
            this.uscStatus.TabIndex = 16;
            // 
            // lblSaveOptimize
            // 
            this.lblSaveOptimize.AutoSize = true;
            this.lblSaveOptimize.Font = new System.Drawing.Font("Futura Bk BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveOptimize.Location = new System.Drawing.Point(45, 300);
            this.lblSaveOptimize.Name = "lblSaveOptimize";
            this.lblSaveOptimize.Size = new System.Drawing.Size(0, 16);
            this.lblSaveOptimize.TabIndex = 17;
            // 
            // FrmUserCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 353);
            this.Controls.Add(this.lblSaveOptimize);
            this.Controls.Add(this.uscStatus);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.lblUserPasswordConfirmation);
            this.Controls.Add(this.lblDspUserType);
            this.Controls.Add(this.btnUserTypeSearch);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnUserSearch);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserCRUD";
            this.ShowInTaskbar = false;
            this.Text = "Cadastros e Manutenção de Usuários";
            this.Load += new System.EventHandler(this.FrmUserCRUD_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Button btnUserTypeSearch;
        private System.Windows.Forms.Label lblDspUserType;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label lblUserPasswordConfirmation;
        private Controls.UserSituacaoCTRL uscStatus;
        private System.Windows.Forms.Label lblSaveOptimize;
    }
}