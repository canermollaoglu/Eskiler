using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3_SettingKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
.Net FrameWork oturum ve uygulama arasında kalan degerlere erismemize ve yeni degerler  olusturmamıza izin verir. Bu degerler "Settings" olarak adlandırılır. Settings dosyası kullanımına ihtiyaç duyulan uygulama bilgilerini yada kullanıcı ayarlarını temsil eder. Örnegin; uygulamanın renk seması için kullanıcı ayarlarını saklayan ayarları olusturabiliriz. Yada uygulamada kullanılan bir database'e belirlenen bir ConnectionString''i saklayabilirsin. Settings(Ayarlar) kullanıcıların ayarlarını saklayan profilleri olusturmamıza ve kodun uygulama dısında olan bilgilerine erismemize izin verir.
Uygulama Ve Kullanıcı Ayarları
  Settings'lerin 4 adet özelligi vardır;  
1.      Name: Çalısma Zamanında ayarın degerine erismek için kullanılan addır.
2.      Type: Ayarları temsil eden .Net Framework tipidir. Kullanıcı ayarlarını saklar.
3.      Scope: Çalısma zamanında ayarlara nasıl erisilecegini temsil eden özelliktir.
4.      Value: Ayarlara erisildiginde geriye döndürülecek olan degerdir.
            */
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                if (txtUserName.Text==Properties.Settings.Default.UserName & txtPassword.Text==Properties.Settings.Default.Password)
                {
                    Anaform anafrm = new Anaform();
                    this.Hide();
                    anafrm.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı ve ya Sifre");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
        }
    }
}
