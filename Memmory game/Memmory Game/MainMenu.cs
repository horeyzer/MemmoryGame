using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memmory_Game
{
    public partial class Menu : Form
    {
        private void check()
        {
            if (ShowTimeBox.Text != "" && SizeBox.Text != "" && NumbersBox.Text != "" && LiveBox.Text != "" && NameBox.Text != "")
            {
                StartButton.Enabled = true;
            }
            else
            {
                StartButton.Enabled = false;
            }
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void DificultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(DificultyBox.SelectedIndex) 
            {
                case 0:
                    ShowTimeBox.Enabled = false;
                    NumbersBox.Enabled = false;
                    SizeBox.Enabled = false;
                    LiveBox.Enabled = false;

                    ShowTimeBox.Text = "5";
                    NumbersBox.Text = "4";
                    SizeBox.Text = "4";
                    LiveBox.Text = "4";    
                    break;
                case 1:
                    ShowTimeBox.Enabled = false;
                    NumbersBox.Enabled = false;
                    SizeBox.Enabled = false;
                    LiveBox.Enabled = false;

                    ShowTimeBox.Text = "2";
                    NumbersBox.Text = "5";
                    SizeBox.Text = "5";
                    LiveBox.Text = "3";
                    break;
                case 2:
                    ShowTimeBox.Enabled = false;
                    NumbersBox.Enabled = false;
                    SizeBox.Enabled = false;
                    LiveBox.Enabled = false;

                    ShowTimeBox.Text = "2";
                    NumbersBox.Text = "7";
                    SizeBox.Text = "6";
                    LiveBox.Text = "3";
                    break;
                case 3:
                    ShowTimeBox.Enabled = true;
                    NumbersBox.Enabled = true;
                    SizeBox.Enabled = true;
                    LiveBox.Enabled = true;
                    break;

            }
            check();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(SizeBox.Text) * Convert.ToInt32(SizeBox.Text) < Convert.ToInt32(NumbersBox.Text))
                {
                    MessageBox.Show("Too many numbers \n      Max is: " + Convert.ToInt32(SizeBox.Text) * Convert.ToInt32(SizeBox.Text));
                }
                else
                {
                    //чистка файла и добовление игрока 
                    File.WriteAllText("player.txt", string.Empty);
                    FileStream fs = new FileStream("player.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(NameBox.Text + ";" + ShowTimeBox.Text + ";" + NumbersBox.Text + ";" + SizeBox.Text + ";" + LiveBox.Text);
                    sw.Close();
                    fs.Close();
                    Form Game = new Game();
                    Game.Left = this.Left;
                    Game.Top = this.Top;
                    Game.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Something Has Gone Wrong \n Try Again)");
            }
            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowTimeBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void SizeBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void NumbersBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void LiveBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }
    }
}
