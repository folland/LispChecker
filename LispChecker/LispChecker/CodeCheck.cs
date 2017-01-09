using System;
using System.Collections;
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
        /// <summary> 関数名 値入力 </summary>
        private const string FunctionNameSetq = "setq";

        //TODO:一番最初に全てのコメント部分を削除する動作を挿入する

        /// <summary>
        /// 全ての要素をチェックする
        /// </summary>
        /// <param name="fileText">チェックするテキスト文</param>
        public static string All(string[] fileText)
        {
            //ユーザー関数クラスのリストを取得
            ArrayList userFunctionList = GetUserFunctionList(fileText);
            string resultText = "";
            if (0 <= userFunctionList.Count)
            {
                string functionString = "";
                for (int i = 0; i < userFunctionList.Count; i++)
                {
                    functionString += "関数名 = [ ";
                    UserFunction userFunction = (UserFunction)userFunctionList[i];
                    functionString += userFunction.FunctionName + " ]\r\n";
                    functionString += GetStringByList("引数", userFunction.ArguList);
                    functionString += GetStringByList("ローカル変数", userFunction.LocalVariableList);
                }
                resultText = "読み込み完了\r\n" + functionString;
            }
            else if (userFunctionList.Count == 0)
            {
                resultText = "関数がありませんでした";
            }
            else
            {
                resultText = "読み込み失敗";
            }

            return resultText;
        }

        /// <summary>
        /// リストから文を生成する
        /// </summary>
        /// <param name="title">文のタイトル</param>
        /// <param name="strList">リスト</param>
        /// <returns>リストから生成した文</returns>
        private static string GetStringByList(string title, List<string> strList)
        {
            string answerString = title + " = [ ";
            for (int j = 0; j < strList.Count; j++)
            {
                answerString += strList[j];
                if ((j + 1) != strList.Count)
                {
                    answerString += " , ";
                }
            }
            answerString += " ]\r\n";
            return answerString;
        }

        /// <summary>
        /// ユーザー関数のクラスのリストを作成する 
        /// </summary>
        /// <param name="fileText">チェックするテキスト文</param>
        /// <returns>ユーザー関数クラスのリスト</returns>
        private static ArrayList GetUserFunctionList(string[] fileText)
        {
            ArrayList userFunctionList = new ArrayList();
            string rowText = "";
            int rowNum = 0;
            //一行毎にユーザー関数がないかチェックする
            for (int i = 0; i < fileText.Length; i++)
            {
                rowText = fileText[i];
                int defunIndex = rowText.IndexOf(UserFunction.FunctionNameDefun);
                if (0 <= defunIndex)
                {
                    rowNum = GetLastRowNumUserFunction(fileText, i);
                    //ユーザー関数部分の文字列のリストを取得
                    string[] funcStringArray = fileText.Skip(i).Take(rowNum - i).ToArray();
                    UserFunction userFunction = new UserFunction(funcStringArray);
                    userFunctionList.Add(userFunction);
                }
            }
            return userFunctionList;
        }

        /// <summary>
        /// ユーザー関数の最後の行番号を取得
        /// 左括弧が閉じきった行が最後の行となる
        /// </summary>
        /// <param name="fileText">チェックするテキスト文</param>
        /// <param name="startNum">開始行番号</param>
        /// <returns>ユーザー関数の最後の行番号</returns>
        private static int GetLastRowNumUserFunction(string[] fileText, int startNum)
        {
            int endNum = startNum;
            int leftPareCount = 0;
            string rowText = "";

            //左括弧の数が0になったときにループを終了する
            for (int i = startNum; i < fileText.Length; i++)
            {
                rowText = fileText[i];
                //1行の左括弧の数をカウントする
                leftPareCount += GetleftPareCountByRow(rowText);
                if (i != startNum && leftPareCount == 0)
                {
                    endNum = i;
                    break;
                }
            }
            return endNum;
        }
        /// <summary>
        /// 1行の左括弧の数をカウントする
        /// </summary>
        /// <param name="rowText">チェックする行</param>
        /// <returns>左括弧の数</returns>
        private static int GetleftPareCountByRow(string rowText)
        {
            int leftPareCount = 0;
            bool doLoop = true;
            for (int i = 0; i < rowText.Length && doLoop; i++)
            {
                char c = rowText[i];
                switch (c)
                {
                    case ';':
                        doLoop = false;
                        break;
                    case '(':
                        leftPareCount++;
                        break;
                    case ')':
                        leftPareCount--;
                        break;
                    default:
                        break;
                }
            }
            return leftPareCount;
        }
    }
}


