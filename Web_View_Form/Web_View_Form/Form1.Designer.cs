using System.Windows.Forms;
using System.IO;
using System.Net;


namespace Web_View_Form
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 


            int X = 1280, Y = 720;

            //サイズを読み込む
            string CD = System.Environment.CurrentDirectory;
            string Scale_data = File.OpenText(CD + @"\Scale.txt").ReadToEnd();

            string[] Scale_array = Scale_data.Split('\n');

            //XY変換
            if (Scale_array.Length == 2)
            {
                X = int.Parse(Scale_array[0].Replace("Xsize:", string.Empty));
                Y = int.Parse(Scale_array[1].Replace("Ysize:", string.Empty));
            }

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(X, Y);
            this.Name = "WindowBrwz_20190716_Fix4";
            this.Text = "WindowBrwz_20190716_FIx4";
            this.ResumeLayout(false);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        #endregion
    }
}

