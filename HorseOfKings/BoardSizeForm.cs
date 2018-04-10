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
    public partial class BoardSizeForm : Form
    {
        public BoardSizeForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            BoardSize = 9;
            if (radioButton1.Checked) { BoardSize = 5;}
            if (radioButton2.Checked) { BoardSize = 6; }
            if (radioButton3.Checked) { BoardSize = 7; }
            if (radioButton4.Checked) { BoardSize = 8; }
            
            Properties.Settings.Default.BoardSize = BoardSize;
            Properties.Settings.Default.Save();
            this.Close();
        }
        public int BoardSize;
        private void BoardSizeForm_Load(object sender, EventArgs e)
        {
            BoardSize = Properties.Settings.Default.BoardSize;
            switch (BoardSize)
            {
                case 5:
                    radioButton1.Checked = true;
                    break;
                case 6:
                    radioButton2.Checked = true;
                    break;
                case 7:
                    radioButton3.Checked = true;
                    break;
                case 8:
                    radioButton4.Checked = true;
                    break;
                case 9:
                    radioButton5.Checked = true;
                    break;
            }
        }
    }
}
