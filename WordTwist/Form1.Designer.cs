namespace WordTwist
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUsersWords = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBeginner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTwist = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lBoxCorrect = new System.Windows.Forms.ListBox();
            this.lbl_Correct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsersWords
            // 
            this.txtUsersWords.Location = new System.Drawing.Point(43, 156);
            this.txtUsersWords.Name = "txtUsersWords";
            this.txtUsersWords.Size = new System.Drawing.Size(297, 26);
            this.txtUsersWords.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.menu.Size = new System.Drawing.Size(797, 48);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.optionsToolStripMenuItem.Text = "Новая игра";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBeginner,
            this.menuMedium,
            this.menuExpert});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(273, 38);
            this.infoToolStripMenuItem.Text = "Уровень сложности";
            // 
            // menuBeginner
            // 
            this.menuBeginner.Checked = true;
            this.menuBeginner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBeginner.Name = "menuBeginner";
            this.menuBeginner.Size = new System.Drawing.Size(343, 38);
            this.menuBeginner.Text = "Начальный (7 букв)";
            this.menuBeginner.Click += new System.EventHandler(this.begginerToolStripMenuItem_Click);
            // 
            // menuMedium
            // 
            this.menuMedium.Name = "menuMedium";
            this.menuMedium.Size = new System.Drawing.Size(343, 38);
            this.menuMedium.Text = "Средний (8 букв)";
            this.menuMedium.Click += new System.EventHandler(this.medium6LettersToolStripMenuItem_Click);
            // 
            // menuExpert
            // 
            this.menuExpert.Name = "menuExpert";
            this.menuExpert.Size = new System.Drawing.Size(343, 38);
            this.menuExpert.Text = "Высокий (9 букв)";
            this.menuExpert.Click += new System.EventHandler(this.expert7LettersToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "А";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Б";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "В";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Г";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Д";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(213, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Е";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(255, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 36);
            this.button7.TabIndex = 10;
            this.button7.Text = "Ж";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(26, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(257, 104);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(105, 34);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnTwist
            // 
            this.btnTwist.Location = new System.Drawing.Point(238, 260);
            this.btnTwist.Name = "btnTwist";
            this.btnTwist.Size = new System.Drawing.Size(124, 32);
            this.btnTwist.TabIndex = 13;
            this.btnTwist.Text = "Перемешать";
            this.btnTwist.UseVisualStyleBackColor = true;
            this.btnTwist.Click += new System.EventHandler(this.btnTwist_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(320, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(178, 49);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Закончить";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.lblNotes);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnTwist);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.txtUsersWords);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(37, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 346);
            this.panel1.TabIndex = 15;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(339, 199);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 36);
            this.button9.TabIndex = 19;
            this.button9.Text = "И";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(297, 199);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 36);
            this.button8.TabIndex = 18;
            this.button8.Text = "З";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotes.Location = new System.Drawing.Point(21, 12);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(341, 85);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(544, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Таймер:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(656, 467);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 29);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "100";
            // 
            // lBoxCorrect
            // 
            this.lBoxCorrect.FormattingEnabled = true;
            this.lBoxCorrect.ItemHeight = 20;
            this.lBoxCorrect.Location = new System.Drawing.Point(32, 76);
            this.lBoxCorrect.Name = "lBoxCorrect";
            this.lBoxCorrect.Size = new System.Drawing.Size(246, 204);
            this.lBoxCorrect.TabIndex = 2;
            this.lBoxCorrect.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lBoxCorrect_DrawItem);
            // 
            // lbl_Correct
            // 
            this.lbl_Correct.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Correct.Location = new System.Drawing.Point(10, 12);
            this.lbl_Correct.Name = "lbl_Correct";
            this.lbl_Correct.Size = new System.Drawing.Size(300, 61);
            this.lbl_Correct.TabIndex = 3;
            this.lbl_Correct.Text = "Правильные слова";
            this.lbl_Correct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Correct.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(32, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 64);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_Correct);
            this.panel2.Controls.Add(this.lBoxCorrect);
            this.panel2.Location = new System.Drawing.Point(440, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 346);
            this.panel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(797, 521);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аммаргана";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsersWords;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTwist;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ToolStripMenuItem menuBeginner;
        private System.Windows.Forms.ToolStripMenuItem menuMedium;
        private System.Windows.Forms.ToolStripMenuItem menuExpert;
        private System.Windows.Forms.ListBox lBoxCorrect;
        private System.Windows.Forms.Label lbl_Correct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}

