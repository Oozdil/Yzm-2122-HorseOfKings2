namespace HorseOfKings
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_high_score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_board_size = new System.Windows.Forms.Button();
            this.btn_new_game = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGv_Game = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Game)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 81;
            this.label1.Text = "Skorunuz :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(148, 22);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(20, 24);
            this.lbl_score.TabIndex = 82;
            this.lbl_score.Text = "0";
            // 
            // lbl_high_score
            // 
            this.lbl_high_score.AutoSize = true;
            this.lbl_high_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_high_score.Location = new System.Drawing.Point(365, 22);
            this.lbl_high_score.Name = "lbl_high_score";
            this.lbl_high_score.Size = new System.Drawing.Size(30, 24);
            this.lbl_high_score.TabIndex = 84;
            this.lbl_high_score.Text = "81";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(209, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 83;
            this.label4.Text = "En Yüksek Skor :";
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(990, 166);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(118, 62);
            this.btn_about.TabIndex = 85;
            this.btn_about.Text = "Oyun Hakkında";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_board_size
            // 
            this.btn_board_size.Location = new System.Drawing.Point(990, 29);
            this.btn_board_size.Name = "btn_board_size";
            this.btn_board_size.Size = new System.Drawing.Size(118, 62);
            this.btn_board_size.TabIndex = 86;
            this.btn_board_size.Text = "Oyun Boyutu Değiştir";
            this.btn_board_size.UseVisualStyleBackColor = true;
            this.btn_board_size.Click += new System.EventHandler(this.btn_board_size_Click);
            // 
            // btn_new_game
            // 
            this.btn_new_game.Location = new System.Drawing.Point(990, 97);
            this.btn_new_game.Name = "btn_new_game";
            this.btn_new_game.Size = new System.Drawing.Size(118, 62);
            this.btn_new_game.TabIndex = 87;
            this.btn_new_game.Text = "Yeni Oyun";
            this.btn_new_game.UseVisualStyleBackColor = true;
            this.btn_new_game.Click += new System.EventHandler(this.btn_new_game_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(990, 234);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(118, 62);
            this.btn_exit.TabIndex = 88;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_message);
            this.panel1.Controls.Add(this.dGv_Game);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_high_score);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_score);
            this.panel1.Location = new System.Drawing.Point(15, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 467);
            this.panel1.TabIndex = 89;
            // 
            // dGv_Game
            // 
            this.dGv_Game.AllowUserToAddRows = false;
            this.dGv_Game.AllowUserToDeleteRows = false;
            this.dGv_Game.AllowUserToResizeColumns = false;
            this.dGv_Game.AllowUserToResizeRows = false;
            this.dGv_Game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Game.ColumnHeadersVisible = false;
            this.dGv_Game.Location = new System.Drawing.Point(32, 61);
            this.dGv_Game.MultiSelect = false;
            this.dGv_Game.Name = "dGv_Game";
            this.dGv_Game.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGv_Game.RowHeadersVisible = false;
            this.dGv_Game.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGv_Game.Size = new System.Drawing.Size(363, 363);
            this.dGv_Game.TabIndex = 92;
            this.dGv_Game.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(668, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 115);
            this.panel2.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(124, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "2018 ©";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "HAZIRLAYAN : Orçun ÖZDİL 172803065";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "DANIŞMAN : Yrd. Doç. Dr. Emin BORANDAĞ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(58, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "YAZILIM YAPIMI YZM 2122  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "YAZILIM MÜHENDİSLİĞİ ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HorseOfKings.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(990, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("MS Mincho", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(253, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 34);
            this.label10.TabIndex = 91;
            this.label10.Text = "THE HORSE OF KINGS";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.Location = new System.Drawing.Point(28, 431);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(20, 24);
            this.lbl_message.TabIndex = 93;
            this.lbl_message.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::HorseOfKings.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1120, 532);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_new_game);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_board_size);
            this.Controls.Add(this.btn_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Game)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_high_score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_board_size;
        private System.Windows.Forms.Button btn_new_game;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dGv_Game;
        private System.Windows.Forms.Label lbl_message;
    }
}

