using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LispEditor
{
    /// <summary>
    /// コードチェッククラス
    /// </summary>
    static class CodeCheck
    {
        /// <summary>
        /// 関数名を定数で定義
        /// </summary>
        private const string FunctionNameDefun = "defun";
        private const string FunctionNameSetq = "setq";

        /// <summary>
        /// 全ての要素をチェックする
        /// </summary>
        public static string All(string fileText)
        {
            //文字コード判定
            //ローカル変数取得
            // "(defun" があったら、その次の" " + 定義関数名 + " " となっている定義関数名を取得
            // その後の "(" + ... +  "/" 以後のローカル変数を取得　")"が来るまで続ける



            // "(defun" と対になる ")" が出るまで ローカル変数名を検索する
            // 関数名と使用されていたローカル変数・使用されていなかったローカル変数
            // ローカル変数にない文字を一覧に出す
            return fileText;
        }

        /// <summary>
        /// 定義関数の文字列のリストを作成する 
        /// </summary>
        private static string GetDefunString(string fileText)
        {
            List<string> defunTextList = new List<string>();
            string hogeText = "";
            string functionName = "";
            for (int i = 0; i < fileText.Length; i++)
            {
                if (fileText[i].Equals('('))
                {
                    functionName = GetFunctionName(fileText.Substring(i + 1));
                    if (functionName.Equals(FunctionNameDefun))
                    {
                        //')'までの文字列を取得する
                    }
                }
                hogeText += fileText[i];
            }

            return fileText;
        }

        /// <summary>
        /// 関数名を取得
        /// 次の空白までの文字列が関数名となる
        /// </summary>
        private static string GetFunctionName(string text)
        {
            string functionName = null;
            string hogeText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(' '))
                {
                    functionName = hogeText;
                }
                hogeText += text[i];
            }
            return functionName;
        }

        /// <summary>
        /// 関数のローカル変数を取得する
        /// </summary>
        private static string GetLocalVariable(String functionText)
        {

            return functionText;
        }
    }
}

