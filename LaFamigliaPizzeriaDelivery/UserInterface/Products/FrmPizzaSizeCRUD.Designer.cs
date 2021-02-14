
namespace UserInterface.Products
{
    partial class FrmPizzaSizeCRUD
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
            this.txtSizeRemark = new System.Windows.Forms.TextBox();
            this.lblSizeRemark = new System.Windows.Forms.Label();
            this.lblSizeAdditionalPrice = new System.Windows.Forms.Label();
            this.txtSizePriceAdditional = new System.Windows.Forms.TextBox();
            this.szeStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.flwSizeCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSizeDescription = new System.Windows.Forms.Label();
            this.txtSizeDescription = new System.Windows.Forms.TextBox();
            this.lblSizeId = new System.Windows.Forms.Label();
            this.btnSizeSearch = new System.Windows.Forms.Button();
            this.txtSizeId = new System.Windows.Forms.TextBox();
            this.lblSaveOptimize = new System.Windows.Forms.Label();
            this.lblQtyFlavors = new System.Windows.Forms.Label();
            this.txtQtyFlavors = new System.Windows.Forms.TextBox();
            this.flwSizeCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSizeRemark
            // 
            this.txtSizeRemark.BackColor = System.Drawing.Color.White;
            this.txtSizeRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizeRemark.Font = new System.Drawing.Font("Futura Md BT", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeRemark.Location = new System.Drawing.Point(176, 98);
            this.txtSizeRemark.Multiline = true;
            this.txtSizeRemark.Name = "txtSizeRemark";
            this.txtSizeRemark.Size = new System.Drawing.Size(604, 110);
            this.txtSizeRemark.TabIndex = 3;
            // 
            // lblSizeRemark
            // 
            this.lblSizeRemark.AutoSize = true;
            this.lblSizeRemark.Location = new System.Drawing.Point(172, 73);
            this.lblSizeRemark.Name = "lblSizeRemark";
            this.lblSizeRemark.Size = new System.Drawing.Size(108, 20);
            this.lblSizeRemark.TabIndex = 28;
            this.lblSizeRemark.Text = "Observação:";
            // 
            // lblSizeAdditionalPrice
            // 
            this.lblSizeAdditionalPrice.AutoSize = true;
            this.lblSizeAdditionalPrice.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblSizeAdditionalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSizeAdditionalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSizeAdditionalPrice.Location = new System.Drawing.Point(172, 217);
            this.lblSizeAdditionalPrice.Name = "lblSizeAdditionalPrice";
            this.lblSizeAdditionalPrice.Size = new System.Drawing.Size(132, 20);
            this.lblSizeAdditionalPrice.TabIndex = 26;
            this.lblSizeAdditionalPrice.Text = "Valor Adicional:";
            // 
            // txtSizePriceAdditional
            // 
            this.txtSizePriceAdditional.BackColor = System.Drawing.Color.White;
            this.txtSizePriceAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizePriceAdditional.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSizePriceAdditional.Location = new System.Drawing.Point(176, 239);
            this.txtSizePriceAdditional.Name = "txtSizePriceAdditional";
            this.txtSizePriceAdditional.Size = new System.Drawing.Size(258, 28);
            this.txtSizePriceAdditional.TabIndex = 4;
            // 
            // szeStatus
            // 
            this.szeStatus.BackColor = System.Drawing.Color.Bisque;
            this.szeStatus.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szeStatus.Location = new System.Drawing.Point(16, 73);
            this.szeStatus.Margin = new System.Windows.Forms.Padding(32, 21, 32, 21);
            this.szeStatus.MaximumSize = new System.Drawing.Size(146, 135);
            this.szeStatus.MinimumSize = new System.Drawing.Size(140, 130);
            this.szeStatus.Name = "szeStatus";
            this.szeStatus.Padding = new System.Windows.Forms.Padding(10);
            this.szeStatus.Size = new System.Drawing.Size(145, 135);
            this.szeStatus.TabIndex = 5;
            // 
            // flwSizeCRUD
            // 
            this.flwSizeCRUD.Controls.Add(this.btnCancel);
            this.flwSizeCRUD.Controls.Add(this.btnDelete);
            this.flwSizeCRUD.Controls.Add(this.btnSave);
            this.flwSizeCRUD.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwSizeCRUD.Location = new System.Drawing.Point(455, 214);
            this.flwSizeCRUD.Name = "flwSizeCRUD";
            this.flwSizeCRUD.Size = new System.Drawing.Size(325, 50);
            this.flwSizeCRUD.TabIndex = 6;
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
            // lblSizeDescription
            // 
            this.lblSizeDescription.AutoSize = true;
            this.lblSizeDescription.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblSizeDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSizeDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSizeDescription.Location = new System.Drawing.Point(172, 10);
            this.lblSizeDescription.Name = "lblSizeDescription";
            this.lblSizeDescription.Size = new System.Drawing.Size(60, 20);
            this.lblSizeDescription.TabIndex = 21;
            this.lblSizeDescription.Text = "Sabor:";
            // 
            // txtSizeDescription
            // 
            this.txtSizeDescription.BackColor = System.Drawing.Color.SeaShell;
            this.txtSizeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizeDescription.Location = new System.Drawing.Point(176, 35);
            this.txtSizeDescription.Name = "txtSizeDescription";
            this.txtSizeDescription.Size = new System.Drawing.Size(448, 28);
            this.txtSizeDescription.TabIndex = 1;
            // 
            // lblSizeId
            // 
            this.lblSizeId.AutoSize = true;
            this.lblSizeId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblSizeId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSizeId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSizeId.Location = new System.Drawing.Point(12, 10);
            this.lblSizeId.Name = "lblSizeId";
            this.lblSizeId.Size = new System.Drawing.Size(71, 20);
            this.lblSizeId.TabIndex = 19;
            this.lblSizeId.Text = "Codigo:";
            // 
            // btnSizeSearch
            // 
            this.btnSizeSearch.Image = global::UserInterface.Properties.Resources.busca;
            this.btnSizeSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSizeSearch.Location = new System.Drawing.Point(122, 34);
            this.btnSizeSearch.Name = "btnSizeSearch";
            this.btnSizeSearch.Size = new System.Drawing.Size(26, 26);
            this.btnSizeSearch.TabIndex = 23;
            this.btnSizeSearch.UseVisualStyleBackColor = true;
            this.btnSizeSearch.Click += new System.EventHandler(this.BtnSizeSearch_Click);
            // 
            // txtSizeId
            // 
            this.txtSizeId.BackColor = System.Drawing.Color.SeaShell;
            this.txtSizeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSizeId.Location = new System.Drawing.Point(16, 34);
            this.txtSizeId.Name = "txtSizeId";
            this.txtSizeId.Size = new System.Drawing.Size(100, 28);
            this.txtSizeId.TabIndex = 0;
            this.txtSizeId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSizeId_Validating);
            // 
            // lblSaveOptimize
            // 
            this.lblSaveOptimize.AutoSize = true;
            this.lblSaveOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaveOptimize.Font = new System.Drawing.Font("Futura Bk BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveOptimize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaveOptimize.Location = new System.Drawing.Point(16, 249);
            this.lblSaveOptimize.Name = "lblSaveOptimize";
            this.lblSaveOptimize.Size = new System.Drawing.Size(0, 16);
            this.lblSaveOptimize.TabIndex = 29;
            // 
            // lblQtyFlavors
            // 
            this.lblQtyFlavors.AutoSize = true;
            this.lblQtyFlavors.Location = new System.Drawing.Point(630, 12);
            this.lblQtyFlavors.Name = "lblQtyFlavors";
            this.lblQtyFlavors.Size = new System.Drawing.Size(109, 20);
            this.lblQtyFlavors.TabIndex = 30;
            this.lblQtyFlavors.Text = "Qte. Sabores";
            // 
            // txtQtyFlavors
            // 
            this.txtQtyFlavors.BackColor = System.Drawing.Color.SeaShell;
            this.txtQtyFlavors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyFlavors.Location = new System.Drawing.Point(630, 35);
            this.txtQtyFlavors.Name = "txtQtyFlavors";
            this.txtQtyFlavors.Size = new System.Drawing.Size(150, 28);
            this.txtQtyFlavors.TabIndex = 2;
            // 
            // FrmPizzaSizeCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 276);
            this.Controls.Add(this.txtQtyFlavors);
            this.Controls.Add(this.lblQtyFlavors);
            this.Controls.Add(this.lblSaveOptimize);
            this.Controls.Add(this.txtSizeRemark);
            this.Controls.Add(this.lblSizeRemark);
            this.Controls.Add(this.lblSizeAdditionalPrice);
            this.Controls.Add(this.txtSizePriceAdditional);
            this.Controls.Add(this.szeStatus);
            this.Controls.Add(this.flwSizeCRUD);
            this.Controls.Add(this.lblSizeDescription);
            this.Controls.Add(this.txtSizeDescription);
            this.Controls.Add(this.lblSizeId);
            this.Controls.Add(this.btnSizeSearch);
            this.Controls.Add(this.txtSizeId);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaSizeCRUD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Sabores";
            this.Load += new System.EventHandler(this.FrmPizzaSizeCRUD_Load);
            this.flwSizeCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSizeRemark;
        private System.Windows.Forms.Label lblSizeRemark;
        private System.Windows.Forms.Label lblSizeAdditionalPrice;
        private System.Windows.Forms.TextBox txtSizePriceAdditional;
        private Controls.UserSituacaoCTRL szeStatus;
        private System.Windows.Forms.FlowLayoutPanel flwSizeCRUD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSizeDescription;
        private System.Windows.Forms.TextBox txtSizeDescription;
        private System.Windows.Forms.Label lblSizeId;
        private System.Windows.Forms.Button btnSizeSearch;
        private System.Windows.Forms.TextBox txtSizeId;
        private System.Windows.Forms.Label lblSaveOptimize;
        private System.Windows.Forms.Label lblQtyFlavors;
        private System.Windows.Forms.TextBox txtQtyFlavors;
    }
}