using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LispEditer
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
            if (lspFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LispFilePassText.Text = lspFileDialog.FileName;
                /* ファイル読み込み
                System.IO.StreamReader sr = new System.IO.StreamReader(lspFileDialog.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
                */
            }
        }

        private void SetCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
