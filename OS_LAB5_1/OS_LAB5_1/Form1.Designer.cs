
namespace OS_LAB5_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Start_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Process_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.безМютексіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Work_Time = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mas_Len = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.Thread1_Id = new System.Windows.Forms.TextBox();
            this.Thread2_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Table2 = new System.Windows.Forms.DataGridView();
            this.mutex_work = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start_Button,
            this.Process_Button,
            this.проПрограмуToolStripMenuItem,
            this.Exit_Button,
            this.безМютексіToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Меню";
            // 
            // Start_Button
            // 
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(50, 20);
            this.Start_Button.Text = "Старт";
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Process_Button
            // 
            this.Process_Button.Name = "Process_Button";
            this.Process_Button.Size = new System.Drawing.Size(51, 20);
            this.Process_Button.Text = "Запит";
            this.Process_Button.Click += new System.EventHandler(this.Process_Button_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = global::OS_LAB5_1.Properties.Resources.icons8_выход_50;
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(28, 20);
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // безМютексіToolStripMenuItem
            // 
            this.безМютексіToolStripMenuItem.Name = "безМютексіToolStripMenuItem";
            this.безМютексіToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.безМютексіToolStripMenuItem.Text = "Без м\'ютексі";
            this.безМютексіToolStripMenuItem.Click += new System.EventHandler(this.безМютексіToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Work_Time);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Mas_Len);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для вводу";
            // 
            // Work_Time
            // 
            this.Work_Time.Enabled = false;
            this.Work_Time.Location = new System.Drawing.Point(62, 127);
            this.Work_Time.Name = "Work_Time";
            this.Work_Time.Size = new System.Drawing.Size(100, 33);
            this.Work_Time.TabIndex = 5;
            this.Work_Time.Text = "Час праці";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 33);
            this.textBox1.TabIndex = 4;
            // 
            // Mas_Len
            // 
            this.Mas_Len.Location = new System.Drawing.Point(164, 37);
            this.Mas_Len.Name = "Mas_Len";
            this.Mas_Len.Size = new System.Drawing.Size(75, 33);
            this.Mas_Len.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Розмір масиву";
            // 
            // Table1
            // 
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.Location = new System.Drawing.Point(497, 49);
            this.Table1.Name = "Table1";
            this.Table1.RowTemplate.Height = 25;
            this.Table1.Size = new System.Drawing.Size(240, 150);
            this.Table1.TabIndex = 2;
            this.Table1.Visible = false;
            // 
            // Thread1_Id
            // 
            this.Thread1_Id.Location = new System.Drawing.Point(345, 67);
            this.Thread1_Id.Name = "Thread1_Id";
            this.Thread1_Id.Size = new System.Drawing.Size(100, 23);
            this.Thread1_Id.TabIndex = 3;
            // 
            // Thread2_ID
            // 
            this.Thread2_ID.Location = new System.Drawing.Point(345, 250);
            this.Thread2_ID.Name = "Thread2_ID";
            this.Thread2_ID.Size = new System.Drawing.Size(100, 23);
            this.Thread2_ID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thread1 ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thread2 ID:";
            // 
            // Table2
            // 
            this.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table2.Location = new System.Drawing.Point(497, 250);
            this.Table2.Name = "Table2";
            this.Table2.RowTemplate.Height = 25;
            this.Table2.Size = new System.Drawing.Size(240, 150);
            this.Table2.TabIndex = 7;
            this.Table2.Visible = false;
            // 
            // mutex_work
            // 
            this.mutex_work.AutoSize = true;
            this.mutex_work.Location = new System.Drawing.Point(18, 225);
            this.mutex_work.Name = "mutex_work";
            this.mutex_work.Size = new System.Drawing.Size(135, 19);
            this.mutex_work.TabIndex = 9;
            this.mutex_work.Text = "Вимкнути м\'ютекси";
            this.mutex_work.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mutex_work);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Thread2_ID);
            this.Controls.Add(this.Thread1_Id);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Start_Button;
        private System.Windows.Forms.ToolStripMenuItem Process_Button;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Mas_Len;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Work_Time;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.TextBox Thread1_Id;
        private System.Windows.Forms.TextBox Thread2_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Table2;
        private System.Windows.Forms.ToolStripMenuItem безМютексіToolStripMenuItem;
        private System.Windows.Forms.CheckBox mutex_work;
    }
}

