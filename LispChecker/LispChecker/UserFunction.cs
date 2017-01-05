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
        /// <summary> ユーザー関数の引数のリスト </summary>
        private List<string> arguList;

        /// <summary> ユーザー関数名 </summary>
        public string FunctionName
        {
            get { return functionName; }
        }
        /// <summary> ユーザー関数の引数のリスト </summary>
        public List<string> ArguList
        {
            get { return arguList; }
        }

        /// <summary> コンストラクタ </summary>
        public UserFunction(string[] stringArray)
        {
            funcStringArray = stringArray;
            functionName = GetFunctionName();
            arguList = GetArguList();
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
        /// <returns>関数名</returns>
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
        /// <summary>
        /// 引数のリストを取得
        /// </summary>
        /// <returns>引数のリスト</returns>
        private List<string> GetArguList()
        {
            List<string> arguList = new List<string>();
            //開始インデックスを取得
            string firstRowText = funcStringArray[0];
            int variableIndex = GetDefunFuncVariableIndex(firstRowText);
            //引数のリストを取得
            string hogeString = "";
            bool isEnd = false;
            int startIndex = variableIndex;
            for (int i = 0; i < funcStringArray.Length && isEnd == false; i++)
            {
                string rowText = funcStringArray[i];
                for (int j = startIndex; j < rowText.Length; j++)
                {
                    char c = rowText[j];
                    if (c == '/' || c == ')' || c == ' ')
                    {
                        hogeString = hogeString.Trim(' ');
                        if (hogeString != "")
                        {
                            arguList.Add(hogeString);
                            hogeString = "";
                        }
                        if (c == '/' || c == ')')
                        {
                            isEnd = true;
                            break;
                        }
                    }
                    else
                    {
                        hogeString += c;
                    }
                }
                startIndex = 0;
            }
            return arguList;
        }
        /// <summary>
        /// 定義関数の定義変数(引数・ローカル変数)の開始インデックスを取得
        /// </summary>
        /// <returns>開始インデックス</returns>
        private int GetDefunFuncVariableIndex(string firstRowText)
        {
            int variableIndex = firstRowText.Length;
            //ユーザー関数名インデックスをずらす
            int functionNameIndex = firstRowText.IndexOf(functionName);
            int startIndex = functionNameIndex + functionName.Length;
            for (int i = startIndex; i < firstRowText.Length; i++)
            {
                char c = firstRowText[i];
                if (c == '(')
                {
                    //'('の次からが引数・ローカル変数の開始インデックスとなる
                    variableIndex = i + 1;
                    break;
                }
            }
            return variableIndex;
        }
    }
}
