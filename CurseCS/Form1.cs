using System;
using System.Drawing;
using System.Windows.Forms;
using static System.String;
using System.Diagnostics;
using System.Threading;



namespace CurseCS
{
    public partial class Form1 : Form, Drawble
    {
        int counterIF, counterSWAP;        
        Stopwatch time = new Stopwatch();
        int[] mass;
        private BufferedGraphics buffered;
        int n;
        Logic logic,logic1;
        Thread thread;
        public Form1()
        {            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            buffered = BufferedGraphicsManager.Current.Allocate(grafic.CreateGraphics(), grafic.DisplayRectangle);
            button3.Enabled = false;
            ShellaBtn.Enabled = false;
            SpeedBtn.Enabled = false;
            ZlitBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private static void Swap(ref int left, ref int right)
        {
            int t = left;
            left = right;
            right = t;
        }
        public void Draw()
        {
            drawMarking();
            drawSort(logic1.sMass);
            buffered.Render();
            //Thread.Sleep(1);
        }
        //private void MetZlit(int Left, int Right)
        //{

        //    if (Right == Left)
        //    {
        //        Draw();
        //        return;
        //    }

        //    if (Right - Left == 1)
        //    {
        //        if (mass[Right] < mass[Left])
        //        {
        //            Swap(ref mass[Right], ref mass[Left]);
        //        }
        //        Draw();
        //        return;
        //    }
        //    int medium = (Right + Left) / 2;
        //    MetZlit(Left, medium);
        //    MetZlit(medium + 1, Right);
        //    int[] buf = new int[n];
        //    int xl = Left;
        //    int xr = medium + 1;
        //    int cur = 0;
        //    while (Right - Left + 1 != cur)
        //    {
        //        if (xl > medium)
        //            buf[cur++] = mass[xr++];
        //        else if (xr > Right)
        //            buf[cur++] = mass[xl++];
        //        else if (mass[xl] > mass[xr])
        //            buf[cur++] = mass[xr++];
        //        else buf[cur++] = mass[xl++];

        //    }
        //    for (int i = 0; i < cur; i++)
        //        mass[i + Left] = buf[i];
        //    Draw();
        //}
        //private void MetShella()
        //{
        //    int i, j, k;
        //    int t;
        //    for (k = n / 2; k > 0; k /= 2)
        //        for (i = k; i < n; i += 1)
        //        {
        //            t = mass[i];
        //            for (j = i; j >= k; j -= k)
        //            {
        //                if (t < mass[j - k])
        //                {
        //                    mass[j] = mass[j - k];
        //                    Draw();
        //                }
        //                else
        //                    break;
        //            }
        //            mass[j] = t;
        //        }
        //}
        //private void SpeedMet(int first, int last)
        //{
        //    int i = first, j = last, x = mass[(first + last) / 2];

        //    do
        //    {
        //        while (mass[i] < x) i++;
        //        while (mass[j] > x) j--;

        //        if (i <= j)
        //        {
        //            if (mass[i] > mass[j]) Swap(ref mass[i], ref mass[j]);
        //            Draw();
        //            i++;
        //            j--;
        //        }
        //    } while (i <= j);

        //    if (i < last)
        //        SpeedMet(i, last);
        //    if (first < j)
        //        SpeedMet(first, j);
        //}
        private void drawSort(int[] array)
        {

            Pen pen;
            float wid = grafic.Width / array.Length;
            float height = grafic.Height / 50;
            for (int i = 1; i <= 50; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    pen = new Pen(Color.White);
                    if (j % 2 == 1)
                    {
                        pen = new Pen(Color.Gray);
                    }



                    if (array[j] >= i)
                        buffered.Graphics.FillRectangle(new SolidBrush(pen.Color), wid * j, grafic.Height - height * i, wid, height);
                }
            }
        }

