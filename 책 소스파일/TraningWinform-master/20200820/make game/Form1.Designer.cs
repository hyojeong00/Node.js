namespace make_game
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblRand1 = new System.Windows.Forms.Label();
            this.lblRand2 = new System.Windows.Forms.Label();
            this.lblRand3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStrike = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBall = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInput1.Location = new System.Drawing.Point(177, 156);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 36);
            this.txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInput2.Location = new System.Drawing.Point(342, 156);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 36);
            this.txtInput2.TabIndex = 1;
            // 
            // txtInput3
            // 
            this.txtInput3.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInput3.Location = new System.Drawing.Point(507, 153);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(100, 36);
            this.txtInput3.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRun.Location = new System.Drawing.Point(664, 143);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 49);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "실행";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblRand1
            // 
            this.lblRand1.AutoSize = true;
            this.lblRand1.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRand1.Location = new System.Drawing.Point(213, 106);
            this.lblRand1.Name = "lblRand1";
            this.lblRand1.Size = new System.Drawing.Size(27, 29);
            this.lblRand1.TabIndex = 2;
            this.lblRand1.Text = "?";
            // 
            // lblRand2
            // 
            this.lblRand2.AutoSize = true;
            this.lblRand2.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRand2.Location = new System.Drawing.Point(378, 106);
            this.lblRand2.Name = "lblRand2";
            this.lblRand2.Size = new System.Drawing.Size(27, 29);
            this.lblRand2.TabIndex = 2;
            this.lblRand2.Text = "?";
            // 
            // lblRand3
            // 
            this.lblRand3.AutoSize = true;
            this.lblRand3.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRand3.Location = new System.Drawing.Point(543, 106);
            this.lblRand3.Name = "lblRand3";
            this.lblRand3.Size = new System.Drawing.Size(27, 29);
            this.lblRand3.TabIndex = 2;
            this.lblRand3.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "결과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "입력";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCount.Location = new System.Drawing.Point(188, 21);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 29);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(52, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "카운트";
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStrike.Location = new System.Drawing.Point(188, 239);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(80, 29);
            this.lblStrike.TabIndex = 2;
            this.lblStrike.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(37, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "스트라이크";
            // 
            // lblBall
            // 
            this.lblBall.AutoSize = true;
            this.lblBall.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBall.Location = new System.Drawing.Point(188, 296);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(80, 29);
            this.lblBall.TabIndex = 2;
            this.lblBall.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(82, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "볼";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(664, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "리셋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 361);
            this.Controls.Add(this.lblRand3);
            this.Controls.Add(this.lblRand2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBall);
            this.Controls.Add(this.lblStrike);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRand1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblRand1;
        private System.Windows.Forms.Label lblRand2;
        private System.Windows.Forms.Label lblRand3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStrike;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

