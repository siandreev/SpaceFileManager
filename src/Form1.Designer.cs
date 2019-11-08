namespace Version1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(11, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go this way";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(11, 265);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(773, 441);
            this.listBox1.TabIndex = 2;
            this.listBox1.Enter += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 712);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Rename (R)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 712);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Copy (C)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(635, 712);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Move (X)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(323, 712);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 42);
            this.button7.TabIndex = 9;
            this.button7.Text = "Delete (D)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(790, 265);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(773, 441);
            this.listBox2.TabIndex = 10;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.Enter += new System.EventHandler(this.listBox1_Enter);
            this.listBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox2_KeyPress);
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(790, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(531, 30);
            this.textBox2.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(790, 712);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 42);
            this.button9.TabIndex = 13;
            this.button9.Text = "Compress (Z)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(11, 712);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 42);
            this.button10.TabIndex = 14;
            this.button10.Text = "Back (W)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(668, 130);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 39);
            this.button11.TabIndex = 15;
            this.button11.Text = "Home ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1325, 130);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 39);
            this.button8.TabIndex = 16;
            this.button8.Text = "Go this way ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1446, 130);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(115, 39);
            this.button12.TabIndex = 17;
            this.button12.Text = "Home ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(790, 172);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(650, 77);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(11, 172);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(651, 77);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(790, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 45);
            this.button5.TabIndex = 21;
            this.button5.Text = "FindInfo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar1.Location = new System.Drawing.Point(966, 33);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(597, 24);
            this.progressBar1.TabIndex = 23;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(338, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(99, 36);
            this.button13.TabIndex = 24;
            this.button13.Text = "Find";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 9);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(319, 26);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "Enter name to find...";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(946, 712);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 42);
            this.button14.TabIndex = 26;
            this.button14.Text = "TextFileInfo (T)";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(443, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 36);
            this.button15.TabIndex = 28;
            this.button15.Text = "Cancel";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(443, 46);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(89, 36);
            this.button16.TabIndex = 29;
            this.button16.Text = "Cancel";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 52);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(321, 26);
            this.textBox6.TabIndex = 30;
            this.textBox6.Text = "Enter adress to download ...";
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar2.Location = new System.Drawing.Point(538, 12);
            this.progressBar2.Maximum = 1000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(246, 26);
            this.progressBar2.TabIndex = 31;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar3.Location = new System.Drawing.Point(538, 52);
            this.progressBar3.Maximum = 1000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(246, 26);
            this.progressBar3.TabIndex = 32;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1257, 712);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(150, 42);
            this.button17.TabIndex = 33;
            this.button17.Text = "Crypt (Y)";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1102, 712);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(150, 42);
            this.button18.TabIndex = 34;
            this.button18.Text = "MD5 (V)";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(1413, 712);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(150, 42);
            this.button19.TabIndex = 35;
            this.button19.Text = "DeCrypt (E)";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(667, 172);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(118, 77);
            this.button20.TabIndex = 36;
            this.button20.Text = "Properties";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(1448, 172);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(115, 77);
            this.button21.TabIndex = 37;
            this.button21.Text = "Properties";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(284, 89);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(104, 35);
            this.button22.TabIndex = 38;
            this.button22.Text = "AddFile (A)";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(667, 89);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(117, 35);
            this.button23.TabIndex = 39;
            this.button23.Text = "AddFolder (F)";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(11, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(267, 26);
            this.textBox7.TabIndex = 40;
            this.textBox7.Text = "NewFile";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(394, 93);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(267, 26);
            this.textBox8.TabIndex = 41;
            this.textBox8.Text = "NewFolder";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(1063, 88);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(104, 35);
            this.button24.TabIndex = 42;
            this.button24.Text = "AddFile (J)";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(790, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(267, 26);
            this.textBox9.TabIndex = 43;
            this.textBox9.Text = "NewFile";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(1446, 86);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(116, 35);
            this.button25.TabIndex = 44;
            this.button25.Text = "AddFolder (K)";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1173, 93);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(267, 26);
            this.textBox10.TabIndex = 45;
            this.textBox10.Text = "NewFolder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 766);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1609, 822);
            this.MinimumSize = new System.Drawing.Size(1609, 822);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceFileManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox textBox10;
    }
}

