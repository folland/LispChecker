using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LispEditer
{
    static class CodeCheck
    {
        public static string All(String fileText)
        {
            //文字コード判定
            // "(defun" があったら、その次の" " + 関数名 + " " となっている関数名を取得
            // その後の "(" + ... +  "/" 以後のローカル変数を取得　")"が来るまで続ける
            // "(defun" と対になる ")" が出るまで ローカル変数名を検索する
            // 関数名と使用されていたローカル変数・使用されていなかったローカル変数
            // ローカル変数にない文字を一覧に出す
            return fileText;
        }

    }
}
