
namespace UserInterface.Products
{
    partial class FrmAdditionalCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdditionalCRUD));
            this.lblAdditionalDescription = new System.Windows.Forms.Label();
            this.txtAdditionalDescription = new System.Windows.Forms.TextBox();
            this.lblAdditionalId = new System.Windows.Forms.Label();
            this.btnAdditionalSearch = new System.Windows.Forms.Button();
            this.txtAdditionalId = new System.Windows.Forms.TextBox();
            this.flwAddtitionalCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddticionalPrice = new System.Windows.Forms.Label();
            this.lblAdditionalRemark = new System.Windows.Forms.Label();
            this.txtAdditionalRemark = new System.Windows.Forms.TextBox();
            this.adcStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.txtAdditionalPrice = new System.Windows.Forms.TextBox();
            this.lblSaveOptimize = new System.Windows.Forms.Label();
            this.flwAddtitionalCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdditionalDescription
            // 
            this.lblAdditionalDescription.AutoSize = true;
            this.lblAdditionalDescription.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblAdditionalDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdditionalDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdditionalDescription.Location = new System.Drawing.Point(168, 6);
            this.lblAdditionalDescription.Name = "lblAdditionalDescription";
            this.lblAdditionalDescription.Size = new System.Drawing.Size(90, 20);
            this.lblAdditionalDescription.TabIndex = 7;
            this.lblAdditionalDescription.Text = "Descrição:";
            // 
            // txtAdditionalDescription
            // 
            this.txtAdditionalDescription.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdditionalDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalDescription.Location = new System.Drawing.Point(172, 31);
            this.txtAdditionalDescription.Name = "txtAdditionalDescription";
            this.txtAdditionalDescription.Size = new System.Drawing.Size(604, 28);
            this.txtAdditionalDescription.TabIndex = 2;
            // 
            // lblAdditionalId
            // 
            this.lblAdditionalId.AutoSize = true;
            this.lblAdditionalId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblAdditionalId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdditionalId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdditionalId.Location = new System.Drawing.Point(8, 6);
            this.lblAdditionalId.Name = "lblAdditionalId";
            this.lblAdditionalId.Size = new System.Drawing.Size(71, 20);
            this.lblAdditionalId.TabIndex = 0;
            this.lblAdditionalId.Text = "Codigo:";
            // 
            // btnAdditionalSearch
            // 
            this.btnAdditionalSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnAdditionalSearch.Image")));
            this.btnAdditionalSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdditionalSearch.Location = new System.Drawing.Point(118, 30);
            this.btnAdditionalSearch.Name = "btnAdditionalSearch";
            this.btnAdditionalSearch.Size = new System.Drawing.Size(26, 26);
            this.btnAdditionalSearch.TabIndex = 9;
            this.btnAdditionalSearch.UseVisualStyleBackColor = true;
            this.btnAdditionalSearch.Click += new System.EventHandler(this.BtnAdditionalSearch_Click);
            // 
            // txtAdditionalId
            // 
            this.txtAdditionalId.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdditionalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalId.Location = new System.Drawing.Point(12, 30);
            this.txtAdditionalId.Name = "txtAdditionalId";
            this.txtAdditionalId.Size = new System.Drawing.Size(100, 28);
            this.txtAdditionalId.TabIndex = 1;
            this.txtAdditionalId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAdditionalId_Validating);
            // 
            // flwAddtitionalCRUD
            // 
            this.flwAddtitionalCRUD.Controls.Add(this.btnCancel);
            this.flwAddtitionalCRUD.Controls.Add(this.btnDelete);
            this.flwAddtitionalCRUD.Controls.Add(this.btnSave);
            this.flwAddtitionalCRUD.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwAddtitionalCRUD.Location = new System.Drawing.Point(451, 210);
            this.flwAddtitionalCRUD.Name = "flwAddtitionalCRUD";
            this.flwAddtitionalCRUD.Size = new System.Drawing.Size(325, 54);
            this.flwAddtitionalCRUD.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(221, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 48);
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
            this.btnDelete.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = global::UserInterface.Properties.Resources.RedTrash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(114, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 48);
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
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(7, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblAddticionalPrice
            // 
            this.lblAddticionalPrice.AutoSize = true;
            this.lblAddticionalPrice.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblAddticionalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddticionalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddticionalPrice.Location = new System.Drawing.Point(168, 213);
            this.lblAddticionalPrice.Name = "lblAddticionalPrice";
            this.lblAddticionalPrice.Size = new System.Drawing.Size(56, 20);
            this.lblAddticionalPrice.TabIndex = 15;
            this.lblAddticionalPrice.Text = "Valor:";
            // 
            // lblAdditionalRemark
            // 
            this.lblAdditionalRemark.AutoSize = true;
            this.lblAdditionalRemark.Location = new System.Drawing.Point(168, 69);
            this.lblAdditionalRemark.Name = "lblAdditionalRemark";
            this.lblAdditionalRemark.Size = new System.Drawing.Size(108, 20);
            this.lblAdditionalRemark.TabIndex = 17;
            this.lblAdditionalRemark.Text = "Observação:";
            // 
            // txtAdditionalRemark
            // 
            this.txtAdditionalRemark.BackColor = System.Drawing.Color.White;
            this.txtAdditionalRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalRemark.Font = new System.Drawing.Font("Futura Md BT", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalRemark.Location = new System.Drawing.Point(172, 94);
            this.txtAdditionalRemark.Multiline = true;
            this.txtAdditionalRemark.Name = "txtAdditionalRemark";
            this.txtAdditionalRemark.Size = new System.Drawing.Size(604, 110);
            this.txtAdditionalRemark.TabIndex = 3;
            // 
            // adcStatus
            // 
            this.adcStatus.BackColor = System.Drawing.Color.Bisque;
            this.adcStatus.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adcStatus.Location = new System.Drawing.Point(12, 69);
            this.adcStatus.Margin = new System.Windows.Forms.Padding(32, 21, 32, 21);
            this.adcStatus.MaximumSize = new System.Drawing.Size(146, 135);
            this.adcStatus.MinimumSize = new System.Drawing.Size(140, 130);
            this.adcStatus.Name = "adcStatus";
            this.adcStatus.Padding = new System.Windows.Forms.Padding(10);
            this.adcStatus.Size = new System.Drawing.Size(145, 135);
            this.adcStatus.TabIndex = 4;
            // 
            // txtAdditionalPrice
            // 
            this.txtAdditionalPrice.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdditionalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAdditionalPrice.Location = new System.Drawing.Point(172, 235);
            this.txtAdditionalPrice.Name = "txtAdditionalPrice";
            this.txtAdditionalPrice.Size = new System.Drawing.Size(258, 28);
            this.txtAdditionalPrice.TabIndex = 4;
            // 
            // lblSaveOptimize
            // 
            this.lblSaveOptimize.AutoSize = true;
            this.lblSaveOptimize.Font = new System.Drawing.Font("Futura Bk BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveOptimize.Location = new System.Drawing.Point(12, 245);
            this.lblSaveOptimize.Name = "lblSaveOptimize";
            this.lblSaveOptimize.Size = new System.Drawing.Size(0, 16);
            this.lblSaveOptimize.TabIndex = 18;
            // 
            // FrmAdditionalCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 276);
            this.Controls.Add(this.lblSaveOptimize);
            this.Controls.Add(this.txtAdditionalRemark);
            this.Controls.Add(this.lblAdditionalRemark);
            this.Controls.Add(this.lblAddticionalPrice);
            this.Controls.Add(this.txtAdditionalPrice);
            this.Controls.Add(this.adcStatus);
            this.Controls.Add(this.flwAddtitionalCRUD);
            this.Controls.Add(this.lblAdditionalDescription);
            this.Controls.Add(this.txtAdditionalDescription);
            this.Controls.Add(this.lblAdditionalId);
            this.Controls.Add(this.btnAdditionalSearch);
            this.Controls.Add(this.txtAdditionalId);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdditionalCRUD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Adicionais";
            this.Load += new System.EventHandler(this.FrmAdditionalCRUD_Load);
            this.flwAddtitionalCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdditionalDescription;
        private System.Windows.Forms.TextBox txtAdditionalDescription;
        private System.Windows.Forms.Label lblAdditionalId;
        private System.Windows.Forms.Button btnAdditionalSearch;
        private System.Windows.Forms.TextBox txtAdditionalId;
        private Controls.UserSituacaoCTRL adcStatus;
        private System.Windows.Forms.FlowLayoutPanel flwAddtitionalCRUD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddticionalPrice;
        private System.Windows.Forms.Label lblAdditionalRemark;
        private System.Windows.Forms.TextBox txtAdditionalRemark;
        private System.Windows.Forms.TextBox txtAdditionalPrice;
        private System.Windows.Forms.Label lblSaveOptimize;
    }
}