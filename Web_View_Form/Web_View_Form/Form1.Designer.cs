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
            this.Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.White;
            this.Version.Font = new System.Drawing.Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Version.Location = new System.Drawing.Point(12, 1013);
            this.Version.MinimumSize = new System.Drawing.Size(64, 18);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(1900, 28);
            this.Version.TabIndex = 0;
            this.Version.Text = "20190123FixXX";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "WindowBrwz_20190716_FIx4";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Version;
    }
}

