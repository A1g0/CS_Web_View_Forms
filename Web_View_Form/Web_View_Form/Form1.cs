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

namespace Web_View_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string CD = System.Environment.CurrentDirectory;

           

            //string address = @"https://www.youtube.com/watch?v=wP8OmKx3ds4";
            string address = CD + @"\data\index.html";


            var browser = new ChromiumWebBrowser(address);
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
