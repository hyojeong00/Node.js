namespace MainForm
{
    partial class AdListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdProductTbl = new MetroFramework.Controls.MetroGrid();
            this.txtBenefits = new MetroFramework.Controls.MetroTextBox();
            this.lblBenefits = new MetroFramework.Controls.MetroLabel();
            this.txtData = new MetroFramework.Controls.MetroTextBox();
            this.lbkData = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.txtCompany = new MetroFramework.Controls.MetroTextBox();
            this.lblCompany = new MetroFramework.Controls.MetroLabel();
            this.txtPlans = new MetroFramework.Controls.MetroTextBox();
            this.lblPlans = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProductTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdProductTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtBenefits);
            this.splitContainer1.Panel2.Controls.Add(this.lblBenefits);
            this.splitContainer1.Panel2.Controls.Add(this.txtData);
            this.splitContainer1.Panel2.Controls.Add(this.lbkData);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrice);
            this.splitContainer1.Panel2.Controls.Add(this.lblPrice);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompany);
            this.splitContainer1.Panel2.Controls.Add(this.lblCompany);
            this.splitContainer1.Panel2.Controls.Add(this.txtPlans);
            this.splitContainer1.Panel2.Controls.Add(this.lblPlans);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnNew);
            this.splitContainer1.Size = new System.Drawing.Size(860, 451);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdProductTbl
            // 
            this.GrdProductTbl.AllowUserToResizeRows = false;
            this.GrdProductTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdProductTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdProductTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdProductTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdProductTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GrdProductTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdProductTbl.DefaultCellStyle = dataGridViewCellStyle14;
            this.GrdProductTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdProductTbl.EnableHeadersVisualStyles = false;
            this.GrdProductTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdProductTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdProductTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdProductTbl.Name = "GrdProductTbl";
            this.GrdProductTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdProductTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GrdProductTbl.RowHeadersWidth = 51;
            this.GrdProductTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdProductTbl.RowTemplate.Height = 27;
            this.GrdProductTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdProductTbl.Size = new System.Drawing.Size(432, 451);
            this.GrdProductTbl.TabIndex = 0;
            this.GrdProductTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProductTbl_CellClick);
            // 
            // txtBenefits
            // 
            // 
            // 
            // 
            this.txtBenefits.CustomButton.Image = null;
            this.txtBenefits.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtBenefits.CustomButton.Name = "";
            this.txtBenefits.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBenefits.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBenefits.CustomButton.TabIndex = 1;
            this.txtBenefits.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBenefits.CustomButton.UseSelectable = true;
            this.txtBenefits.CustomButton.Visible = false;
            this.txtBenefits.Lines = new string[0];
            this.txtBenefits.Location = new System.Drawing.Point(145, 304);
            this.txtBenefits.MaxLength = 50;
            this.txtBenefits.Name = "txtBenefits";
            this.txtBenefits.PasswordChar = '\0';
            this.txtBenefits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBenefits.SelectedText = "";
            this.txtBenefits.SelectionLength = 0;
            this.txtBenefits.SelectionStart = 0;
            this.txtBenefits.ShortcutsEnabled = true;
            this.txtBenefits.Size = new System.Drawing.Size(198, 23);
            this.txtBenefits.TabIndex = 4;
            this.txtBenefits.UseSelectable = true;
            this.txtBenefits.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBenefits.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBenefits
            // 
            this.lblBenefits.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBenefits.Location = new System.Drawing.Point(41, 304);
            this.lblBenefits.Name = "lblBenefits";
            this.lblBenefits.Size = new System.Drawing.Size(84, 20);
            this.lblBenefits.TabIndex = 4;
            this.lblBenefits.Text = "혜택 : ";
            this.lblBenefits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtData
            // 
            // 
            // 
            // 
            this.txtData.CustomButton.Image = null;
            this.txtData.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtData.CustomButton.Name = "";
            this.txtData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtData.CustomButton.TabIndex = 1;
            this.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtData.CustomButton.UseSelectable = true;
            this.txtData.CustomButton.Visible = false;
            this.txtData.Lines = new string[0];
            this.txtData.Location = new System.Drawing.Point(145, 240);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(198, 23);
            this.txtData.TabIndex = 3;
            this.txtData.UseSelectable = true;
            this.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbkData
            // 
            this.lbkData.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbkData.Location = new System.Drawing.Point(41, 240);
            this.lbkData.Name = "lbkData";
            this.lbkData.Size = new System.Drawing.Size(84, 20);
            this.lbkData.TabIndex = 4;
            this.lbkData.Text = "데이터 : ";
            this.lbkData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(145, 176);
            this.txtPrice.MaxLength = 20;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(198, 23);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrice
            // 
            this.lblPrice.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPrice.Location = new System.Drawing.Point(41, 176);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "가격 : ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompany
            // 
            // 
            // 
            // 
            this.txtCompany.CustomButton.Image = null;
            this.txtCompany.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtCompany.CustomButton.Name = "";
            this.txtCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompany.CustomButton.TabIndex = 1;
            this.txtCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompany.CustomButton.UseSelectable = true;
            this.txtCompany.CustomButton.Visible = false;
            this.txtCompany.Lines = new string[0];
            this.txtCompany.Location = new System.Drawing.Point(145, 112);
            this.txtCompany.MaxLength = 20;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompany.SelectedText = "";
            this.txtCompany.SelectionLength = 0;
            this.txtCompany.SelectionStart = 0;
            this.txtCompany.ShortcutsEnabled = true;
            this.txtCompany.Size = new System.Drawing.Size(198, 23);
            this.txtCompany.TabIndex = 1;
            this.txtCompany.UseSelectable = true;
            this.txtCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCompany
            // 
            this.lblCompany.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCompany.Location = new System.Drawing.Point(41, 112);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(84, 20);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "통신사 : ";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlans
            // 
            // 
            // 
            // 
            this.txtPlans.CustomButton.Image = null;
            this.txtPlans.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPlans.CustomButton.Name = "";
            this.txtPlans.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlans.CustomButton.TabIndex = 1;
            this.txtPlans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlans.CustomButton.UseSelectable = true;
            this.txtPlans.CustomButton.Visible = false;
            this.txtPlans.Lines = new string[0];
            this.txtPlans.Location = new System.Drawing.Point(145, 48);
            this.txtPlans.MaxLength = 50;
            this.txtPlans.Name = "txtPlans";
            this.txtPlans.PasswordChar = '\0';
            this.txtPlans.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlans.SelectedText = "";
            this.txtPlans.SelectionLength = 0;
            this.txtPlans.SelectionStart = 0;
            this.txtPlans.ShortcutsEnabled = true;
            this.txtPlans.Size = new System.Drawing.Size(198, 23);
            this.txtPlans.TabIndex = 0;
            this.txtPlans.UseSelectable = true;
            this.txtPlans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPlans
            // 
            this.lblPlans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPlans.Location = new System.Drawing.Point(41, 48);
            this.lblPlans.Name = "lblPlans";
            this.lblPlans.Size = new System.Drawing.Size(84, 20);
            this.lblPlans.TabIndex = 4;
            this.lblPlans.Text = "요금제 : ";
            this.lblPlans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 58);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 58);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 58);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 372);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 58);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // AdListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 531);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdListForm";
            this.Text = "목록관리";
            this.Load += new System.EventHandler(this.AdListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProductTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid GrdProductTbl;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroTextBox txtBenefits;
        private MetroFramework.Controls.MetroLabel lblBenefits;
        private MetroFramework.Controls.MetroTextBox txtData;
        private MetroFramework.Controls.MetroLabel lbkData;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroTextBox txtCompany;
        private MetroFramework.Controls.MetroLabel lblCompany;
        private MetroFramework.Controls.MetroTextBox txtPlans;
        private MetroFramework.Controls.MetroLabel lblPlans;
    }
}