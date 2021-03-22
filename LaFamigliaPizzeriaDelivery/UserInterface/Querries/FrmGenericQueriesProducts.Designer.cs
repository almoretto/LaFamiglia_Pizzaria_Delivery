
namespace UserInterface.Querries
{
    partial class FrmGenericQueriesProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenericQueriesProducts));
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lstResult = new System.Windows.Forms.ListView();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.rbtAllInactive = new System.Windows.Forms.RadioButton();
            this.rbtAllActive = new System.Windows.Forms.RadioButton();
            this.txtGenericSearch = new System.Windows.Forms.TextBox();
            this.lblGenericsearch = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.grbResult.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbResult
            // 
            this.grbResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbResult.Controls.Add(this.lstResult);
            this.grbResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbResult.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResult.Location = new System.Drawing.Point(17, 109);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(555, 430);
            this.grbResult.TabIndex = 9;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultado da Pesquisa";
            // 
            // lstResult
            // 
            this.lstResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResult.Font = new System.Drawing.Font("Futura Md BT", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FullRowSelect = true;
            this.lstResult.GridLines = true;
            this.lstResult.HideSelection = false;
            this.lstResult.Location = new System.Drawing.Point(3, 24);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(549, 403);
            this.lstResult.TabIndex = 0;
            this.lstResult.UseCompatibleStateImageBehavior = false;
            this.lstResult.DoubleClick += new System.EventHandler(this.LstResult_DoubleClick);
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rbtAll);
            this.grbStatus.Controls.Add(this.rbtAllInactive);
            this.grbStatus.Controls.Add(this.rbtAllActive);
            this.grbStatus.Location = new System.Drawing.Point(17, 49);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(272, 53);
            this.grbStatus.TabIndex = 8;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Situação";
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Location = new System.Drawing.Point(187, 22);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(76, 24);
            this.rbtAll.TabIndex = 2;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "Todos";
            this.rbtAll.UseVisualStyleBackColor = true;
            this.rbtAll.CheckedChanged += new System.EventHandler(this.RbtAll_CheckedChanged);
            // 
            // rbtAllInactive
            // 
            this.rbtAllInactive.AutoSize = true;
            this.rbtAllInactive.Location = new System.Drawing.Point(98, 22);
            this.rbtAllInactive.Name = "rbtAllInactive";
            this.rbtAllInactive.Size = new System.Drawing.Size(89, 24);
            this.rbtAllInactive.TabIndex = 1;
            this.rbtAllInactive.TabStop = true;
            this.rbtAllInactive.Text = "Inativos";
            this.rbtAllInactive.UseVisualStyleBackColor = true;
            this.rbtAllInactive.CheckedChanged += new System.EventHandler(this.RbtAllInactive_CheckedChanged);
            // 
            // rbtAllActive
            // 
            this.rbtAllActive.AutoSize = true;
            this.rbtAllActive.Location = new System.Drawing.Point(21, 22);
            this.rbtAllActive.Name = "rbtAllActive";
            this.rbtAllActive.Size = new System.Drawing.Size(75, 24);
            this.rbtAllActive.TabIndex = 0;
            this.rbtAllActive.TabStop = true;
            this.rbtAllActive.Text = "Ativos";
            this.rbtAllActive.UseVisualStyleBackColor = true;
            this.rbtAllActive.CheckedChanged += new System.EventHandler(this.RbtAllActive_CheckedChanged);
            // 
            // txtGenericSearch
            // 
            this.txtGenericSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGenericSearch.Location = new System.Drawing.Point(91, 12);
            this.txtGenericSearch.Name = "txtGenericSearch";
            this.txtGenericSearch.Size = new System.Drawing.Size(481, 28);
            this.txtGenericSearch.TabIndex = 7;
            this.txtGenericSearch.TextChanged += new System.EventHandler(this.TxtGenericSearch_TextChanged);
            // 
            // lblGenericsearch
            // 
            this.lblGenericsearch.AutoSize = true;
            this.lblGenericsearch.Location = new System.Drawing.Point(13, 12);
            this.lblGenericsearch.Name = "lblGenericsearch";
            this.lblGenericsearch.Size = new System.Drawing.Size(75, 20);
            this.lblGenericsearch.TabIndex = 6;
            this.lblGenericsearch.Text = "Pesquisa";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmation);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(337, 545);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 62);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(127, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmation.Image")));
            this.btnConfirmation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmation.Location = new System.Drawing.Point(16, 3);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(105, 50);
            this.btnConfirmation.TabIndex = 1;
            this.btnConfirmation.Text = "Confirmar";
            this.btnConfirmation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // FrmGenericQueriesProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 609);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.txtGenericSearch);
            this.Controls.Add(this.lblGenericsearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGenericQueriesProducts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.FrmGenericQueriesProducts_Load);
            this.grbResult.ResumeLayout(false);
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListView lstResult;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtAllInactive;
        private System.Windows.Forms.RadioButton rbtAllActive;
        private System.Windows.Forms.TextBox txtGenericSearch;
        private System.Windows.Forms.Label lblGenericsearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirmation;
        public System.Windows.Forms.GroupBox grbStatus;
    }
}