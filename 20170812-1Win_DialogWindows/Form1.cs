using System;
using System.Windows.Forms;

namespace _20170812_1Win_DialogWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * ForeColor : yazı rengini ifade eder.
         * BackColor : arkaplan rengini ifade eder.
         */
        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            { 
                label1.ForeColor = colorDialog1.Color;
            }

        }

        private void fontSeçToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //eğer filtre ekleme istersek properties penceresinden filter bölümünü düzenlememeiz gerekmektedir.
            // ÖRN : Yazı Dosyaları|*.txt|Word Dosyaları|*.doc;*.docx
            // şeklinde bir filtreleme yaparsak. | yazı dosyaları veya word dosyaları seçimlerinden birini yaptıktan sonra sadece o dosyalar seçim ekranında görünecektir. 
            // bu filtreleme işlemini kod olarak yazmak istersek aşağıdaki satıra göz atabiliriz.
            openFileDialog1.Filter = "Metin Dosyaları|*.txt|Word Dosyaları|*.doc;*.docx|Abidik Dosyası|*.abidik";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // açma işleminda hiçbişey seçmeden açamayız. veya bir klasör seçerek açamayız.
            // AMA savefiledialog nesnesinde daha önce var olmayan bir dosyayı da seçerek kaydedebiliriz. zaten var olmayan dosyayı kaydetmemiz mümkündür.

            saveFileDialog1.Filter = "Abidik Dosyası|*.abidik";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = saveFileDialog1.FileName;    
            }
        }

        private void klasörSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sadece klasör seçilmek istenirse forlderbrowserdialog kullanılır.
            // diğerlerinde filename kullanılıyorken bunda seçilen yol anlamında selectedpath kullanılmaktadır. böylece seçilen dosyanın dosya yolunu label1 e alabiliriz.

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void kişiKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayıtForm kf = new KayıtForm();
            if (kf.ShowDialog() == DialogResult.OK)
            {
                label1.Text = kf.KayitForm_AD;
            }

        }
    }
}
