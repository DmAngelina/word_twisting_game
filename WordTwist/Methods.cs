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
    

    public partial class Form1
    {
        /// <summary>
        /// Выгружает данные из файлов в массивы
        /// </summary>
        /// 
        public void Startup()
        {
            nowPlaying = false;

            dic7L = LoadFile.Load(@"C:\Users\Xiaomi\source\repos\WordTwist\WordTwist\Dic\Dic7L.txt");
            dic8L = LoadFile.Load(@"C:\Users\Xiaomi\source\repos\WordTwist\WordTwist\Dic\Dic8L.txt");
            dic9L = LoadFile.Load(@"C:\Users\Xiaomi\source\repos\WordTwist\WordTwist\Dic\Dic9L.txt");
            dicAll = LoadFile.Load(@"C:\Users\Xiaomi\source\repos\WordTwist\WordTwist\Dic\DicAll.txt");

            timer.Enabled = false;
        }

        /// <summary>
        /// Выбирает слово, находит подходящие слова, запускает таймер
        /// </summary>
       
        public void NewGame()
        {
            int rndNo;
            int max;
            int i;
            string choosenWordBackup;
            string word;
            users_words = new ArrayList();

            if (firstRun == true)
            {
                Startup();
                firstRun = false;
            }

            btnNext.Enabled = true;
            Clear();

            Random rnd = new Random();

            if (difficulty == 1)
            {
                max = dic7L.Count - 1;
                rndNo = rnd.Next(0, max);
                choosenWord = (string)dic7L[rndNo];
            }
            else if (difficulty == 2)
            {
                max = dic8L.Count - 1;
                rndNo = rnd.Next(0, max);
                choosenWord = (string)dic8L[rndNo];
            }
            else
            {
                max = dic9L.Count - 1;
                rndNo = rnd.Next(0, max);
                choosenWord = (string)dic9L[rndNo];
            }

            max = dicAll.Count - 1;

            possibleWords = new ArrayList();

            lBoxCorrect.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Add(choosenWord);
            for (i = 0; i < dicAll.Count; i++)
            {
                choosenWordBackup = choosenWord;
                word = (string)dicAll[i];

                if (IsPossibleWord(choosenWordBackup, word))
                {
                    possibleWords.Add(word);
                    listBox1.Items.Add(word);
                }

            }

            possibleWordsCounter = possibleWords.Count;
            lbl_Correct.Text = "Количество подходящих слов (" + Convert.ToString(possibleWordsCounter) + "):";

            nowPlaying = true;

            lblNotes.Text = "Найдите все слова, которые можно составить из данных букв";

            Twist();

            gameTimerSec = gameTimer;
            timer.Enabled = true;

        }

        /// <summary>
        /// Вычисляет, можно ли из букв базового слова составить сравниваемое слово
        /// </summary>
        /// <param name="baseWord"></param>
        /// <param name="compareWord"></param>
        /// <returns></returns>

        public bool IsPossibleWord(string baseWord, string compareWord)
        {
            bool found = true;
            while (found && compareWord.Length > 0)
            {
                char currChar = compareWord[0];
                compareWord = compareWord.Remove(0, 1);
                int index = baseWord.IndexOf(currChar);
                if (index >= 0)
                {
                    baseWord = baseWord.Remove(index, 1);
                }
                else
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>
        /// Пермешивает буквы в слове
        /// </summary>

        public void Twist()
        {
            int[] pickedSeq;
            int letterCount;
            int i;
            int j;

            letterCount = difficulty + 6;
            pickedSeq = new int[letterCount];
            for (j = 0; j <= letterCount - 1; j++)
                pickedSeq[j] = j;

            Random rnd = new Random();
            for (i = letterCount - 1; i >= 1; i--)
            {
                j = rnd.Next(i + 1);
                // обменять значения data[j] и data[i]
                int temp = pickedSeq[j];
                pickedSeq[j] = pickedSeq[i];
                pickedSeq[i] = temp;
            }

            button1.Text = choosenWord.Substring(pickedSeq[0], 1);
            button2.Text = choosenWord.Substring(pickedSeq[1], 1);
            button3.Text = choosenWord.Substring(pickedSeq[2], 1);
            button4.Text = choosenWord.Substring(pickedSeq[3], 1);
            button5.Text = choosenWord.Substring(pickedSeq[4], 1);
            button6.Text = choosenWord.Substring(pickedSeq[5], 1);
            button7.Text = choosenWord.Substring(pickedSeq[6], 1);
            if (difficulty == 2)
                button8.Text = choosenWord.Substring(pickedSeq[7], 1);
            else if (difficulty == 3)
            {
                button8.Text = choosenWord.Substring(pickedSeq[7], 1);
                button9.Text = choosenWord.Substring(pickedSeq[8], 1);
            }
        }

        public void Clear()
        {
            txtUsersWords.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
    }
}
