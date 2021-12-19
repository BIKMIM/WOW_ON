
namespace WOW_ON
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
            this.components = new System.ComponentModel.Container();
            this.start_btn = new System.Windows.Forms.Button();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.end_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 60);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "시작";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOnOff.Location = new System.Drawing.Point(81, 9);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(89, 37);
            this.lblOnOff.TabIndex = 1;
            this.lblOnOff.Text = "OFF";
            this.lblOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end_btn
            // 
            this.end_btn.Location = new System.Drawing.Point(168, 60);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(75, 23);
            this.end_btn.TabIndex = 5;
            this.end_btn.Text = "종료";
            this.end_btn.UseVisualStyleBackColor = true;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 95);
            this.Controls.Add(this.end_btn);
            this.Controls.Add(this.lblOnOff);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "접속유지 by 빕";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label lblOnOff;
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

