namespace _20170812_1Win_DialogWindows
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dosyaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.klasörSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haganya - Hakan Akgül";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkDeğiştirToolStripMenuItem,
            this.fontSeçToolStripMenuItem,
            this.dosyaAçToolStripMenuItem,
            this.dosyaKaydetToolStripMenuItem,
            this.klasörSeçToolStripMenuItem,
            this.kişiKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 158);
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renkDeğiştirToolStripMenuItem.Text = "Renk Seç";
            this.renkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem_Click);
            // 
            // fontSeçToolStripMenuItem
            // 
            this.fontSeçToolStripMenuItem.Name = "fontSeçToolStripMenuItem";
            this.fontSeçToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontSeçToolStripMenuItem.Text = "Font Seç";
            this.fontSeçToolStripMenuItem.Click += new System.EventHandler(this.fontSeçToolStripMenuItem_Click);
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            this.dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            this.dosyaKaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            this.dosyaKaydetToolStripMenuItem.Click += new System.EventHandler(this.dosyaKaydetToolStripMenuItem_Click);
            // 
            // klasörSeçToolStripMenuItem
            // 
            this.klasörSeçToolStripMenuItem.Name = "klasörSeçToolStripMenuItem";
            this.klasörSeçToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.klasörSeçToolStripMenuItem.Text = "Klasör Seç";
            this.klasörSeçToolStripMenuItem.Click += new System.EventHandler(this.klasörSeçToolStripMenuItem_Click);
            // 
            // kişiKaydetToolStripMenuItem
            // 
            this.kişiKaydetToolStripMenuItem.Name = "kişiKaydetToolStripMenuItem";
            this.kişiKaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kişiKaydetToolStripMenuItem.Text = "Kişi Kaydet";
            this.kişiKaydetToolStripMenuItem.Click += new System.EventHandler(this.kişiKaydetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 373);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontSeçToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem klasörSeçToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem kişiKaydetToolStripMenuItem;
    }
}

