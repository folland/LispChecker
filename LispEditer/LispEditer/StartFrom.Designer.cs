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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetLispPassButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LispPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.textBox1.Location = new System.Drawing.Point(30, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 23);
            this.textBox1.TabIndex = 0;
            // 
            // GetLispPassButton
            // 
            this.GetLispPassButton.Location = new System.Drawing.Point(448, 64);
            this.GetLispPassButton.Name = "GetLispPassButton";
            this.GetLispPassButton.Size = new System.Drawing.Size(22, 23);
            this.GetLispPassButton.TabIndex = 1;
            this.GetLispPassButton.Text = "...";
            this.GetLispPassButton.UseVisualStyleBackColor = true;
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
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(298, 107);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(395, 107);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
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
            // StartFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 142);
            this.Controls.Add(this.LispPassLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.GetLispPassButton);
            this.Controls.Add(this.textBox1);
            this.Name = "StartFrom";
            this.Text = "LispEditer";
            this.Load += new System.EventHandler(this.StartFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetLispPassButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label LispPassLabel;
    }
}

