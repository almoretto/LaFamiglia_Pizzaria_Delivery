namespace UserInterface
{
    partial class MDIForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.mnsMdiPrincipal = new System.Windows.Forms.MenuStrip();
            this.ProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bordasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsFooter = new System.Windows.Forms.StatusStrip();
            this.strpStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMdiPrincipal.SuspendLayout();
            this.stsFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMdiPrincipal
            // 
            this.mnsMdiPrincipal.BackColor = System.Drawing.Color.White;
            this.mnsMdiPrincipal.Font = new System.Drawing.Font("Futura Md BT", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMdiPrincipal.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.mnsMdiPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.rotinasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.mnsMdiPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMdiPrincipal.Name = "mnsMdiPrincipal";
            this.mnsMdiPrincipal.Size = new System.Drawing.Size(1602, 28);
            this.mnsMdiPrincipal.TabIndex = 1;
            this.mnsMdiPrincipal.Text = "MenuPrincipal";
            // 
            // ProgramToolStripMenuItem
            // 
            this.ProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem";
            this.ProgramToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.ProgramToolStripMenuItem.Text = "Programa";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.ExitToolStripMenuItem.Text = "Sair";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PeopleToolStripMenuItem,
            this.ProductsToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // PeopleToolStripMenuItem
            // 
            this.PeopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientsToolStripMenuItem,
            this.UsersToolStripMenuItem});
            this.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            this.PeopleToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.PeopleToolStripMenuItem.Text = "Pessoas";
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ClientsToolStripMenuItem.Text = "Clientes";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.UsersToolStripMenuItem.Text = "Usuários";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdditionalToolStripMenuItem,
            this.saboresToolStripMenuItem});
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ProductsToolStripMenuItem.Text = "Produtos";
            // 
            // AdditionalToolStripMenuItem
            // 
            this.AdditionalToolStripMenuItem.Name = "AdditionalToolStripMenuItem";
            this.AdditionalToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.AdditionalToolStripMenuItem.Text = "Adicionais";
            this.AdditionalToolStripMenuItem.Click += new System.EventHandler(this.AddtionalToolStripMenuItem_Click);
            // 
            // saboresToolStripMenuItem
            // 
            this.saboresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saboresToolStripMenuItem1,
            this.bordasToolStripMenuItem,
            this.tamanhosToolStripMenuItem});
            this.saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            this.saboresToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.saboresToolStripMenuItem.Text = "Pizzas";
            // 
            // saboresToolStripMenuItem1
            // 
            this.saboresToolStripMenuItem1.Name = "saboresToolStripMenuItem1";
            this.saboresToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.saboresToolStripMenuItem1.Text = "Sabores";
            this.saboresToolStripMenuItem1.Click += new System.EventHandler(this.SaboresToolStripMenuItem1_Click);
            // 
            // bordasToolStripMenuItem
            // 
            this.bordasToolStripMenuItem.Name = "bordasToolStripMenuItem";
            this.bordasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.bordasToolStripMenuItem.Text = "Bordas";
            this.bordasToolStripMenuItem.Click += new System.EventHandler(this.BordasToolStripMenuItem_Click);
            // 
            // tamanhosToolStripMenuItem
            // 
            this.tamanhosToolStripMenuItem.Name = "tamanhosToolStripMenuItem";
            this.tamanhosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tamanhosToolStripMenuItem.Text = "Tamanhos";
            this.tamanhosToolStripMenuItem.Click += new System.EventHandler(this.TamanhosToolStripMenuItem_Click);
            // 
            // rotinasToolStripMenuItem
            // 
            this.rotinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem});
            this.rotinasToolStripMenuItem.Name = "rotinasToolStripMenuItem";
            this.rotinasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.rotinasToolStripMenuItem.Text = "Rotinas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // stsFooter
            // 
            this.stsFooter.BackColor = System.Drawing.Color.White;
            this.stsFooter.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsFooter.GripMargin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stsFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpStatusLabel});
            this.stsFooter.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.stsFooter.Location = new System.Drawing.Point(0, 1013);
            this.stsFooter.Name = "stsFooter";
            this.stsFooter.Size = new System.Drawing.Size(1602, 26);
            this.stsFooter.TabIndex = 3;
            // 
            // strpStatusLabel
            // 
            this.strpStatusLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.strpStatusLabel.BackColor = System.Drawing.Color.SeaShell;
            this.strpStatusLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.strpStatusLabel.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strpStatusLabel.ForeColor = System.Drawing.Color.DimGray;
            this.strpStatusLabel.Name = "strpStatusLabel";
            this.strpStatusLabel.Size = new System.Drawing.Size(148, 20);
            this.strpStatusLabel.Text = "System Opening...";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1602, 1039);
            this.Controls.Add(this.stsFooter);
            this.Controls.Add(this.mnsMdiPrincipal);
            this.Font = new System.Drawing.Font("Futura Md BT", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMdiPrincipal;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MDIForm";
            this.Text = "La Famiglia Pizzeria Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.mnsMdiPrincipal.ResumeLayout(false);
            this.mnsMdiPrincipal.PerformLayout();
            this.stsFooter.ResumeLayout(false);
            this.stsFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMdiPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdditionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saboresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saboresToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip stsFooter;
        private System.Windows.Forms.ToolStripStatusLabel strpStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem bordasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamanhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
    }
}

