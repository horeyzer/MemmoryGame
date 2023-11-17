using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace Memmory_Game
{
    public partial class Game : Form
    {
        
        private Timer firstTimer;
        private Timer secondTimer;
        private int firstTimerValue = 0;
        private int secondTimerValue = 0;
        //размер сетки size x size
        int size;
        int[,] values;
        //строчка из txt файла
        string[] line;
        //строчка разбитая в масив по ;
        string[] parts;
        //время которое показываются цифры на клетках
        int ShowingTime;
        //количество цифр на клетках
        int count = 0;
        //количество жизней
        int Lives;
        // имя 
        string name;
        int numbuton = 0;
        // Минимальное значение рандома
        int minValue = 1;
        //значение на кнопке
        int NumberBut = 1;
        List<int> numpos = new List<int>(); 
        //какой-то шлак решил посчитать
        int count1 = 0;
         

        public Game()
        {
            InitializeComponent();
            firstTimer = new Timer();
            firstTimer.Interval = 1000;
            firstTimer.Tick += FirstTimer_Tick;

            secondTimer = new Timer();
            secondTimer.Interval = 1000;
            secondTimer.Tick += SecondTimer_Tick;
        }
        private void FirstTimer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = firstTimerValue.ToString();
            firstTimerValue--;


            if (firstTimerValue < 0)
            {
                foreach (Control control in Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = true;
                    }
                }
                StartButton.Enabled = false;
                BackButton.Enabled = true;
                firstTimer.Stop();
                secondTimer.Start();
            }
        }
        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            
                TimerLabel.Text = secondTimerValue.ToString();
                secondTimerValue++;
            
                
        }
        public static List<int> GeneratePositions(int minValue, int numbuton, int count)
        {
            List<int> numbers = new List<int>();

            Random random = new Random();
            
            while (numbers.Count < count)
            {
                int randomNumber = random.Next(minValue, numbuton ); //fefefsadsaff

                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

            return numbers;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            firstTimer.Start();
            secondTimer.Stop();
            if (size > 5)
            {
                for (int i = size; i > 5;i--)
                {
                    this.Width += 50;
                    this.Height += 50;
                }
            }
            List<int> positions = GeneratePositions(minValue, numbuton, count);
            foreach (int position in positions)
            {

                numpos.Add(position);  
                Button button = Controls.Find("Button" + position.ToString(), true).FirstOrDefault() as Button;
                button.Text = Convert.ToString(NumberBut);
                NumberBut++;

            }
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                }
            }
            StartButton.Enabled = false;
            BackButton.Enabled = true;
            count1 = 0;
        }
        private void Button_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            if (clickedButton == null) return;
            if (clickedButton.Name != "Button" + numpos[count1])
            {
                LivesLabel.Text = Convert.ToString(Convert.ToInt32(LivesLabel.Text) - 1);
                clickedButton.BackColor = Color.Red;
            }
            if (clickedButton.Name == "Button"+ numpos[count1] && count1 < count)
            {
                clickedButton.BackColor = Color.Green;
                Button button = Controls.Find("Button" + numpos[count1].ToString(), true).FirstOrDefault() as Button;
                clickedButton.Text = Convert.ToString(count1 + 1);
                
                TielsLabel.Text = Convert.ToString(Convert.ToInt32(TielsLabel.Text) - 1);
                count1 = count1 + 1;
            }
            if(count1 == count)
            {
                firstTimer.Stop();
                secondTimer.Stop();
                MessageBox.Show($"you win!!! \n Your time is {TimerLabel.Text}");
                Close();
            }
            if (LivesLabel.Text == "0")
            {
                firstTimer.Stop();
                secondTimer.Stop();
                MessageBox.Show($"you lost in {TimerLabel.Text} sec");
                Close();
            }
        }
        private void createTextboxes()
        {
            numbuton = 0;
            int x = 140;
            int y = 20;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    
                    Button But = new Button();
                    But.Name = $"Button{numbuton}";
                    But.Font = new Font("Arial", 10);
                    But.Width = 50;
                    But.Height = 50;
                    But.Text = "";
                    But.Location = new Point(x, y);
                    this.Controls.Add(But);
                    x += 50;
                    But.Click += Button_Click;
                    numbuton++;
                }
                x = 140;
                y += 50;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            line = File.ReadAllLines("player.txt");
            parts = line[0].Split(';');
            try
            {
                name = parts[0];
                firstTimerValue = ShowingTime = int.Parse(parts[1]);
                count = int.Parse(parts[2]);
                size = int.Parse(parts[3]);
                Lives = int.Parse(parts[4]);
                LivesLabel.Text = Lives.ToString();
                TielsLabel.Text = count.ToString();
                NameLabel.Text = name.ToString();
                size = Convert.ToInt32(size);
                values = new int[size, size];
                createTextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show($"Something Has Gone Wrong \n Try Again)");
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Menu = Application.OpenForms[0];
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Left = this.Left;
            Menu.Top = this.Top;
            Menu.Show();
        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimerLabel_TextChanged(object sender, EventArgs e)
        {
            if (TimerLabel.Text == "0")
            {
                int buttonCount = 0;
                foreach (Control control in Controls)
                {
                    if (control is Button button && button.Name.StartsWith("Button"))
                    {
                        button.Text = string.Empty;
                        buttonCount++;
                    }
                }
            }
        }

        private void TielsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
