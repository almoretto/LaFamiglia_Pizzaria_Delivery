
namespace UserInterface.Products
{
    partial class FrmPizzaFlavorCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaFlavorCRUD));
            this.txtFlavorRemark = new System.Windows.Forms.TextBox();
            this.lblFlavorRemark = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlavorPriceAdditional = new System.Windows.Forms.TextBox();
            this.flvStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAdditionalDescription = new System.Windows.Forms.Label();
            this.txtFlavorDescription = new System.Windows.Forms.TextBox();
            this.lblAdditionalId = new System.Windows.Forms.Label();
            this.btnFlavorSearch = new System.Windows.Forms.Button();
            this.txtFlavorId = new System.Windows.Forms.TextBox();
            this.lblSaveOptimize = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFlavorRemark
            // 
            this.txtFlavorRemark.BackColor = System.Drawing.Color.White;
            this.txtFlavorRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlavorRemark.Font = new System.Drawing.Font("Futura Md BT", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlavorRemark.Location = new System.Drawing.Point(176, 98);
            this.txtFlavorRemark.Multiline = true;
            this.txtFlavorRemark.Name = "txtFlavorRemark";
            this.txtFlavorRemark.Size = new System.Drawing.Size(604, 110);
            this.txtFlavorRemark.TabIndex = 2;
            // 
            // lblFlavorRemark
            // 
            this.lblFlavorRemark.AutoSize = true;
            this.lblFlavorRemark.Location = new System.Drawing.Point(172, 73);
            this.lblFlavorRemark.Name = "lblFlavorRemark";
            this.lblFlavorRemark.Size = new System.Drawing.Size(108, 20);
            this.lblFlavorRemark.TabIndex = 28;
            this.lblFlavorRemark.Text = "Observação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(172, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Valor Adicional:";
            // 
            // txtFlavorPriceAdditional
            // 
            this.txtFlavorPriceAdditional.BackColor = System.Drawing.Color.White;
            this.txtFlavorPriceAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlavorPriceAdditional.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFlavorPriceAdditional.Location = new System.Drawing.Point(176, 239);
            this.txtFlavorPriceAdditional.Name = "txtFlavorPriceAdditional";
            this.txtFlavorPriceAdditional.Size = new System.Drawing.Size(258, 28);
            this.txtFlavorPriceAdditional.TabIndex = 3;
            // 
            // flvStatus
            // 
            this.flvStatus.BackColor = System.Drawing.Color.Bisque;
            this.flvStatus.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flvStatus.Location = new System.Drawing.Point(16, 73);
            this.flvStatus.Margin = new System.Windows.Forms.Padding(32, 21, 32, 21);
            this.flvStatus.MaximumSize = new System.Drawing.Size(146, 135);
            this.flvStatus.MinimumSize = new System.Drawing.Size(140, 130);
            this.flvStatus.Name = "flvStatus";
            this.flvStatus.Padding = new System.Windows.Forms.Padding(10);
            this.flvStatus.Size = new System.Drawing.Size(145, 135);
            this.flvStatus.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 50);
            this.flowLayoutPanel1.TabIndex = 5;
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
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblAdditionalDescription
            // 
            this.lblAdditionalDescription.AutoSize = true;
            this.lblAdditionalDescription.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblAdditionalDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdditionalDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdditionalDescription.Location = new System.Drawing.Point(172, 10);
            this.lblAdditionalDescription.Name = "lblAdditionalDescription";
            this.lblAdditionalDescription.Size = new System.Drawing.Size(60, 20);
            this.lblAdditionalDescription.TabIndex = 21;
            this.lblAdditionalDescription.Text = "Sabor:";
            // 
            // txtFlavorDescription
            // 
            this.txtFlavorDescription.BackColor = System.Drawing.Color.SeaShell;
            this.txtFlavorDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlavorDescription.Location = new System.Drawing.Point(176, 35);
            this.txtFlavorDescription.Name = "txtFlavorDescription";
            this.txtFlavorDescription.Size = new System.Drawing.Size(604, 28);
            this.txtFlavorDescription.TabIndex = 1;
            // 
            // lblAdditionalId
            // 
            this.lblAdditionalId.AutoSize = true;
            this.lblAdditionalId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblAdditionalId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdditionalId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdditionalId.Location = new System.Drawing.Point(12, 10);
            this.lblAdditionalId.Name = "lblAdditionalId";
            this.lblAdditionalId.Size = new System.Drawing.Size(71, 20);
            this.lblAdditionalId.TabIndex = 19;
            this.lblAdditionalId.Text = "Codigo:";
            // 
            // btnFlavorSearch
            // 
            this.btnFlavorSearch.Image = global::UserInterface.Properties.Resources.busca;
            this.btnFlavorSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFlavorSearch.Location = new System.Drawing.Point(122, 34);
            this.btnFlavorSearch.Name = "btnFlavorSearch";
            this.btnFlavorSearch.Size = new System.Drawing.Size(26, 26);
            this.btnFlavorSearch.TabIndex = 23;
            this.btnFlavorSearch.UseVisualStyleBackColor = true;
            this.btnFlavorSearch.Click += new System.EventHandler(this.BtnFlavorSearch_Click);
            // 
            // txtFlavorId
            // 
            this.txtFlavorId.BackColor = System.Drawing.Color.SeaShell;
            this.txtFlavorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlavorId.Location = new System.Drawing.Point(16, 34);
            this.txtFlavorId.Name = "txtFlavorId";
            this.txtFlavorId.Size = new System.Drawing.Size(100, 28);
            this.txtFlavorId.TabIndex = 0;
            this.txtFlavorId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFlavorId_Validating);
            // 
            // lblSaveOptimize
            // 
            this.lblSaveOptimize.AutoSize = true;
            this.lblSaveOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaveOptimize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaveOptimize.Location = new System.Drawing.Point(16, 249);
            this.lblSaveOptimize.Name = "lblSaveOptimize";
            this.lblSaveOptimize.Size = new System.Drawing.Size(0, 20);
            this.lblSaveOptimize.TabIndex = 29;
            // 
            // FrmPizzaFlavorCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 276);
            this.Controls.Add(this.lblSaveOptimize);
            this.Controls.Add(this.txtFlavorRemark);
            this.Controls.Add(this.lblFlavorRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFlavorPriceAdditional);
            this.Controls.Add(this.flvStatus);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblAdditionalDescription);
            this.Controls.Add(this.txtFlavorDescription);
            this.Controls.Add(this.lblAdditionalId);
            this.Controls.Add(this.btnFlavorSearch);
            this.Controls.Add(this.txtFlavorId);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaFlavorCRUD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Sabores";
            this.Load += new System.EventHandler(this.FrmPizzaFlavorCRUD_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlavorRemark;
        private System.Windows.Forms.Label lblFlavorRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFlavorPriceAdditional;
        private Controls.UserSituacaoCTRL flvStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAdditionalDescription;
        private System.Windows.Forms.TextBox txtFlavorDescription;
        private System.Windows.Forms.Label lblAdditionalId;
        private System.Windows.Forms.Button btnFlavorSearch;
        private System.Windows.Forms.TextBox txtFlavorId;
        private System.Windows.Forms.Label lblSaveOptimize;
    }
}