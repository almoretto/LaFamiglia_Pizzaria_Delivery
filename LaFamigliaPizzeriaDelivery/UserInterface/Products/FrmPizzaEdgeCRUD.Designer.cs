
namespace UserInterface.Products
{
    partial class FrmPizzaEdgeCRUD
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
            this.txtEdgeRemark = new System.Windows.Forms.TextBox();
            this.lblEdgeRemark = new System.Windows.Forms.Label();
            this.lblEdgeAdditionalPrice = new System.Windows.Forms.Label();
            this.txtEdgeAdditionalPrice = new System.Windows.Forms.TextBox();
            this.edgeStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.flwEdgeCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEdgeDescription = new System.Windows.Forms.Label();
            this.txtEdgeDescription = new System.Windows.Forms.TextBox();
            this.lblEdgeId = new System.Windows.Forms.Label();
            this.btnEdgeSearch = new System.Windows.Forms.Button();
            this.txtEdgeId = new System.Windows.Forms.TextBox();
            this.lblSaveOptimize = new System.Windows.Forms.Label();
            this.flwEdgeCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEdgeRemark
            // 
            this.txtEdgeRemark.BackColor = System.Drawing.Color.White;
            this.txtEdgeRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdgeRemark.Font = new System.Drawing.Font("Futura Md BT", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdgeRemark.Location = new System.Drawing.Point(176, 98);
            this.txtEdgeRemark.Multiline = true;
            this.txtEdgeRemark.Name = "txtEdgeRemark";
            this.txtEdgeRemark.Size = new System.Drawing.Size(604, 110);
            this.txtEdgeRemark.TabIndex = 2;
            // 
            // lblEdgeRemark
            // 
            this.lblEdgeRemark.AutoSize = true;
            this.lblEdgeRemark.Location = new System.Drawing.Point(172, 73);
            this.lblEdgeRemark.Name = "lblEdgeRemark";
            this.lblEdgeRemark.Size = new System.Drawing.Size(108, 20);
            this.lblEdgeRemark.TabIndex = 28;
            this.lblEdgeRemark.Text = "Observação:";
            // 
            // lblEdgeAdditionalPrice
            // 
            this.lblEdgeAdditionalPrice.AutoSize = true;
            this.lblEdgeAdditionalPrice.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblEdgeAdditionalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdgeAdditionalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEdgeAdditionalPrice.Location = new System.Drawing.Point(172, 217);
            this.lblEdgeAdditionalPrice.Name = "lblEdgeAdditionalPrice";
            this.lblEdgeAdditionalPrice.Size = new System.Drawing.Size(132, 20);
            this.lblEdgeAdditionalPrice.TabIndex = 26;
            this.lblEdgeAdditionalPrice.Text = "Valor Adicional:";
            // 
            // txtEdgeAdditionalPrice
            // 
            this.txtEdgeAdditionalPrice.BackColor = System.Drawing.Color.White;
            this.txtEdgeAdditionalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdgeAdditionalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEdgeAdditionalPrice.Location = new System.Drawing.Point(176, 239);
            this.txtEdgeAdditionalPrice.Name = "txtEdgeAdditionalPrice";
            this.txtEdgeAdditionalPrice.Size = new System.Drawing.Size(258, 28);
            this.txtEdgeAdditionalPrice.TabIndex = 3;
            // 
            // edgeStatus
            // 
            this.edgeStatus.BackColor = System.Drawing.Color.Bisque;
            this.edgeStatus.Font = new System.Drawing.Font("Futura Bk BT", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeStatus.Location = new System.Drawing.Point(16, 73);
            this.edgeStatus.Margin = new System.Windows.Forms.Padding(32, 21, 32, 21);
            this.edgeStatus.MaximumSize = new System.Drawing.Size(146, 135);
            this.edgeStatus.MinimumSize = new System.Drawing.Size(140, 130);
            this.edgeStatus.Name = "edgeStatus";
            this.edgeStatus.Padding = new System.Windows.Forms.Padding(10);
            this.edgeStatus.Size = new System.Drawing.Size(145, 135);
            this.edgeStatus.TabIndex = 4;
            // 
            // flwEdgeCRUD
            // 
            this.flwEdgeCRUD.Controls.Add(this.btnCancel);
            this.flwEdgeCRUD.Controls.Add(this.btnDelete);
            this.flwEdgeCRUD.Controls.Add(this.btnSave);
            this.flwEdgeCRUD.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwEdgeCRUD.Location = new System.Drawing.Point(455, 214);
            this.flwEdgeCRUD.Name = "flwEdgeCRUD";
            this.flwEdgeCRUD.Size = new System.Drawing.Size(325, 50);
            this.flwEdgeCRUD.TabIndex = 5;
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
            // lblEdgeDescription
            // 
            this.lblEdgeDescription.AutoSize = true;
            this.lblEdgeDescription.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblEdgeDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdgeDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEdgeDescription.Location = new System.Drawing.Point(172, 10);
            this.lblEdgeDescription.Name = "lblEdgeDescription";
            this.lblEdgeDescription.Size = new System.Drawing.Size(60, 20);
            this.lblEdgeDescription.TabIndex = 21;
            this.lblEdgeDescription.Text = "Sabor:";
            // 
            // txtEdgeDescription
            // 
            this.txtEdgeDescription.BackColor = System.Drawing.Color.SeaShell;
            this.txtEdgeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdgeDescription.Location = new System.Drawing.Point(176, 35);
            this.txtEdgeDescription.Name = "txtEdgeDescription";
            this.txtEdgeDescription.Size = new System.Drawing.Size(604, 28);
            this.txtEdgeDescription.TabIndex = 1;
            // 
            // lblEdgeId
            // 
            this.lblEdgeId.AutoSize = true;
            this.lblEdgeId.Font = new System.Drawing.Font("Futura Md BT", 10.18868F);
            this.lblEdgeId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdgeId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEdgeId.Location = new System.Drawing.Point(12, 10);
            this.lblEdgeId.Name = "lblEdgeId";
            this.lblEdgeId.Size = new System.Drawing.Size(71, 20);
            this.lblEdgeId.TabIndex = 19;
            this.lblEdgeId.Text = "Codigo:";
            // 
            // btnEdgeSearch
            // 
            this.btnEdgeSearch.Image = global::UserInterface.Properties.Resources.busca;
            this.btnEdgeSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdgeSearch.Location = new System.Drawing.Point(122, 34);
            this.btnEdgeSearch.Name = "btnEdgeSearch";
            this.btnEdgeSearch.Size = new System.Drawing.Size(26, 26);
            this.btnEdgeSearch.TabIndex = 23;
            this.btnEdgeSearch.UseVisualStyleBackColor = true;
            this.btnEdgeSearch.Click += new System.EventHandler(this.BtnEdgeSearch_Click);
            // 
            // txtEdgeId
            // 
            this.txtEdgeId.BackColor = System.Drawing.Color.SeaShell;
            this.txtEdgeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdgeId.Location = new System.Drawing.Point(16, 34);
            this.txtEdgeId.Name = "txtEdgeId";
            this.txtEdgeId.Size = new System.Drawing.Size(100, 28);
            this.txtEdgeId.TabIndex = 0;
            this.txtEdgeId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEdgeId_Validating);
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
            // FrmPizzaEdgeCRUD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 276);
            this.Controls.Add(this.lblSaveOptimize);
            this.Controls.Add(this.txtEdgeRemark);
            this.Controls.Add(this.lblEdgeRemark);
            this.Controls.Add(this.lblEdgeAdditionalPrice);
            this.Controls.Add(this.txtEdgeAdditionalPrice);
            this.Controls.Add(this.edgeStatus);
            this.Controls.Add(this.flwEdgeCRUD);
            this.Controls.Add(this.lblEdgeDescription);
            this.Controls.Add(this.txtEdgeDescription);
            this.Controls.Add(this.lblEdgeId);
            this.Controls.Add(this.btnEdgeSearch);
            this.Controls.Add(this.txtEdgeId);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaEdgeCRUD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Sabores de Bordas";
            this.Load += new System.EventHandler(this.FrmPizzaEdgeCRUD_Load);
            this.flwEdgeCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdgeRemark;
        private System.Windows.Forms.Label lblEdgeRemark;
        private System.Windows.Forms.Label lblEdgeAdditionalPrice;
        private System.Windows.Forms.TextBox txtEdgeAdditionalPrice;
        private Controls.UserSituacaoCTRL edgeStatus;
        private System.Windows.Forms.FlowLayoutPanel flwEdgeCRUD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEdgeDescription;
        private System.Windows.Forms.TextBox txtEdgeDescription;
        private System.Windows.Forms.Label lblEdgeId;
        private System.Windows.Forms.Button btnEdgeSearch;
        private System.Windows.Forms.TextBox txtEdgeId;
        private System.Windows.Forms.Label lblSaveOptimize;
    }
}