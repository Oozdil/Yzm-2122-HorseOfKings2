using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseOfKings
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            string Mesaj = @"Oyunun amacı seçilen alanı içindeki tüm hücreleri doldurmaktır."+Environment.NewLine+
                            @"Başlamak için bir hücreye tıklayınız. Bir sonraki hamleniz satrançtaki at hamlesi şeklinde olmak zorundadır. "+Environment.NewLine+
                            @"Tüm hücreleri doldurmayı başarırsanız oyun tamamlanmış olacaktır.";
            richTextBox1.Text = Mesaj;
            richTextBox1.Enabled = false;
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
