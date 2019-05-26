using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace WordTwist
{
    public partial class Form1 : Form
    {
        public bool nowPlaying;
        bool firstRun;
        public int difficulty;
        int gameTimer;
        int possibleWordsCounter;
        int gameTimerSec;
        ArrayList dicAll;
        ArrayList dic7L;
        ArrayList dic8L;
        ArrayList dic9L;
        ArrayList possibleWords;
        public string choosenWord;
        ArrayList users_words;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuBeginner_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = true;
            menuMedium.Checked = false;
            menuExpert.Checked = false;
            if (nowPlaying == true)
                MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuMedium_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = false;
            menuMedium.Checked = true;
            menuExpert.Checked = false;
            if (nowPlaying == true)
            MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstRun = true;
            btnNext.Enabled = false;
            lblNotes.Text = " ";   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {
                
                txtUsersWords.Text = txtUsersWords.Text + button1.Text;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button2.Text;
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button3.Text;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button4.Text;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button5.Text;
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button6.Text;
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button7.Text;
                button7.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button8.Text;
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {

                txtUsersWords.Text = txtUsersWords.Text + button9.Text;
                button9.Enabled = false;
            }
        }

        private void btnTwist_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {
                Clear();
                Twist();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (nowPlaying == true & firstRun == false)
            {
                Clear();   
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (nowPlaying == false || firstRun == true)
                return;

            string str;
            int i;
            bool Okay;
            

            str = txtUsersWords.Text;

            

            if (str.Length < 3)
            {
                lblNotes.Text = "Слово должно состоять как минимум из 3-ех букв"; 
                Clear();
                return;
            }

            for (i = 0; i <= lBoxCorrect.Items.Count - 1; i++)
            {
                if (lBoxCorrect.Items.IndexOf(str) != -1)
                {
                    lblNotes.Text = "Вы уже вводили это слово (" + str + ")";
                    Clear();
                    return;
                }
            }

            Okay = false;
            for (i = 0; i <= possibleWords.Count - 1; i++)
            {
                if (possibleWords.IndexOf(str) != -1)
                {
                    users_words.Add(str);
                    Okay = true;
                    break;
                }
            }

            if (Okay == true)
            {
                if (str.Length == 6 + difficulty)
                {
                    lblNotes.Text = "Превосходно (" + str + ")!";
                    btnNext.Enabled = true;
                }
                else
                {
                    lblNotes.Text = "Правильное слово (" + str + ")!";
                }
                lBoxCorrect.Items.Add(str);
                if (lBoxCorrect.Items.Count == possibleWords.Count)
                {
                    lblNotes.Text = "Превосходно, вы ввели все возможные слова!";
                    nowPlaying = false;
                    timer.Enabled = false;
                    possibleWordsCounter = possibleWordsCounter - 1;
                    lbl_Correct.Text = "Количество подходящих слов (" + System.Convert.ToString(possibleWordsCounter) + "):";
                    return;
                }
                
                possibleWordsCounter = possibleWordsCounter - 1;
                lbl_Correct.Text = "Количество подходящих слов (" + System.Convert.ToString(possibleWordsCounter) + "):";
                lBoxCorrect.DrawMode = DrawMode.OwnerDrawFixed;
                lBoxCorrect.DrawItem += new DrawItemEventHandler(lBoxCorrect_DrawItem);
                panel2.Controls.Add(lBoxCorrect);
            }
            else
            {
                lblNotes.Text = "Данного слова нет в нашем словаре (" + str + ")";            
            }

            Clear();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int i;

            gameTimerSec = gameTimerSec - 1;
            lblTimer.Text = Convert.ToString(gameTimerSec);

            //if (gameTimerSec == 10 | gameTimerSec == 5)
            //    My.Computer.Audio.Play(My.Resources.Timer, AudioPlayMode.Background);
            //else 
            if (gameTimerSec == 0)
            {
                nowPlaying = false;
                if (btnNext.Enabled == true)
                    lblNotes.Text = "You are qualified to proceed with the next level";
                else
                {
                    lblNotes.Text = "Game Over!, Time Is Up...";
                    
                }

                lBoxCorrect.Items.Clear();
                for (i = 0; i <= possibleWords.Count - 1; i++)
                    lBoxCorrect.Items.Add(possibleWords[i]);

                nowPlaying = false;
                timer.Enabled = false;

            }

        }

        private void menuExpert_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = false;
            menuMedium.Checked = false;
            menuExpert.Checked = true;
            if (nowPlaying == true)
                MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ans;

            if (nowPlaying == true | btnNext.Enabled == true)
            {
                ans = MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
                if (ans == DialogResult.No)
                    return;
            }

            if (menuBeginner.Checked == true)
            {
                difficulty = 1; // Beginner
                button8.Visible = false;
                button9.Visible = false;
            }
            else if (menuMedium.Checked == true)
            {
                difficulty = 2; // Medium
                button8.Visible = true;
                button9.Visible = false;
            }
            else
            {
                difficulty = 3; // Expert
                button8.Visible = true;
                button9.Visible = true;
            }

            gameTimer = 240;
            NewGame();
        }

        private void begginerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = true;
            menuMedium.Checked = false;
            menuExpert.Checked = false;
            DialogResult ans;
            if (nowPlaying == true)
            {
                ans = MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
                if (ans == DialogResult.No)
                    return;
            }
            difficulty = 1;
            button8.Visible = false;
            button9.Visible = false;
            gameTimer = 240;
            NewGame();
        }

        private void medium6LettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = false;
            menuMedium.Checked = true;
            menuExpert.Checked = false;
            DialogResult ans;
            if (nowPlaying == true)
            {
                ans = MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
                if (ans == DialogResult.No)
                    return;
            }
            difficulty = 2;
            button8.Visible = true;
            button9.Visible = false;
            NewGame();
        }

        private void expert7LettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuBeginner.Checked = false;
            menuMedium.Checked = false;
            menuExpert.Checked = true;
            DialogResult ans;
            if (nowPlaying == true)
            {
                ans = MessageBox.Show("Вы уверены, что хотите закончить эту игру и начать другую?", " ", MessageBoxButtons.YesNo);
                if (ans == DialogResult.No)
                    return;
            }
            difficulty = 3;
            button8.Visible = true;
            button9.Visible = true;
            NewGame();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = null;
            lbl_Correct.BringToFront();
            lbl_Correct.Text = "Вы нашли " + System.Convert.ToString(users_words.Count) + " слов из " + System.Convert.ToString(possibleWords.Count) + " возможных!";
            lBoxCorrect.Items.Clear();
            for (int i = 0; i <= possibleWords.Count - 1; i++)
                lBoxCorrect.Items.Add(possibleWords[i]);

            //lBoxCorrect.Location = new System.Drawing.Point(21, 56);
            //lBoxCorrect.Size = new System.Drawing.Size(146, 124);
            lBoxCorrect.DrawMode = DrawMode.OwnerDrawFixed;
            lBoxCorrect.DrawItem += new DrawItemEventHandler(lBoxCorrect_DrawItem);
            panel2.Controls.Add(lBoxCorrect);
        }

        private void lBoxCorrect_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Green;

            // Determine the color of the brush to draw each item based 
            // on the index of the item to draw.
            if (users_words == null)
            {
                myBrush = Brushes.Red;
                e.Graphics.DrawString(lBoxCorrect.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                string[] users_words1 = new string[users_words.Count];
                for (int i = 0; i < users_words1.Length; i++)
                {
                    users_words1[i] = users_words[i].ToString();
                }

                int pos = Array.IndexOf(users_words1, lBoxCorrect.Items[e.Index]);
                if (pos > -1)
                {
                    myBrush = Brushes.Green;
                }
                else
                {
                    myBrush = Brushes.Red;
                }

                // Draw the current item text based on the current Font 
                // and the custom brush settings.
                e.Graphics.DrawString(lBoxCorrect.Items[e.Index].ToString(),
                    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                // If the ListBox has focus, draw a focus rectangle around the selected item.
                //e.DrawFocusRectangle();
            }
        }
    }
}
