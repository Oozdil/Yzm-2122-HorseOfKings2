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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        # region Degiskenler
        Color pasif_renk = System.Drawing.Color.Gray;
        Color bloke_renk = System.Drawing.Color.SandyBrown;
        Color uygun_renk = System.Drawing.Color.Indigo;
        Color dolu_renk = System.Drawing.Color.GreenYellow;
        int hamleSayisi;
        int[,] hareket_yerleri = { { -2, 1 }, { 1, 2  }, { 2, -1 }, {-1, -2} ,//saat yönünde dönüşler
                                   { -2, -1 }, { -1, 2  }, { 2, 1 }, {1, -2}  //saat yönünün tersinde dönüşler
                                    };
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

            OyunAlaniAyarla();

        }

        private void OyunAlaniAyarla()
        {
            dGv_Game.ColumnCount = 9;
            dGv_Game.RowCount = 9;
            for (int i = 0; i < 9; i++)
            {
                dGv_Game.Columns[i].Width = 40;
                dGv_Game.Rows[i].Height = 40;
            }
            dGv_Game.ClearSelection();
            int boardsize = Properties.Settings.Default.BoardSize;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    dGv_Game.Rows[i].Cells[j].Style.BackColor = uygun_renk;
                    dGv_Game.Rows[i].Cells[j].Value = "";
                    if (i >= boardsize || j >= boardsize)
                    {
                        dGv_Game.Rows[i].Cells[j].Style.BackColor = pasif_renk;

                    }
                }
                dGv_Game.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            dGv_Game.DefaultCellStyle.Font = new Font("Tahoma", 15);
            hamleSayisi = 0;
            lbl_score.Text = hamleSayisi.ToString();
            lbl_high_score.Text = Properties.Settings.Default.HighScore.ToString();
            lbl_message.Text = "Oyuna başlayabilirsiniz";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hangi butona basıldığını tespit ettik

            int cell_x = e.RowIndex;
            int cell_y = e.ColumnIndex;
            DataGridViewCell secilen_cell = dGv_Game.Rows[cell_x].Cells[cell_y];
            if (secilen_cell.Style.BackColor != dolu_renk && secilen_cell.Style.BackColor != pasif_renk && secilen_cell.Style.BackColor != bloke_renk)
            {
                dGv_Game.Rows[cell_x].Cells[cell_y].Style.BackColor = dolu_renk;
                dGv_Game.Rows[cell_x].Cells[cell_y].Value = (++hamleSayisi).ToString();
                lbl_score.Text = hamleSayisi.ToString();

                // dolu olmayan ve oyun alanı içinde olan tüm butonları bloke ettik


                foreach (DataGridViewRow row in dGv_Game.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Style.BackColor != dolu_renk && cell.Style.BackColor != pasif_renk)
                            cell.Style.BackColor = bloke_renk;
                    }
                }

                //yapılabilecek hamleleri buluyoruz
                int kalanhamle = 0;
                for (int i = 0; i < 8; i++)
                {
                    int cell_new_x = cell_x + hareket_yerleri[i, 0];
                    int cell_new_y = cell_y + hareket_yerleri[i, 1];

                    //buton uyona alanında ve dolu değilse uygundur
                    try
                    {
                        DataGridViewCell cell = dGv_Game.Rows[cell_new_x].Cells[cell_new_y];

                        if (cell.Style.BackColor != dolu_renk && cell.Style.BackColor != pasif_renk)
                        {
                            cell.Style.BackColor = uygun_renk;
                            kalanhamle++;
                        }
                    }
                    catch
                    {
                    }

                }

                if (kalanhamle == 0)
                {
                    int score = Convert.ToInt32(lbl_score.Text);
                    if (score == Math.Pow(Properties.Settings.Default.BoardSize, 2))
                    {
                      //  MessageBox.Show("Tebrikler kazandınız");
                        lbl_message.Text = "Tebrikler kazandınız";
                    }
                    else
                    {
                       // MessageBox.Show("Üzgünüm kaybettiniz");
                        lbl_message.Text = "Üzgünüm kaybettiniz";
                    }

                    if (score > Properties.Settings.Default.HighScore)
                    {

                        Properties.Settings.Default.HighScore = hamleSayisi;
                        Properties.Settings.Default.Save();
                        lbl_high_score.Text = Properties.Settings.Default.HighScore.ToString();
                    }
                }
            }

            dGv_Game.ClearSelection();
        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult karar = MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "DİKKAT ÇIKIŞ YAPILACAK",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (karar == DialogResult.Yes)
                this.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            aboutform.MaximizeBox = false;
            aboutform.MinimizeBox = false;
            aboutform.ShowDialog();
        }

        private void btn_board_size_Click(object sender, EventArgs e)
        {
            BoardSizeForm boardsizeform = new BoardSizeForm();
            boardsizeform.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            boardsizeform.MaximizeBox = false;
            boardsizeform.MinimizeBox = false;
            boardsizeform.ShowDialog();
            OyunAlaniAyarla();
        }

        private void btn_new_game_Click(object sender, EventArgs e)
        {
            OyunAlaniAyarla();
        }
       

    }
}
