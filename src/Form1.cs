using System;
using InputBox;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
namespace Version1
{
    public partial class Form1 : Form , IView
    {
        public string textBox1Text { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string textBox2Text { get { return textBox2.Text; } set { textBox2.Text = value; } }
        public string textBox3Text { get { return textBox3.Text; } set { textBox3.Text = value; } }
        public string textBox4Text { get { return textBox4.Text; } set { textBox4.Text = value; } }
        public string textBox5Text { get { return textBox5.Text; } set { textBox5.Text = value; } }
        public string textBox6Text { get { return textBox6.Text; } set { textBox6.Text = value; } }
        public string textBox7Text { get { return textBox7.Text; } set { textBox7.Text = value; } }
        public string textBox8Text { get { return textBox8.Text; } set { textBox8.Text = value; } }
        public string textBox9Text { get { return textBox9.Text; } set { textBox9.Text = value; } }
        public string textBox10Text { get { return textBox10.Text; } set { textBox10.Text = value; } }
        public string listBox1SelectedItem { get { return listBox1.SelectedItem.ToString(); } }
        public string listBox2SelectedItem { get { return listBox2.SelectedItem.ToString(); } }
        public int listBox1SelectedIndex { get { return listBox1.SelectedIndex; } set { listBox1.SelectedIndex = value; } }
        public int listBox2SelectedIndex { get { return listBox2.SelectedIndex; } set { listBox2.SelectedIndex = value; } }
        public int progressBar1Value { get { return progressBar1.Value; } set { progressBar1.Value = value; } }
        public int progressBar1MaxValue { get { return progressBar1.Maximum; } }
        public int progressBar2Value { get { return progressBar2.Value; } set { progressBar2.Value = value; } }
        public int progressBar2MaxValue { get { return progressBar2.Maximum; }}
        public int progressBar3Value { get { return progressBar3.Value; } set { progressBar3.Value = value; } }
        public int progressBar3MaxValue { get { return progressBar3.Maximum; } }

        public event EventHandler listBox1_MouseDouble;
        public event EventHandler listBox2_MouseDouble;
        public event EventHandler WriteDrives_1;
        public event EventHandler WriteDrives_2;
        public event EventHandler WriteDirectories_1;
        public event EventHandler WriteDirectories_2;
        public event EventHandler BackClick1;
        public event EventHandler BackClick2;
        public event EventHandler listBox1_SelectedChanged;
        public event EventHandler listBox2_SelectedChanged;
        public event EventHandler button7Click;
        public event EventHandler button3Click;
        public event EventHandler button6Click;
        public event EventHandler button4Click;
        public event EventHandler button9Click;
        public event EventHandler button5Click;
        public event EventHandler button13Click;
        public event EventHandler button14Click;
        public event EventHandler button2_1Click;
        public event EventHandler button18Click;
        public event EventHandler button17Click;
        public event EventHandler button19Click;
        public event EventHandler button22Click;
        public event EventHandler button23Click;
        public event EventHandler button24Click;
        public event EventHandler button25Click;
        public event EventHandler listBox1KeyPress;
        public event EventHandler listBox2KeyPress;


        public static CancellationTokenSource cancelTokenSourceD = new CancellationTokenSource();
        public static  CancellationToken tokenD = cancelTokenSourceD.Token;
        public static CancellationTokenSource cancelTokenSourceF = new CancellationTokenSource();
        public static CancellationToken tokenF = cancelTokenSourceF.Token;

        public Form1()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
           WriteDrives_1(this,EventArgs.Empty);
           WriteDrives_2(this,EventArgs.Empty);

        }

        public void listBox1Focus()
        {
            listBox1.Focus();
        }

        public void listBox2Focus()
        {
            listBox2.Focus();
        }

        public void DisplayItems1(List<string> items)
        {
            listBox1.Items.Clear();
            foreach (string crrfiles in items)
            {
                if (crrfiles != null)
                    listBox1.Items.Add(crrfiles);
            }
        }

        public void DisplayItems2(List<string> items)
        {
            listBox2.Items.Clear();
            foreach (string crrfiles in items)
            {
                if (crrfiles != null)
                    listBox2.Items.Add(crrfiles);
            }
        }

        public void ChangeTextBox1(string name)
        {
            textBox1.Text = name;
        }

        public void ChangeTextBox2(string name)
        {
            textBox2.Text = name;
        }

        public void listBox1ClearSelected()
        {
            listBox1.ClearSelected();
        }

        public void listBox2ClearSelected()
        {
            listBox2.ClearSelected();
        }

        public  void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteDirectories_1(sender, EventArgs.Empty);
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                listBox1_MouseDouble(this, EventArgs.Empty);
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BackClick1(sender, EventArgs.Empty);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WriteDrives_1(sender, EventArgs.Empty);
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7Click(sender, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3Click(sender, EventArgs.Empty);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6Click(sender, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WriteDirectories_2(sender, EventArgs.Empty);
         
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WriteDrives_2(sender, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            BackClick2(sender, EventArgs.Empty);
        }

        void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                listBox2_MouseDouble(sender, EventArgs.Empty);
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4Click(sender, EventArgs.Empty);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox1KeyPress(sender, e);           
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {          
        }


        private void listBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox2KeyPress(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9Click(sender, EventArgs.Empty);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) 
        {
            button5Click(sender, EventArgs.Empty);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void button13_Click(object sender, EventArgs e)
        {
            button13Click(sender, EventArgs.Empty);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14Click(sender, EventArgs.Empty);
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            button2_1Click(sender, EventArgs.Empty);
        }

        public void button16_Click(object sender, EventArgs e)
        {
            cancelTokenSourceD.Cancel();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cancelTokenSourceF.Cancel();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18Click(sender, EventArgs.Empty);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17Click(sender, EventArgs.Empty);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19Click(sender, EventArgs.Empty);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1_SelectedChanged(sender, EventArgs.Empty);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox2_SelectedChanged(sender, EventArgs.Empty);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22Click(sender, EventArgs.Empty);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23Click(sender, EventArgs.Empty);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24Click(sender, EventArgs.Empty);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25Click(sender, EventArgs.Empty);
        }
    }
}
