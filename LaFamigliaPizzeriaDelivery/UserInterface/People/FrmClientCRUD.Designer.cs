
namespace UserInterface.People
{
    partial class FrmClientCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientCRUD));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnClientSearch = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.uscStatus = new UserInterface.Controls.UserSituacaoCTRL();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mTxtCellPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.btnAddressEdit = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.lstAddresses = new System.Windows.Forms.ListView();
            this.btnAddressSave = new System.Windows.Forms.Button();
            this.chkStdAddress = new System.Windows.Forms.CheckBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress2nd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtStNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Name = "lblUserName";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.SeaShell;
            resources.ApplyResources(this.txtClientName, "txtClientName");
            this.txtClientName.Name = "txtClientName";
            // 
            // lblUserId
            // 
            resources.ApplyResources(this.lblUserId, "lblUserId");
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserId.Name = "lblUserId";
            // 
            // btnClientSearch
            // 
            this.btnClientSearch.Image = global::UserInterface.Properties.Resources.busca;
            resources.ApplyResources(this.btnClientSearch, "btnClientSearch");
            this.btnClientSearch.Name = "btnClientSearch";
            this.btnClientSearch.UseVisualStyleBackColor = true;
            this.btnClientSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.BackColor = System.Drawing.Color.SeaShell;
            resources.ApplyResources(this.txtClientId, "txtClientId");
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Validating += new System.ComponentModel.CancelEventHandler(this.txtClientId_Validating);
            // 
            // uscStatus
            // 
            this.uscStatus.BackColor = System.Drawing.Color.Bisque;
            resources.ApplyResources(this.uscStatus, "uscStatus");
            this.uscStatus.Name = "uscStatus";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Image = global::UserInterface.Properties.Resources.cancelar;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Image = global::UserInterface.Properties.Resources.excluir;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = global::UserInterface.Properties.Resources.confirmar;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // mTxtPhone
            // 
            this.mTxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.mTxtPhone, "mTxtPhone");
            this.mTxtPhone.Name = "mTxtPhone";
            // 
            // mTxtCellPhone
            // 
            this.mTxtCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.mTxtCellPhone, "mTxtCellPhone");
            this.mTxtCellPhone.Name = "mTxtCellPhone";
            // 
            // lblCellPhone
            // 
            resources.ApplyResources(this.lblCellPhone, "lblCellPhone");
            this.lblCellPhone.Name = "lblCellPhone";
            // 
            // grpAddress
            // 
            this.grpAddress.BackColor = System.Drawing.Color.Snow;
            this.grpAddress.Controls.Add(this.btnAddressEdit);
            this.grpAddress.Controls.Add(this.btnDeleteAddress);
            this.grpAddress.Controls.Add(this.lstAddresses);
            this.grpAddress.Controls.Add(this.btnAddressSave);
            this.grpAddress.Controls.Add(this.chkStdAddress);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.label3);
            this.grpAddress.Controls.Add(this.txtAddress2nd);
            this.grpAddress.Controls.Add(this.label2);
            this.grpAddress.Controls.Add(this.txtDistrict);
            this.grpAddress.Controls.Add(this.lblDistrict);
            this.grpAddress.Controls.Add(this.txtStNumber);
            this.grpAddress.Controls.Add(this.label1);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Controls.Add(this.lblAddress);
            this.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grpAddress, "grpAddress");
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.TabStop = false;
            // 
            // btnAddressEdit
            // 
            this.btnAddressEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.btnAddressEdit, "btnAddressEdit");
            this.btnAddressEdit.Image = global::UserInterface.Properties.Resources.editar;
            this.btnAddressEdit.Name = "btnAddressEdit";
            this.btnAddressEdit.UseVisualStyleBackColor = false;
            this.btnAddressEdit.Click += new System.EventHandler(this.btnAddressEdit_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.btnDeleteAddress, "btnDeleteAddress");
            this.btnDeleteAddress.Image = global::UserInterface.Properties.Resources.excluir;
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // lstAddresses
            // 
            this.lstAddresses.BackColor = System.Drawing.SystemColors.Window;
            this.lstAddresses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAddresses.FullRowSelect = true;
            this.lstAddresses.GridLines = true;
            this.lstAddresses.HideSelection = false;
            resources.ApplyResources(this.lstAddresses, "lstAddresses");
            this.lstAddresses.Name = "lstAddresses";
            this.lstAddresses.UseCompatibleStateImageBehavior = false;
            this.lstAddresses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstAddresses_ItemCheck);
            this.lstAddresses.DoubleClick += new System.EventHandler(this.lstAddresses_DoubleClick);
            this.lstAddresses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAddresses_MouseDown);
            this.lstAddresses.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstAddresses_MouseUp);
            // 
            // btnAddressSave
            // 
            this.btnAddressSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnAddressSave, "btnAddressSave");
            this.btnAddressSave.Image = global::UserInterface.Properties.Resources.confirmar;
            this.btnAddressSave.Name = "btnAddressSave";
            this.btnAddressSave.UseVisualStyleBackColor = false;
            this.btnAddressSave.Click += new System.EventHandler(this.btnAddressSave_Click);
            // 
            // chkStdAddress
            // 
            resources.ApplyResources(this.chkStdAddress, "chkStdAddress");
            this.chkStdAddress.Name = "chkStdAddress";
            this.chkStdAddress.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.SeaShell;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.Name = "txtCity";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtAddress2nd
            // 
            this.txtAddress2nd.BackColor = System.Drawing.Color.White;
            this.txtAddress2nd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAddress2nd, "txtAddress2nd");
            this.txtAddress2nd.Name = "txtAddress2nd";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.SeaShell;
            this.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtDistrict, "txtDistrict");
            this.txtDistrict.Name = "txtDistrict";
            // 
            // lblDistrict
            // 
            resources.ApplyResources(this.lblDistrict, "lblDistrict");
            this.lblDistrict.Name = "lblDistrict";
            // 
            // txtStNumber
            // 
            this.txtStNumber.BackColor = System.Drawing.Color.SeaShell;
            this.txtStNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtStNumber, "txtStNumber");
            this.txtStNumber.Name = "txtStNumber";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.SeaShell;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // lblAddress
            // 
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.Name = "lblAddress";
            // 
            // FrmClientCRUD
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.mTxtCellPhone);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.mTxtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.uscStatus);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnClientSearch);
            this.Controls.Add(this.txtClientId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientCRUD";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmClientCRUD_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnClientSearch;
        private System.Windows.Forms.TextBox txtClientId;
        private Controls.UserSituacaoCTRL uscStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mTxtPhone;
        private System.Windows.Forms.MaskedTextBox mTxtCellPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtStNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStdAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress2nd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Button btnAddressEdit;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.ListView lstAddresses;
        private System.Windows.Forms.Button btnAddressSave;
    }
}