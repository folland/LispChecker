namespace LispChecker
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
            this.LispPassText = new System.Windows.Forms.TextBox();
            this.GetLispPassButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SetOKButton = new System.Windows.Forms.Button();
            this.SetCancelButton = new System.Windows.Forms.Button();
            this.LispPassLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OutputPassLabel = new System.Windows.Forms.Label();
            this.OutputPassButton = new System.Windows.Forms.Button();
            this.OutputPassText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LispPassText
            // 
            this.LispPassText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LispPassText.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LispPassText.Location = new System.Drawing.Point(31, 68);
            this.LispPassText.Name = "LispPassText";
            this.LispPassText.Size = new System.Drawing.Size(414, 23);
            this.LispPassText.TabIndex = 0;
            // 
            // GetLispPassButton
            // 
            this.GetLispPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetLispPassButton.Location = new System.Drawing.Point(451, 68);
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
            this.DescriptionLabel.Size = new System.Drawing.Size(299, 16);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "コードチェックするLispファイルを入力してください";
            // 
            // SetOKButton
            // 
            this.SetOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetOKButton.Location = new System.Drawing.Point(300, 187);
            this.SetOKButton.Name = "SetOKButton";
            this.SetOKButton.Size = new System.Drawing.Size(75, 23);
            this.SetOKButton.TabIndex = 3;
            this.SetOKButton.Text = "OK";
            this.SetOKButton.UseVisualStyleBackColor = true;
            this.SetOKButton.Click += new System.EventHandler(this.SetOKButton_Click);
            // 
            // SetCancelButton
            // 
            this.SetCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCancelButton.Location = new System.Drawing.Point(397, 187);
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
            this.LispPassLabel.Location = new System.Drawing.Point(28, 49);
            this.LispPassLabel.Name = "LispPassLabel";
            this.LispPassLabel.Size = new System.Drawing.Size(174, 16);
            this.LispPassLabel.TabIndex = 5;
            this.LispPassLabel.Text = "チェックするLispファイルパス";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OutputPassLabel
            // 
            this.OutputPassLabel.AutoSize = true;
            this.OutputPassLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.OutputPassLabel.Location = new System.Drawing.Point(28, 117);
            this.OutputPassLabel.Name = "OutputPassLabel";
            this.OutputPassLabel.Size = new System.Drawing.Size(153, 16);
            this.OutputPassLabel.TabIndex = 8;
            this.OutputPassLabel.Text = "チェック結果ファイルパス";
            // 
            // OutputPassButton
            // 
            this.OutputPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPassButton.Location = new System.Drawing.Point(451, 136);
            this.OutputPassButton.Name = "OutputPassButton";
            this.OutputPassButton.Size = new System.Drawing.Size(22, 23);
            this.OutputPassButton.TabIndex = 7;
            this.OutputPassButton.Text = "...";
            this.OutputPassButton.UseVisualStyleBackColor = true;
            // 
            // OutputPassText
            // 
            this.OutputPassText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPassText.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.OutputPassText.Location = new System.Drawing.Point(31, 136);
            this.OutputPassText.Name = "OutputPassText";
            this.OutputPassText.Size = new System.Drawing.Size(414, 23);
            this.OutputPassText.TabIndex = 6;
            // 
            // StartFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 222);
            this.Controls.Add(this.OutputPassLabel);
            this.Controls.Add(this.OutputPassButton);
            this.Controls.Add(this.OutputPassText);
            this.Controls.Add(this.LispPassLabel);
            this.Controls.Add(this.SetCancelButton);
            this.Controls.Add(this.SetOKButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.GetLispPassButton);
            this.Controls.Add(this.LispPassText);
            this.MaximumSize = new System.Drawing.Size(1920, 260);
            this.MinimumSize = new System.Drawing.Size(520, 180);
            this.Name = "StartFrom";
            this.Text = "LispChecker";
            this.Load += new System.EventHandler(this.StartFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LispPassText;
        private System.Windows.Forms.Button GetLispPassButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SetOKButton;
        private System.Windows.Forms.Button SetCancelButton;
        private System.Windows.Forms.Label LispPassLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label OutputPassLabel;
        private System.Windows.Forms.Button OutputPassButton;
        private System.Windows.Forms.TextBox OutputPassText;
    }
}

