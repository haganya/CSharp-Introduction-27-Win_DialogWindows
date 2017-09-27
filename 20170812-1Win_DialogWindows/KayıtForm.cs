using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170812_1Win_DialogWindows
{
    public partial class KayıtForm : Form
    {
        public KayıtForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            this.AcceptButton = button1;
        }
        /*
         * Kendi dialogBox formumuzu yapmak istiyoruz. 
         * 
         * Formun boyutunun değiştirilmesi istenmiyorsa FormBorderStyle özelliğinde Fixed ile başlayanlar boyutu değiştirilemeyenlerdir. Sizable boyutu değiştirilebilir olur.
         * None seçeneğinde çerçeve gider. Form nerde açılırsa orda kalır. 
         * 
         * FixedSingle olsun ama aşağı indirme ve tam ekran yapma butonları da olmasın istiyorsak. O zaman  MaximizeBox ve MinimizeBox özelliklerinin false yapılması yeterlidir. İkisi birden false olursa simgeler görünmez olur
         * 
         * X tuşunu kapamak istersek ControlBox özelliğini false yaparız. bu da bize sade bir form verir.
         * 
         * Tüm bu özellikler formun properties özelliğinden yapılabileceği gibi kod yazarak da yapılabilir. public KayıtForm() metotu içerisine yazıldığında form oluşturulurken
         */

 
        protected string _KayitForm_AD = null;
        public string KayitForm_AD
        {
            get{ return this._KayitForm_AD; }
            set { this._KayitForm_AD = value; }
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            //formun kendi dialogresult özelliği vardır. kaydet butonuna basıldığında dialogresult OK olarak atama yaptık. 
            //Seçim yapıldıktan sonra formun kapatılmasıyla işlem tamamlanır.

            KayitForm_AD = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kaydet butonunda yapılanların aynısı iptal butonu için de yapılır.
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
