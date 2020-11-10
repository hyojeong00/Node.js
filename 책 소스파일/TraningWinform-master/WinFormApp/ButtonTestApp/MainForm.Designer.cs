namespace ButtonTestApp
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
            this.btnFlat = new System.Windows.Forms.Button();
            this.btnPopup = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.LblButtonStyle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlat
            // 
            this.btnFlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlat.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFlat.Location = new System.Drawing.Point(81, 67);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(163, 91);
            this.btnFlat.TabIndex = 0;
            this.btnFlat.Text = "Flat";
            this.btnFlat.UseVisualStyleBackColor = false;
            this.btnFlat.Click += new System.EventHandler(this.btnFlat_Click);
            // 
            // btnPopup
            // 
            this.btnPopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPopup.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPopup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPopup.Location = new System.Drawing.Point(293, 67);
            this.btnPopup.Name = "btnPopup";
            this.btnPopup.Size = new System.Drawing.Size(163, 91);
            this.btnPopup.TabIndex = 1;
            this.btnPopup.Text = "Popup";
            this.btnPopup.UseVisualStyleBackColor = false;
            this.btnPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStandard.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStandard.Location = new System.Drawing.Point(81, 201);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(163, 91);
            this.btnStandard.TabIndex = 2;
            this.btnStandard.Text = "Standard";
            this.btnStandard.UseVisualStyleBackColor = false;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSystem.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSystem.Location = new System.Drawing.Point(293, 201);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(163, 91);
            this.btnSystem.TabIndex = 3;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // LblButtonStyle
            // 
            this.LblButtonStyle.AutoSize = true;
            this.LblButtonStyle.Location = new System.Drawing.Point(30, 336);
            this.LblButtonStyle.Name = "LblButtonStyle";
            this.LblButtonStyle.Size = new System.Drawing.Size(67, 15);
            this.LblButtonStyle.TabIndex = 4;
            this.LblButtonStyle.Text = "결과표시";
            this.LblButtonStyle.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 389);
            this.Controls.Add(this.LblButtonStyle);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnPopup);
            this.Controls.Add(this.btnFlat);
            this.Name = "MainForm";
            this.Text = "Standard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.Button btnPopup;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Label LblButtonStyle;
    }
}

