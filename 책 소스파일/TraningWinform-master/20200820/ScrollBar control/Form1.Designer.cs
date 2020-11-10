namespace ScrollBar_control
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrRed = new System.Windows.Forms.HScrollBar();
            this.scrGreen = new System.Windows.Forms.HScrollBar();
            this.scrBlue = new System.Windows.Forms.HScrollBar();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(101, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 174);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(98, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(98, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(98, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue";
            // 
            // scrRed
            // 
            this.scrRed.Location = new System.Drawing.Point(167, 265);
            this.scrRed.Name = "scrRed";
            this.scrRed.Size = new System.Drawing.Size(400, 35);
            this.scrRed.TabIndex = 2;
            this.scrRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrGreen
            // 
            this.scrGreen.Location = new System.Drawing.Point(167, 321);
            this.scrGreen.Name = "scrGreen";
            this.scrGreen.Size = new System.Drawing.Size(400, 35);
            this.scrGreen.TabIndex = 2;
            this.scrGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrBlue
            // 
            this.scrBlue.Location = new System.Drawing.Point(167, 373);
            this.scrBlue.Name = "scrBlue";
            this.scrBlue.Size = new System.Drawing.Size(400, 35);
            this.scrBlue.TabIndex = 2;
            this.scrBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // txtRed
            // 
            this.txtRed.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRed.Location = new System.Drawing.Point(595, 273);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 29);
            this.txtRed.TabIndex = 3;
            this.txtRed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtGreen
            // 
            this.txtGreen.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGreen.Location = new System.Drawing.Point(595, 326);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 29);
            this.txtGreen.TabIndex = 3;
            this.txtGreen.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtBlue
            // 
            this.txtBlue.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBlue.Location = new System.Drawing.Point(595, 379);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(100, 29);
            this.txtBlue.TabIndex = 3;
            this.txtBlue.TextAlignChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.scrBlue);
            this.Controls.Add(this.scrGreen);
            this.Controls.Add(this.scrRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RGB ScrollBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar scrRed;
        private System.Windows.Forms.HScrollBar scrGreen;
        private System.Windows.Forms.HScrollBar scrBlue;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
    }
}

