namespace BookRentalShop20
{
    partial class DivForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdDivTbl = new MetroFramework.Controls.MetroGrid();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.txtNames = new MetroFramework.Controls.MetroTextBox();
            this.txtDivision = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bookrentalshopDBDataSet = new BookRentalShop20.bookrentalshopDBDataSet();
            this.divtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divtblTableAdapter = new BookRentalShop20.bookrentalshopDBDataSetTableAdapters.divtblTableAdapter();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDivTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrentalshopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divtblBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.grdDivTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnNew);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.txtNames);
            this.splitContainer1.Panel2.Controls.Add(this.txtDivision);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel3);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 0;
            // 
            // grdDivTbl
            // 
            this.grdDivTbl.AllowUserToAddRows = false;
            this.grdDivTbl.AllowUserToResizeRows = false;
            this.grdDivTbl.AutoGenerateColumns = false;
            this.grdDivTbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDivTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDivTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDivTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDivTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDivTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDivTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.divisionDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn});
            this.grdDivTbl.DataSource = this.divtblBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDivTbl.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDivTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDivTbl.EnableHeadersVisualStyles = false;
            this.grdDivTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDivTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDivTbl.Location = new System.Drawing.Point(0, 0);
            this.grdDivTbl.Name = "grdDivTbl";
            this.grdDivTbl.ReadOnly = true;
            this.grdDivTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDivTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDivTbl.RowHeadersWidth = 51;
            this.grdDivTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDivTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDivTbl.Size = new System.Drawing.Size(372, 370);
            this.grdDivTbl.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseSelectable = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(102, 153);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "신규";
            this.btnNew.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(21, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseSelectable = true;
            // 
            // txtNames
            // 
            // 
            // 
            // 
            this.txtNames.CustomButton.Image = null;
            this.txtNames.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtNames.CustomButton.Name = "";
            this.txtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNames.CustomButton.TabIndex = 1;
            this.txtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNames.CustomButton.UseSelectable = true;
            this.txtNames.CustomButton.Visible = false;
            this.txtNames.Lines = new string[0];
            this.txtNames.Location = new System.Drawing.Point(111, 67);
            this.txtNames.MaxLength = 32767;
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNames.SelectedText = "";
            this.txtNames.SelectionLength = 0;
            this.txtNames.SelectionStart = 0;
            this.txtNames.ShortcutsEnabled = true;
            this.txtNames.Size = new System.Drawing.Size(200, 23);
            this.txtNames.TabIndex = 1;
            this.txtNames.UseSelectable = true;
            this.txtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNames.Click += new System.EventHandler(this.txtNames_Click);
            // 
            // txtDivision
            // 
            // 
            // 
            // 
            this.txtDivision.CustomButton.Image = null;
            this.txtDivision.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtDivision.CustomButton.Name = "";
            this.txtDivision.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDivision.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDivision.CustomButton.TabIndex = 1;
            this.txtDivision.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDivision.CustomButton.UseSelectable = true;
            this.txtDivision.CustomButton.Visible = false;
            this.txtDivision.Lines = new string[0];
            this.txtDivision.Location = new System.Drawing.Point(111, 27);
            this.txtDivision.MaxLength = 32767;
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.PasswordChar = '\0';
            this.txtDivision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDivision.SelectedText = "";
            this.txtDivision.SelectionLength = 0;
            this.txtDivision.SelectionStart = 0;
            this.txtDivision.ShortcutsEnabled = true;
            this.txtDivision.Size = new System.Drawing.Size(200, 23);
            this.txtDivision.TabIndex = 0;
            this.txtDivision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDivision.UseSelectable = true;
            this.txtDivision.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDivision.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(21, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "이름 :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(21, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "구분코드 :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookrentalshopDBDataSet
            // 
            this.bookrentalshopDBDataSet.DataSetName = "bookrentalshopDBDataSet";
            this.bookrentalshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // divtblBindingSource
            // 
            this.divtblBindingSource.DataMember = "divtbl";
            this.divtblBindingSource.DataSource = this.bookrentalshopDBDataSet;
            // 
            // divtblTableAdapter
            // 
            this.divtblTableAdapter.ClearBeforeFill = true;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Width = 125;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            this.namesDataGridViewTextBoxColumn.Width = 125;
            // 
            // DivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DivForm";
            this.Text = "DIVform";
            this.Load += new System.EventHandler(this.DivForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDivTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrentalshopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divtblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid grdDivTbl;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox txtNames;
        private MetroFramework.Controls.MetroTextBox txtDivision;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private bookrentalshopDBDataSet bookrentalshopDBDataSet;
        private System.Windows.Forms.BindingSource divtblBindingSource;
        private bookrentalshopDBDataSetTableAdapters.divtblTableAdapter divtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
    }
}