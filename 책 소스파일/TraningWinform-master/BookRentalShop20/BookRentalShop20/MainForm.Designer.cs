namespace BookRentalShop20
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemDivMng = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUserMng = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.책관리BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.렌탈관리RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인관리MToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인관리MToolStripMenuItem
            // 
            this.메인관리MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemDivMng,
            this.MnuUserMng,
            this.회원관리MToolStripMenuItem,
            this.책관리BToolStripMenuItem,
            this.렌탈관리RToolStripMenuItem});
            this.메인관리MToolStripMenuItem.Font = new System.Drawing.Font("Neo둥근모", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인관리MToolStripMenuItem.Name = "메인관리MToolStripMenuItem";
            this.메인관리MToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.메인관리MToolStripMenuItem.Text = "메인관리(&M)";
            // 
            // MnuItemDivMng
            // 
            this.MnuItemDivMng.Name = "MnuItemDivMng";
            this.MnuItemDivMng.Size = new System.Drawing.Size(242, 26);
            this.MnuItemDivMng.Text = "구분코드관리(&D)";
            this.MnuItemDivMng.Click += new System.EventHandler(this.MnuItemDivMng_Click);
            // 
            // MnuUserMng
            // 
            this.MnuUserMng.Name = "MnuUserMng";
            this.MnuUserMng.Size = new System.Drawing.Size(242, 26);
            this.MnuUserMng.Text = "사용자관리(&U)";
            this.MnuUserMng.Click += new System.EventHandler(this.MnuUserMng_Click);
            // 
            // 회원관리MToolStripMenuItem
            // 
            this.회원관리MToolStripMenuItem.Name = "회원관리MToolStripMenuItem";
            this.회원관리MToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.회원관리MToolStripMenuItem.Text = "회원관리(&M)";
            this.회원관리MToolStripMenuItem.Click += new System.EventHandler(this.회원관리MToolStripMenuItem_Click);
            // 
            // 책관리BToolStripMenuItem
            // 
            this.책관리BToolStripMenuItem.Name = "책관리BToolStripMenuItem";
            this.책관리BToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.책관리BToolStripMenuItem.Text = "책관리(&B)";
            this.책관리BToolStripMenuItem.Click += new System.EventHandler(this.책관리BToolStripMenuItem_Click);
            // 
            // 렌탈관리RToolStripMenuItem
            // 
            this.렌탈관리RToolStripMenuItem.Name = "렌탈관리RToolStripMenuItem";
            this.렌탈관리RToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.렌탈관리RToolStripMenuItem.Text = "대여관리(&R)";
            this.렌탈관리RToolStripMenuItem.Click += new System.EventHandler(this.렌탈관리RToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo둥근모", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(539, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "접속아이디 : ";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Neo둥근모", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserId.Location = new System.Drawing.Point(656, 60);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 15);
            this.lblUserId.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "BookRentalShop v1.0";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDivMng;
        private System.Windows.Forms.ToolStripMenuItem MnuUserMng;
        private System.Windows.Forms.ToolStripMenuItem 회원관리MToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ToolStripMenuItem 책관리BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 렌탈관리RToolStripMenuItem;
    }
}