        private void drawMarking()
        {
            buffered = BufferedGraphicsManager.Current.Allocate(grafic.CreateGraphics(), grafic.DisplayRectangle);

            var pen = new Pen(Color.DarkBlue);

            for (int i = 0; i < grafic.Height; i += 15)
                buffered.Graphics.DrawLine(pen, 0, grafic.Height - i, grafic.Width, grafic.Height - i);
            for (int i = 0; i < grafic.Width; i += 15)
                buffered.Graphics.DrawLine(pen, i, 0, i, grafic.Width);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainText_TextChanged(object sender, EventArgs e)
        {

        }
        private void Out()
        {
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

            logic = new Logic(Convert.ToInt32(textBox2.Text), this, 1000);
            MainText.Text = Join("  ", logic.GetMass());

            //.Text = Join("  ", logic.GetMass());
            StartBtn.Text = "Refresh";
            button3.Enabled = false;
            ShellaBtn.Enabled = true;
            SpeedBtn.Enabled = true;
            ZlitBtn.Enabled = true;

        }

        private void SpeedBtn_Click(object sender, EventArgs e)
        {
            counterSWAP = 0; counterIF = 0;
            time.Restart();
            logic.SpeedMethod(ref counterIF, ref counterSWAP);
            time.Stop();
            porLabel1.Text = counterIF.ToString();
            obLabel1.Text = counterSWAP.ToString();
            timeLabel1.Text = time.ElapsedMilliseconds.ToString();
            MainText.Text = Join("  ", logic.GetMass());
            button3.Enabled = true;
        }

        private void ShellaBtn_Click_1(object sender, EventArgs e)
        {
            counterSWAP = 0; counterIF = 0;
            time.Restart();
            logic.MethodShella(ref counterIF, ref counterSWAP);
            time.Stop();
            porLabel1.Text = counterIF.ToString();
            obLabel1.Text = counterSWAP.ToString();
            timeLabel1.Text = time.ElapsedMilliseconds.ToString();
            MainText.Text = Join("  ", logic.GetMass());
            button3.Enabled = true;

        }

        private void ZlitBtn_Click_1(object sender, EventArgs e)
        {
            counterSWAP = 0;counterIF = 0;
            time.Restart();
            logic.MethodZlit(ref counterIF, ref counterSWAP);
            time.Stop();
            porLabel1.Text = counterIF.ToString();
            obLabel1.Text = counterSWAP.ToString();
            timeLabel1.Text = time.ElapsedMilliseconds.ToString();
            MainText.Text = Join("  ", logic.GetMass());
            button3.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiozlit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void visualStart_Click(object sender, EventArgs e)
        {
            if (visualStart.Text == "СТОП")
            {
                thread.Suspend();
                visualStart.Text = "Запуск Візуалізації";
            }

            //visualStart.Enabled = false;
            else
            {
                thread = new Thread(rad);
                n = (int)countOfElem.Value;
                logic1 = new Logic(n, this, 50);
                mass = new int[n];
                var random = new Random();
                drawMarking();
                for (var i = 0; i < n; i++)
                {
                    mass[i] = random.Next(50) + 1;
                }
                //tabControl1.Enabled = false;
                visualStart.Text = "СТОП";
                thread.Start();
            }
            
            //if (radioShella.Checked == true)
            //{
            //    Thread thread = new Thread(logic.MetShellaD);
            //    thread.Start();
            //    //logic.MetShellaD();
            //}
            //else if (radioSpeed.Checked == true)
            //{

            //    logic.SpeedMetD(0, n - 1);
            //}
            //else
            //{
            //    logic.MetZlitD(0, n - 1);
            //}
            

        }
        private void rad()
        {
            if (radioShella.Checked == true)
            {
                //Thread thread = new Thread(logic.MetShellaD);
                //thread.Start();
                logic1.MetShellaD();
            }
            else if (radioSpeed.Checked == true)
            {

                logic1.SpeedMetD(0, n - 1);
            }
            else
            {
                logic1.MetZlitD(0, n - 1);
            }
            visualStart.Text = "Запуск Візуалізації";
           // visualStart.Enabled = true;
        }



        private void grafic_Resize_1(object sender, EventArgs e)
        {
            drawMarking();
            buffered.Render();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamWriter sr = new
                   System.IO.StreamWriter(openFileDialog1.FileName,false);
                MessageBox.Show("Запись пройшла успішно");
                sr.Write(MainText.Text);
                sr.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
