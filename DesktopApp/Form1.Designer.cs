namespace Bluetooth2
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.guest = new System.Windows.Forms.PictureBox();
            this.admin = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(162, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 181);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 3050;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox11);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox10);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox9);
            this.splitContainer1.Panel2.Controls.Add(this.textBox8);
            this.splitContainer1.Panel2.Controls.Add(this.textBox7);
            this.splitContainer1.Panel2.Controls.Add(this.textBox6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(929, 387);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 387);
            this.listBox1.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(273, 296);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(78, 20);
            this.textBox11.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "NFC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "CİVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "RAİN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "YL-69";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "MQ-9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "PIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "FLAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "LDR";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(273, 270);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(78, 20);
            this.textBox10.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(273, 244);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(78, 20);
            this.textBox9.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(52, 202);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(94, 25);
            this.textBox8.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(52, 167);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(52, 141);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(94, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(52, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 419);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Bluetooth2.Properties.Resources._1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.guest);
            this.tabPage1.Controls.Add(this.admin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 393);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 40;
            // 
            // guest
            // 
            this.guest.Image = global::Bluetooth2.Properties.Resources._2;
            this.guest.Location = new System.Drawing.Point(598, 170);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(119, 178);
            this.guest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guest.TabIndex = 1;
            this.guest.TabStop = false;
            this.guest.Visible = false;
            // 
            // admin
            // 
            this.admin.Image = global::Bluetooth2.Properties.Resources._3;
            this.admin.Location = new System.Drawing.Point(598, 170);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(119, 178);
            this.admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admin.TabIndex = 0;
            this.admin.TabStop = false;
            this.admin.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 393);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Sensor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.PictureBox admin;
        private System.Windows.Forms.PictureBox guest;
        private System.Windows.Forms.Label label9;
    }
}

