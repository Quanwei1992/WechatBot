namespace WechatBot
{
    partial class WechatBot
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_qrcode = new System.Windows.Forms.PictureBox();
            this.label_tips = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_qrcode
            // 
            this.pictureBox_qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_qrcode.Location = new System.Drawing.Point(129, 12);
            this.pictureBox_qrcode.Name = "pictureBox_qrcode";
            this.pictureBox_qrcode.Size = new System.Drawing.Size(179, 180);
            this.pictureBox_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_qrcode.TabIndex = 0;
            this.pictureBox_qrcode.TabStop = false;
            // 
            // label_tips
            // 
            this.label_tips.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips.Location = new System.Drawing.Point(12, 200);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(420, 21);
            this.label_tips.TabIndex = 1;
            this.label_tips.Text = "正在刷新二维码";
            this.label_tips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_log.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox_log.Location = new System.Drawing.Point(13, 232);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(423, 195);
            this.textBox_log.TabIndex = 2;
            // 
            // WechatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 441);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.label_tips);
            this.Controls.Add(this.pictureBox_qrcode);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 480);
            this.MinimumSize = new System.Drawing.Size(460, 480);
            this.Name = "WechatBot";
            this.Text = "微信聊天机器人";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WechatBot_FormClosed);
            this.Load += new System.EventHandler(this.WechatBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_qrcode;
        private System.Windows.Forms.Label label_tips;
        private System.Windows.Forms.TextBox textBox_log;
    }
}

