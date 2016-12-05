namespace LispEditer
{
    partial class StartFrom
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.LispFilePassText = new System.Windows.Forms.TextBox();
            this.GetLispPassButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SetOKButton = new System.Windows.Forms.Button();
            this.SetCancelButton = new System.Windows.Forms.Button();
            this.LispPassLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LispFilePassText
            // 
            this.LispFilePassText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LispFilePassText.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LispFilePassText.Location = new System.Drawing.Point(30, 64);
            this.LispFilePassText.Name = "LispFilePassText";
            this.LispFilePassText.Size = new System.Drawing.Size(414, 23);
            this.LispFilePassText.TabIndex = 0;
            // 
            // GetLispPassButton
            // 
            this.GetLispPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetLispPassButton.Location = new System.Drawing.Point(450, 64);
            this.GetLispPassButton.Name = "GetLispPassButton";
            this.GetLispPassButton.Size = new System.Drawing.Size(22, 23);
            this.GetLispPassButton.TabIndex = 1;
            this.GetLispPassButton.Text = "...";
            this.GetLispPassButton.UseVisualStyleBackColor = true;
            this.GetLispPassButton.Click += new System.EventHandler(this.GetLispPassButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.DescriptionLabel.Location = new System.Drawing.Point(28, 9);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(252, 16);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "編集するLispファイルを入力してください";
            // 
            // SetOKButton
            // 
            this.SetOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetOKButton.Location = new System.Drawing.Point(300, 107);
            this.SetOKButton.Name = "SetOKButton";
            this.SetOKButton.Size = new System.Drawing.Size(75, 23);
            this.SetOKButton.TabIndex = 3;
            this.SetOKButton.Text = "OK";
            this.SetOKButton.UseVisualStyleBackColor = true;
            // 
            // SetCancelButton
            // 
            this.SetCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCancelButton.Location = new System.Drawing.Point(397, 107);
            this.SetCancelButton.Name = "SetCancelButton";
            this.SetCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SetCancelButton.TabIndex = 4;
            this.SetCancelButton.Text = "キャンセル";
            this.SetCancelButton.UseVisualStyleBackColor = true;
            this.SetCancelButton.Click += new System.EventHandler(this.SetCancelButton_Click);
            // 
            // LispPassLabel
            // 
            this.LispPassLabel.AutoSize = true;
            this.LispPassLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LispPassLabel.Location = new System.Drawing.Point(28, 38);
            this.LispPassLabel.Name = "LispPassLabel";
            this.LispPassLabel.Size = new System.Drawing.Size(105, 16);
            this.LispPassLabel.TabIndex = 5;
            this.LispPassLabel.Text = "Lispファイルパス";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StartFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 142);
            this.Controls.Add(this.LispPassLabel);
            this.Controls.Add(this.SetCancelButton);
            this.Controls.Add(this.SetOKButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.GetLispPassButton);
            this.Controls.Add(this.LispFilePassText);
            this.MaximumSize = new System.Drawing.Size(1920, 180);
            this.MinimumSize = new System.Drawing.Size(520, 180);
            this.Name = "StartFrom";
            this.Text = "LispEditer";
            this.Load += new System.EventHandler(this.StartFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LispFilePassText;
        private System.Windows.Forms.Button GetLispPassButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SetOKButton;
        private System.Windows.Forms.Button SetCancelButton;
        private System.Windows.Forms.Label LispPassLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

