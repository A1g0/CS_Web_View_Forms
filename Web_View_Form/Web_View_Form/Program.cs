
/*
 * Okui Lab. OpenCampus BlokyTools
 * Created By Kai Yoshida
 * 
 * 
 * 
 * HTMLをWindowsフォームで利用できるようにしました。
 * CefSharpテストを兼ねてます。
 * 
 * 
 * ビルド設定について
 * 32bit優先
 * AnyCPUは使えません
 * ->対応しました(20190716)
 * csproj自体に細工しているためそのまま使うのを推奨
 * 
 * 
 * 修正事項
 * 改造度指定が出来たほうが良いかも
 * セーブ等はHTMLから無理やり保存してハイスコア画面の値に投げるのが良いか？
 * HttpListener、Localhostで立てるのも良いかと思います。
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_View_Form
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1) Form1.override_address = args[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
