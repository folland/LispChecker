using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LispChecker
{
    class UserFunction
    {
        /// <summary> LISP定義関数名 </summary>
        public const string FunctionNameDefun = "defun";
        /// <summary> 関数全文の文字列リスト </summary>
        private string[] funcStringArray;
        /// <summary> ユーザー関数名 </summary>
        private string functionName;

        /// <summary> ユーザー関数名 </summary>
        public string FunctionName
        {
            get { return functionName; }
        }

        public UserFunction(string[] stringArray)
        {
            funcStringArray = stringArray;
            functionName = GetFunctionName();
        }

        /* TODO:ユーザー関数クラスを作成する
           ・関数内容全文
           ・関数名
           ・引数
           ・ローカル変数
             "(" + ... +  "/" 以後のローカル変数を取得　")"

             "(defun" と対になる ")" が出るまで ローカル変数名を検索する
             関数名と使用されていたローカル変数・使用されていなかったローカル変数
             ローカル変数にない文字を一覧に出す
           ・(返り値)
        */

        /// <summary>
        /// 関数名を取得
        /// 次の空白までの文字列が関数名となる
        /// </summary>
        private string GetFunctionName()
        {
            string firstRowText = funcStringArray[0];
            int defunIndex = firstRowText.IndexOf(FunctionNameDefun);
            //定義関数分インデックスをずらす
            int startIndex = defunIndex + FunctionNameDefun.Length;
            string functionName = "";
            string hogeText = "";
            for (int i = startIndex; i < firstRowText.Length && functionName == ""; i++)
            {
                //' 'までの文字列を取得する
                if (firstRowText[i] == ' ')
                {
                    functionName = hogeText.Trim(' ');
                }
                else
                {
                    hogeText += firstRowText[i];
                }
            }
            return functionName;
        }
    }
}
