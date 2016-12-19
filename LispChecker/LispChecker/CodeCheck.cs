using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LispChecker
{
    /// <summary>
    /// コードチェッククラス
    /// </summary>
    static class CodeCheck
    {
        /// <summary> 関数名 定義 </summary>
        private const string FunctionNameDefun = "defun";
        /// <summary> 関数名 値入力 </summary>
        private const string FunctionNameSetq = "setq";

        /// <summary>
        /// 全ての要素をチェックする
        /// </summary>
        /// <param name="fileText">チェックするテキスト文</param>
        public static string All(string[] fileText)
        {
            //文字コード判定
            //ローカル変数取得
            // "(defun" があったら、その次の" " + 定義関数名 + " " となっている定義関数名を取得
            // その後の "(" + ... +  "/" 以後のローカル変数を取得　")"が来るまで続ける
            string defunString = GetDefunString(fileText);


            // "(defun" と対になる ")" が出るまで ローカル変数名を検索する
            // 関数名と使用されていたローカル変数・使用されていなかったローカル変数
            // ローカル変数にない文字を一覧に出す
            string resultText = "読み込み完了 関数名 = [ " + defunString + " ]";
            return resultText;
        }

        /// <summary>
        /// 定義関数の文字列のリストを作成する 
        /// </summary>
        private static string GetDefunString(string[] fileText)
        {
            List<string> defunTextList = new List<string>();
            string rowText = "";
            string functionName = "";
            //一行毎に定義関数がないかチェックする
            for (int i = 0; i < fileText.Length; i++)
            {
                rowText = fileText[i];
                int defunIndex = rowText.IndexOf(FunctionNameDefun);
                if (0 <= defunIndex)
                {
                    functionName = GetFunctionName(rowText , defunIndex);
                }
                rowText += fileText[i];
            }

            /* TODO:定義関数クラスを作成する
               ・関数名
               ・引数
               ・ローカル変数
               ・関数内容全文
               ・(返り値)
            */
            return functionName;
        }

        /// <summary>
        /// 関数名を取得
        /// 次の空白までの文字列が関数名となる
        /// </summary>
        private static string GetFunctionName(string rowText , int defunIndex)
        {
            int startIndex = defunIndex + FunctionNameDefun.Length;
            string functionName = "";
            string hogeText = "";
            for (int i = startIndex ; i < rowText.Length && functionName.Equals("") ; i++)
            {
                //'('までの文字列を取得する
                if (rowText[i].Equals('('))
                {
                    functionName = hogeText.Trim(' ');
                }
                else
                {
                    hogeText += rowText[i];
                }
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

