using CefSharp.WinForms;
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

namespace Web_View_Form
{
    public partial class Form1 : Form
    {

        public static string override_address = "null";
        public Form1()
        {
            InitializeComponent();
            string CD = System.Environment.CurrentDirectory;



            //string address = @"https://www.youtube.com/watch?v=wP8OmKx3ds4";
            string address = CD + @"\data\index.html";

            if (override_address != "null") address = override_address;

            int X = 1280, Y = 720;

            ////サイズを読み込む
            //string Scale_data = File.OpenText(CD + @"\Scale.txt").ReadToEnd();

            //string[] Scale_array = Scale_data.Split('\n');

            ////XY変換
            //if (Scale_array.Length == 2)
            //{
            //    X = int.Parse(Scale_array[0].Replace("Xsize:", string.Empty));
            //    Y = int.Parse(Scale_array[1].Replace("Ysize:", string.Empty));
            //}

            this.Size = new Size(X,Y);
            this.Version.Text = "20190716_FIx4";

            var browser = new ChromiumWebBrowser(address);
            browser.Size = new Size(X, Y);
            browser.Padding = new Padding(0,0,0,0);

            Controls.Add(browser);
            browser.Dock = DockStyle.Top;
        }
    }
}
