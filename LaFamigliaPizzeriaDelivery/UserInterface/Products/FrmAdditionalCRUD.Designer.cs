
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdditionalRemark = new System.Windows.Forms.Label();
            this.txtAdditionalRemark = new System.Windows.Forms.TextBox();
            this.uscStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.txtAdditionalPrice = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.lblAdditionalDescription.Size = new System.Drawing.Size(74, 16);
            this.lblAdditionalDescription.TabIndex = 7;
            this.lblAdditionalDescription.Text = "Descrição:";
            // 
            // txtAdditionalDescription
            // 
            this.txtAdditionalDescription.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdditionalDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalDescription.Location = new System.Drawing.Point(172, 31);
            this.txtAdditionalDescription.Name = "txtAdditionalDescription";
            this.txtAdditionalDescription.Size = new System.Drawing.Size(604, 24);
            this.txtAdditionalDescription.TabIndex = 8;
            // 
            // lblAdditionalId
            // 
            this.lblAdditionalId.AutoSize = true;
            this.lblAdditionalId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblAdditionalId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdditionalId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdditionalId.Location = new System.Drawing.Point(8, 6);
            this.lblAdditionalId.Name = "lblAdditionalId";
            this.lblAdditionalId.Size = new System.Drawing.Size(59, 16);
            this.lblAdditionalId.TabIndex = 5;
            this.lblAdditionalId.Text = "Codigo:";
            // 
            // btnAdditionalSearch
            // 
            this.btnAdditionalSearch.Image = global::UserInterface.Properties.Resources.busca;
            this.btnAdditionalSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdditionalSearch.Location = new System.Drawing.Point(118, 30);
            this.btnAdditionalSearch.Name = "btnAdditionalSearch";
            this.btnAdditionalSearch.Size = new System.Drawing.Size(26, 26);
            this.btnAdditionalSearch.TabIndex = 9;
            this.btnAdditionalSearch.UseVisualStyleBackColor = true;
            this.btnAdditionalSearch.Click += new System.EventHandler(this.btnAdditionalSearch_Click);
            // 
            // txtAdditionalId
            // 
            this.txtAdditionalId.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdditionalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalId.Location = new System.Drawing.Point(12, 30);
            this.txtAdditionalId.Name = "txtAdditionalId";
            this.txtAdditionalId.Size = new System.Drawing.Size(100, 24);
            this.txtAdditionalId.TabIndex = 6;
            this.txtAdditionalId.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdditionalId_Validating);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(451, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 50);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Image = global::UserInterface.Properties.Resources.cancelar;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.btnDelete.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = global::UserInterface.Properties.Resources.excluir;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.btnSave.Font = new System.Drawing.Font("Futura Bk BT", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::UserInterface.Properties.Resources.confirmar;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(7, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(168, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor:";
            // 
            // lblAdditionalRemark
            // 
            this.lblAdditionalRemark.AutoSize = true;
            this.lblAdditionalRemark.Location = new System.Drawing.Point(168, 69);
            this.lblAdditionalRemark.Name = "lblAdditionalRemark";
            this.lblAdditionalRemark.Size = new System.Drawing.Size(89, 16);
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
            this.txtAdditionalRemark.TabIndex = 18;
            // 
            // uscStatus
            // 
            this.uscStatus.BackColor = System.Drawing.Color.Bisque;
            this.uscStatus.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscStatus.Location = new System.Drawing.Point(12, 69);
            this.uscStatus.Margin = new System.Windows.Forms.Padding(32, 21, 32, 21);
            this.uscStatus.MaximumSize = new System.Drawing.Size(146, 135);
            this.uscStatus.MinimumSize = new System.Drawing.Size(140, 130);
            this.uscStatus.Name = "uscStatus";
            this.uscStatus.Padding = new System.Windows.Forms.Padding(10);
            this.uscStatus.Size = new System.Drawing.Size(145, 135);
            this.uscStatus.TabIndex = 13;
            // 
            // txtAdditionalPrice
            // 
            this.txtAdditionalPrice.BackColor = System.Drawing.Color.SeaShell;
            this.txtAdditionalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdditionalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAdditionalPrice.Location = new System.Drawing.Point(172, 235);
            this.txtAdditionalPrice.Name = "txtAdditionalPrice";
            this.txtAdditionalPrice.Size = new System.Drawing.Size(258, 24);
            this.txtAdditionalPrice.TabIndex = 16;
            // 
            // FrmAdditionalCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 276);
            this.Controls.Add(this.txtAdditionalRemark);
            this.Controls.Add(this.lblAdditionalRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdditionalPrice);
            this.Controls.Add(this.uscStatus);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdditionalDescription;
        private System.Windows.Forms.TextBox txtAdditionalDescription;
        private System.Windows.Forms.Label lblAdditionalId;
        private System.Windows.Forms.Button btnAdditionalSearch;
        private System.Windows.Forms.TextBox txtAdditionalId;
        private Controls.UserSituacaoCTRL uscStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdditionalRemark;
        private System.Windows.Forms.TextBox txtAdditionalRemark;
        private System.Windows.Forms.TextBox txtAdditionalPrice;
    }
}