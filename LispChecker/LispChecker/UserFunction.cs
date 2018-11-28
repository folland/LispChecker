using System.Collections.Generic;

namespace LispChecker
{
    class UserFunction
    {
        /// <summary> LISP定義関数名 </summary>
        public const string FunctionNameDefun = "defun";
        public const string FunctionNameSetq = "setq";

        /// <summary> 関数全文の文字列リスト </summary>
        private List<string> funcStringList;

        /// <summary> ユーザー関数名 </summary>
        public string FunctionName { get; }
        /// <summary> ユーザー関数の引数のリスト </summary>
        public List<string> ArguList { get; }
        /// <summary> ユーザー関数のローカル変数のリスト </summary>
        public List<string> LocalVariableList { get; }

        /// <summary> コンストラクタ </summary>
        /// <param name="stringList">関数全文の文字列リスト</param>
        public UserFunction(List<string> stringList)
        {
            funcStringList = stringList;
            FunctionName = GetFunctionName();
            ArguList = GetArguList();
            LocalVariableList = GetLocalVariableList();
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
        /// ユーザー関数の関数名を取得
        /// 次の空白までの文字列がユーザー関数の関数名となる
        /// </summary>
        /// <returns>関数名</returns>
        private string GetFunctionName()
        {
            string firstRowText = funcStringList[0];
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
            string firstRowText = funcStringList[0];
            int variableIndex = GetDefunFuncArguIndex(firstRowText);
            //引数のリストを取得
            string hogeString = "";
            bool isEnd = false;
            int startIndex = variableIndex;
            for (int i = 0; i < funcStringList.Count && isEnd == false; i++)
            {
                string rowText = funcStringList[i];
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
        /// ローカル変数のリストを取得
        /// </summary>
        /// <returns>ローカル変数のリスト</returns>
        private List<string> GetLocalVariableList()
        {
            List<string> localVariableList = new List<string>();
            //開始インデックスを取得
            string firstRowText = funcStringList[0];
            int variableIndex = firstRowText.IndexOf('/');
            //引数のリストを取得
            string hogeString = "";
            bool isEnd = false;
            int startIndex = variableIndex + 1;
            for (int i = 0; i < funcStringList.Count && isEnd == false; i++)
            {
                string rowText = funcStringList[i];
                for (int j = startIndex; j < rowText.Length; j++)
                {
                    char c = rowText[j];
                    if (c == ')' || c == ' ')
                    {
                        hogeString = hogeString.Trim(' ');
                        if (hogeString != "")
                        {
                            localVariableList.Add(hogeString);
                            hogeString = "";
                        }
                        if (c == ')')
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
            return localVariableList;
        }

        /// <summary>
        /// ユーザー関数の引数の開始インデックスを取得
        /// </summary>
        /// <param name="firstRowText">ユーザー関数の最初の行の文字列</param>
        /// <returns>ユーザー関数の引数の開始インデックス</returns>
        private int GetDefunFuncArguIndex(string firstRowText)
        {
            int arguIndex = firstRowText.Length;
            //ユーザー関数名分インデックスをずらす
            int functionNameIndex = firstRowText.IndexOf(functionName);
            int startIndex = functionNameIndex + functionName.Length;
            for (int i = startIndex; i < firstRowText.Length; i++)
            {
                char c = firstRowText[i];
                if (c == '(')
                {
                    //'('の次からが引数の開始インデックスとなる
                    arguIndex = i + 1;
                    break;
                }
            }
            return arguIndex;
        }

        /// <summary>
        /// ユーザー関数内の変数を取得し、種類別のリストに追加
        /// </summary>
        private void GetAllVariableListByType()
        {
            //関数の引数・変数の次の行の行番号を取得する
            int contentsRowNum = GetRowNumberOfContentsRowNum();
            for (int i = contentsRowNum; i < funcStringList.Count; i++)
            {
                string rowText = funcStringList[i];
                string rowTextHoge = rowText;
                bool isLoop = true;
                while (isLoop)
                {
                    int indexOfSetq = rowTextHoge.IndexOf(FunctionNameSetq);
                    if (indexOfSetq < 0)
                    {
                        isLoop = false;
                    }
                    else
                    {
                        //setqの終わりの右括弧までを検索する
                        //setqの内容が書かれた文字列のリストを取得する
                        //setqの文字列のリストから変数を種類別のリストに追加する
                        GetVariableListByType();
                    }
                }
            }
        }

        /// <summary>
        /// 関数の実行内容行の行番号を取得する
        /// </summary>
        /// <returns>実行内容行の行番号</returns>
        private int GetRowNumberOfContentsRowNum()
        {
            int contentsRowNum = 0;
            bool isEnd = false;
            for (int i = 0; i < funcStringList.Count && isEnd == false; i++)
            {
                string rowText = funcStringList[i];
                for (int j = 0; j < rowText.Length; j++)
                {
                    char c = rowText[j];
                    if (c == ')')
                    {
                        //右括弧がある行を引数・変数の宣言を終えた行とする
                        isEnd = true;
                    }
                }
                if (isEnd)
                {
                    contentsRowNum = i + 1;
                }
            }
            return contentsRowNum;
        }

        /// <summary>
        /// 変数を種類別のリストに入れる
        /// </summary>
        private void GetVariableListByType()
        {

        }




    }
}
