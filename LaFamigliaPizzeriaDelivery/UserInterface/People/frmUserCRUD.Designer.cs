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
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(347, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::UserInterface.Properties.Resources.cancelar;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(221, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::UserInterface.Properties.Resources.excluir;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(114, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::UserInterface.Properties.Resources.confirmar;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(7, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserId.Location = new System.Drawing.Point(10, 33);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserId_Validating);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Image = global::UserInterface.Properties.Resources.busca;
            this.btnUserSearch.Location = new System.Drawing.Point(116, 33);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(22, 21);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserId.Location = new System.Drawing.Point(6, 9);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(65, 19);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "Codigo:";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserLogin.Location = new System.Drawing.Point(166, 59);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(53, 19);
            this.lblUserLogin.TabIndex = 4;
            this.lblUserLogin.Text = "Login:";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserPassword.Location = new System.Drawing.Point(423, 59);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(59, 19);
            this.lblUserPassword.TabIndex = 5;
            this.lblUserPassword.Text = "Senha:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserName.Location = new System.Drawing.Point(170, 34);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(501, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserLogin.Location = new System.Drawing.Point(170, 81);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(244, 20);
            this.txtUserLogin.TabIndex = 7;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserPassword.Location = new System.Drawing.Point(427, 81);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(244, 20);
            this.txtUserPassword.TabIndex = 8;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserType.Location = new System.Drawing.Point(166, 108);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(123, 19);
            this.lblUserType.TabIndex = 9;
            this.lblUserType.Text = "Tipo de Usuário";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Location = new System.Drawing.Point(166, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 19);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Nome:";
            // 
            // txtUserType
            // 
            this.txtUserType.BackColor = System.Drawing.Color.SeaShell;
            this.txtUserType.Location = new System.Drawing.Point(170, 130);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(119, 20);
            this.txtUserType.TabIndex = 11;
            this.txtUserType.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserType_Validating);
            // 
            // btnUserTypeSearch
            // 
            this.btnUserTypeSearch.Image = global::UserInterface.Properties.Resources.busca;
            this.btnUserTypeSearch.Location = new System.Drawing.Point(304, 130);
            this.btnUserTypeSearch.Name = "btnUserTypeSearch";
            this.btnUserTypeSearch.Size = new System.Drawing.Size(22, 20);
            this.btnUserTypeSearch.TabIndex = 12;
            this.btnUserTypeSearch.UseVisualStyleBackColor = true;
            this.btnUserTypeSearch.Click += new System.EventHandler(this.btnUserTypeSearch_Click);
            // 
            // lblDspUserType
            // 
            this.lblDspUserType.BackColor = System.Drawing.Color.Bisque;
            this.lblDspUserType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDspUserType.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDspUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDspUserType.Location = new System.Drawing.Point(170, 158);
            this.lblDspUserType.Name = "lblDspUserType";
            this.lblDspUserType.Size = new System.Drawing.Size(502, 23);
            this.lblDspUserType.TabIndex = 13;
            this.lblDspUserType.Text = "label6";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.BackColor = System.Drawing.Color.SeaShell;
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(427, 130);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(244, 20);
            this.txtPasswordConfirmation.TabIndex = 15;
            // 
            // lblUserPasswordConfirmation
            // 
            this.lblUserPasswordConfirmation.AutoSize = true;
            this.lblUserPasswordConfirmation.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPasswordConfirmation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserPasswordConfirmation.Location = new System.Drawing.Point(423, 108);
            this.lblUserPasswordConfirmation.Name = "lblUserPasswordConfirmation";
            this.lblUserPasswordConfirmation.Size = new System.Drawing.Size(156, 19);
            this.lblUserPasswordConfirmation.TabIndex = 14;
            this.lblUserPasswordConfirmation.Text = "Confirmação Senha:";
            // 
            // uscStatus
            // 
            this.uscStatus.BackColor = System.Drawing.Color.Bisque;
            this.uscStatus.Location = new System.Drawing.Point(38, 81);
            this.uscStatus.Name = "uscStatus";
            this.uscStatus.Size = new System.Drawing.Size(100, 100);
            this.uscStatus.TabIndex = 16;
            // 
            // FrmUserCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 255);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserCRUD";
            this.ShowInTaskbar = false;
            this.Text = "Cadastros e Manutenção de Usuários";
            this.Load += new System.EventHandler(this.frmUserCRUD_Load);
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
    }
}