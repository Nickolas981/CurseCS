namespace CurseCS
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.obLabel1 = new System.Windows.Forms.Label();
            this.porLabel1 = new System.Windows.Forms.Label();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ZlitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShellaBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SpeedBtn = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.visualStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioShella = new System.Windows.Forms.RadioButton();
            this.radioSpeed = new System.Windows.Forms.RadioButton();
            this.radiozlit = new System.Windows.Forms.RadioButton();
            this.countOfElem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grafic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countOfElem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1920, 720);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.MainText);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1912, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Великі числа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.obLabel1);
            this.groupBox1.Controls.Add(this.porLabel1);
            this.groupBox1.Controls.Add(this.timeLabel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ZlitBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ShellaBtn);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.SpeedBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1904, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управління";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(842, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Запись в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // obLabel1
            // 
            this.obLabel1.AutoSize = true;
            this.obLabel1.Location = new System.Drawing.Point(1255, 27);
            this.obLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.obLabel1.Name = "obLabel1";
            this.obLabel1.Size = new System.Drawing.Size(16, 17);
            this.obLabel1.TabIndex = 15;
            this.obLabel1.Text = "2";
            // 
            // porLabel1
            // 
            this.porLabel1.AutoSize = true;
            this.porLabel1.Location = new System.Drawing.Point(1087, 27);
            this.porLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.porLabel1.Name = "porLabel1";
            this.porLabel1.Size = new System.Drawing.Size(16, 17);
            this.porLabel1.TabIndex = 14;
            this.porLabel1.Text = "1";
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Location = new System.Drawing.Point(1392, 27);
            this.timeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(16, 17);
            this.timeLabel1.TabIndex = 13;
            this.timeLabel1.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1150, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "К-сть обмінів:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1000, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "К-сть пор.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1321, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Час(мс):";
            // 
            // textBox2
            // 
            this.textBox2.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.textBox2.Location = new System.Drawing.Point(156, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textBox2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBox2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1784, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.MaximumSize = new System.Drawing.Size(100, 28);
            this.button1.MinimumSize = new System.Drawing.Size(100, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вихід";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZlitBtn
            // 
            this.ZlitBtn.Location = new System.Drawing.Point(499, 21);
            this.ZlitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZlitBtn.Name = "ZlitBtn";
            this.ZlitBtn.Size = new System.Drawing.Size(100, 28);
            this.ZlitBtn.TabIndex = 3;
            this.ZlitBtn.Text = "Злиття";
            this.ZlitBtn.UseVisualStyleBackColor = true;
            this.ZlitBtn.Click += new System.EventHandler(this.ZlitBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Розмір масиву:";
            // 
            // ShellaBtn
            // 
            this.ShellaBtn.Location = new System.Drawing.Point(715, 21);
            this.ShellaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShellaBtn.Name = "ShellaBtn";
            this.ShellaBtn.Size = new System.Drawing.Size(100, 28);
            this.ShellaBtn.TabIndex = 5;
            this.ShellaBtn.Text = "Шелла";
            this.ShellaBtn.UseVisualStyleBackColor = true;
            this.ShellaBtn.Click += new System.EventHandler(this.ShellaBtn_Click_1);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(391, 21);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 28);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SpeedBtn
            // 
            this.SpeedBtn.Location = new System.Drawing.Point(607, 21);
            this.SpeedBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SpeedBtn.Name = "SpeedBtn";
            this.SpeedBtn.Size = new System.Drawing.Size(100, 28);
            this.SpeedBtn.TabIndex = 4;
            this.SpeedBtn.Text = "Швидкий";
            this.SpeedBtn.UseVisualStyleBackColor = true;
            this.SpeedBtn.Click += new System.EventHandler(this.SpeedBtn_Click);
            // 
            // MainText
            // 
            this.MainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainText.Location = new System.Drawing.Point(11, 70);
            this.MainText.Margin = new System.Windows.Forms.Padding(4);
            this.MainText.Name = "MainText";
            this.MainText.ReadOnly = true;
            this.MainText.Size = new System.Drawing.Size(1877, 613);
            this.MainText.TabIndex = 8;
            this.MainText.Text = "";
            this.MainText.TextChanged += new System.EventHandler(this.MainText_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1912, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Візуалізація";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.visualStart);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioShella);
            this.groupBox3.Controls.Add(this.radioSpeed);
            this.groupBox3.Controls.Add(this.radiozlit);
            this.groupBox3.Controls.Add(this.countOfElem);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(4, 607);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1904, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Панель управління";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1732, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Вийти з програми";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // visualStart
            // 
            this.visualStart.Location = new System.Drawing.Point(645, 27);
            this.visualStart.Margin = new System.Windows.Forms.Padding(4);
            this.visualStart.Name = "visualStart";
            this.visualStart.Size = new System.Drawing.Size(153, 41);
            this.visualStart.TabIndex = 6;
            this.visualStart.Text = "Запуск Візуалізації";
            this.visualStart.UseVisualStyleBackColor = true;
            this.visualStart.Click += new System.EventHandler(this.visualStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Варіант сортування:";
            // 
            // radioShella
            // 
            this.radioShella.AutoSize = true;
            this.radioShella.Location = new System.Drawing.Point(423, 47);
            this.radioShella.Margin = new System.Windows.Forms.Padding(4);
            this.radioShella.Name = "radioShella";
            this.radioShella.Size = new System.Drawing.Size(72, 21);
            this.radioShella.TabIndex = 4;
            this.radioShella.TabStop = true;
            this.radioShella.Text = "Шелла";
            this.radioShella.UseVisualStyleBackColor = true;
            this.radioShella.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioSpeed
            // 
            this.radioSpeed.AutoSize = true;
            this.radioSpeed.Location = new System.Drawing.Point(329, 47);
            this.radioSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.radioSpeed.Name = "radioSpeed";
            this.radioSpeed.Size = new System.Drawing.Size(78, 21);
            this.radioSpeed.TabIndex = 3;
            this.radioSpeed.TabStop = true;
            this.radioSpeed.Text = "Швидке";
            this.radioSpeed.UseVisualStyleBackColor = true;
            this.radioSpeed.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radiozlit
            // 
            this.radiozlit.AutoSize = true;
            this.radiozlit.Checked = true;
            this.radiozlit.Location = new System.Drawing.Point(231, 47);
            this.radiozlit.Margin = new System.Windows.Forms.Padding(4);
            this.radiozlit.Name = "radiozlit";
            this.radiozlit.Size = new System.Drawing.Size(85, 21);
            this.radiozlit.TabIndex = 2;
            this.radiozlit.TabStop = true;
            this.radiozlit.Text = "Злиттям";
            this.radiozlit.UseVisualStyleBackColor = true;
            this.radiozlit.CheckedChanged += new System.EventHandler(this.radiozlit_CheckedChanged);
            // 
            // countOfElem
            // 
            this.countOfElem.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countOfElem.Location = new System.Drawing.Point(12, 47);
            this.countOfElem.Margin = new System.Windows.Forms.Padding(4);
            this.countOfElem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countOfElem.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countOfElem.Name = "countOfElem";
            this.countOfElem.Size = new System.Drawing.Size(143, 22);
            this.countOfElem.TabIndex = 1;
            this.countOfElem.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кількість елементів:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grafic);
            this.groupBox2.Location = new System.Drawing.Point(11, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1880, 588);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Візуалізація сортування";
            // 
            // grafic
            // 
            this.grafic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafic.BackColor = System.Drawing.Color.Black;
            this.grafic.Location = new System.Drawing.Point(8, 23);
            this.grafic.Margin = new System.Windows.Forms.Padding(4);
            this.grafic.Name = "grafic";
            this.grafic.Size = new System.Drawing.Size(1860, 553);
            this.grafic.TabIndex = 0;
            this.grafic.TabStop = false;
            this.grafic.Click += new System.EventHandler(this.pictureBox1_Click);
            this.grafic.Resize += new System.EventHandler(this.grafic_Resize_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "output.txt";
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 718);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(891, 671);
            this.Name = "Form1";
            this.Text = "Курсова Робота";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countOfElem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ZlitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShellaBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button SpeedBtn;
        private System.Windows.Forms.RichTextBox MainText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox grafic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown countOfElem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioShella;
        private System.Windows.Forms.RadioButton radioSpeed;
        private System.Windows.Forms.RadioButton radiozlit;
        private System.Windows.Forms.Button visualStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label obLabel1;
        private System.Windows.Forms.Label porLabel1;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

