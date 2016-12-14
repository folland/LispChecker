using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LispEditor
{
    public partial class StartFrom : Form
    {
        public StartFrom()
        {
            InitializeComponent();
        }

        private void StartFrom_Load(object sender, EventArgs e)
        {

        }

        private void GetLispPassButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog lspFileDialog = new OpenFileDialog();
            //[ファイルの種類]に表示される選択肢を指定する
            lspFileDialog.Filter = "Lispファイル(*.lsp)|*.lsp|すべてのファイル(*.*)|*.*";
            if (lspFileDialog.ShowDialog() == DialogResult.OK)
            {
                LispPassText.Text = lspFileDialog.FileName;
                //元のlspファイル名の末尾に "_Checked" を付ける
                string lspFileName = Path.GetFileNameWithoutExtension(lspFileDialog.FileName);
                string outputFileName = lspFileName + "_Checked";
                string outputFilePath = LispPassText.Text.Replace(lspFileName, outputFileName);
                OutputPassText.Text = outputFilePath;
            }
        }

        private void SetCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetOKButton_Click(object sender, EventArgs e)
        {
            //文字コードセット
            System.Text.Encoding enc = System.Text.Encoding.GetEncoding("shift_jis");
            //テキストファイルの中身をすべて読み込む
            string fileText = fileText = System.IO.File.ReadAllText(LispPassText.Text, enc);
            string resultText = CodeCheck.All(fileText);
            MessageBox.Show(resultText);
        }
    }
}