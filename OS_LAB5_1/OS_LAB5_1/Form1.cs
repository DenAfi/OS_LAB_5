using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OS_LAB5_1
{
    public partial class Form1 : Form
    {
        private int[,] arr;
        private int fsum, ssum;
        private Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Відпоідь";
            textBox1.Enabled = false;

        }


        private void Exit_Button_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Get_Mas(int[,] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[i, j] = this.arr[i, j];
                }
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            int size = 0;
            sw.Reset();
            sw.Start();
            try
            {
                size = int.Parse(Mas_Len.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ви не увели розмір масиву", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            this.arr = new int[size, size];
            Headache box = new Headache(ref this.arr, ref this.fsum);
            if (mutex_work.Checked == true) {
                Thread thr1 = new Thread(new ParameterizedThreadStart(Class_Tasks.Mas_Init));
                thr1.Start(box);
                thr1.Join();
                Thread1_Id.Text = box.ThreadID;
            }
            else { 
                Thread MyThread1 = new Thread(new ParameterizedThreadStart(Class_Tasks.Mananger));
                MyThread1.Start(box);
                MyThread1.Join();

                Thread1_Id.Text = box.ThreadID;
                
            }
            if (size == 0)
            {
                return;
            }
            else
            {
                //  Table_Fill(Table1, box);
            }
            sw.Stop();
            Work_Time.Text = sw.ElapsedMilliseconds.ToString();
           
            }

        private void безМютексіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 0;
            try
            {
                 size = int.Parse(Mas_Len.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ви не увели розмір масиву", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            this.arr = new int[size, size];
            Class_Tasks.Null_Arr(ref this.arr);
            sw.Start();
            fsum = 0;
            ssum = 0;
            Headache box1 = new Headache(ref this.arr, ref this.fsum);
            Headache box2 = new Headache(ref this.arr, ref this.ssum);
            Thread thr1 = new Thread(new ParameterizedThreadStart(Class_Tasks.Mas_Init));
            Thread thr2 = new Thread(new ParameterizedThreadStart(Class_Tasks.Rev_Mas_Find));
            thr1.Start(box1);
            thr2.Start(box2);

            thr1.Join();
            thr2.Join();
            Thread1_Id.Text = box1.ThreadID;
            Thread2_ID.Text = box2.ThreadID;
            //Table_Fill(Table1, box1);
            //Table_Fill(Table2, box2);
            if (fsum == ssum)
            {
                textBox1.Text = "Суми співпадають";
            }
            else
            {
                textBox1.Text = "Суми не співпадають";
            }
            sw.Stop();
            Work_Time.Text = sw.ElapsedMilliseconds.ToString();
            sw.Reset();
        }

        private void Table_Fill( DataGridView table, Headache box){
            int size = box.arr.GetLength(0);
            table.RowCount = size;
            table.ColumnCount = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    DataGridViewTextBoxCell data = new DataGridViewTextBoxCell();
                    data.Value = box.arr[i, j];
                    table[i, j] = data;
                }
            }
            table.Visible = true;
        }


        private void Process_Button_Click(object sender, EventArgs e)
        {
            sw.Start();
            int size = arr.GetLength(0);
            Headache box = new Headache(ref this.arr, ref this.ssum);
            if (mutex_work.Checked == true)
            {
                Thread Mythread2 = new Thread(new ParameterizedThreadStart(Class_Tasks.Mananger));
                Mythread2.Start(box);

                Mythread2.Join();
                Thread2_ID.Text = box.ThreadID;
            }
            else {
                Thread thr2 = new Thread(new ParameterizedThreadStart(Class_Tasks.Rev_Mas_Find));
                thr2.Start(box);
                thr2.Join();
                Thread2_ID.Text = box.ThreadID;
            }
            if(size == 0)
            {
                
            }
            else
            {
                //Table_Fill(Table2, box);
               
            }     

            if (fsum == ssum)
            {
                textBox1.Text = "Суми співпадають";
            }
            else
            {
                textBox1.Text = "Суми не співпадають";
            }
            sw.Stop();
            Work_Time.Text = sw.ElapsedMilliseconds.ToString();
            sw.Reset();
        }
       
    }
}
