using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace Version1
{
    interface IView
    {
        string textBox1Text { get; set; }
        string textBox2Text { get; set; }
        string textBox3Text { get; set; }
        string textBox4Text { get; set; }
        string textBox5Text { get; set; }
        string textBox6Text { get; set; }
        string textBox7Text { get; set; }
        string textBox8Text { get; set; }
        string textBox9Text { get; set; }
        string textBox10Text { get; set; }
        string listBox1SelectedItem { get; }
        string listBox2SelectedItem { get; }
        int listBox1SelectedIndex { get; set; }
        int listBox2SelectedIndex { get; set; }
        int progressBar1Value { get; set; }
        int progressBar1MaxValue { get; }
        int progressBar2Value { get; set; }
        int progressBar2MaxValue { get; }
        int progressBar3Value { get; set; }
        int progressBar3MaxValue { get; }

        event EventHandler listBox1_MouseDouble;
        event EventHandler listBox2_MouseDouble;
        event EventHandler WriteDrives_1;
        event EventHandler WriteDrives_2;
        event EventHandler WriteDirectories_1;
        event EventHandler WriteDirectories_2;
        event EventHandler BackClick1;
        event EventHandler BackClick2;
        event EventHandler listBox1_SelectedChanged;
        event EventHandler listBox2_SelectedChanged;
        event EventHandler button7Click;
        event EventHandler button3Click;
        event EventHandler button6Click;
        event EventHandler button4Click;
        event EventHandler button9Click;
        event EventHandler button5Click;
        event EventHandler button13Click;
        event EventHandler button14Click;
        event EventHandler button2_1Click;
        event EventHandler button18Click;
        event EventHandler button17Click;
        event EventHandler button19Click;
        event EventHandler button22Click;
        event EventHandler button23Click;
        event EventHandler button24Click;
        event EventHandler button25Click;
        event EventHandler listBox1KeyPress;
        event EventHandler listBox2KeyPress;


        void DisplayItems1(List<string> items);
        void DisplayItems2(List<string> items);
        void ChangeTextBox1(string name);
        void ChangeTextBox2(string name);
        void listBox1ClearSelected();
        void listBox2ClearSelected();
        void listBox1Focus();
        void listBox2Focus();

    }
    class Presenter
    {
        private IView view;
        public Presenter(IView view)
        {
            this.view = view;
            view.listBox1_MouseDouble += new EventHandler(ListBox1DoubleClick);
            view.listBox2_MouseDouble += new EventHandler(ListBox2DoubleClick);
            view.WriteDrives_1 += new EventHandler(Drives1);
            view.WriteDrives_2 += new EventHandler(Drives2);
            view.WriteDirectories_1 += new EventHandler(Directories1);
            view.WriteDirectories_2 += new EventHandler(Directories2);
            view.BackClick1 += new EventHandler(Back1);
            view.BackClick2 += new EventHandler(Back2);
            view.listBox1_SelectedChanged += new EventHandler(listBox1_SelectedChanged);
            view.listBox2_SelectedChanged += new EventHandler(listBox2_SelectedChanged);
            view.button7Click += new EventHandler(button7);
            view.button3Click += new EventHandler(button3);
            view.button6Click += new EventHandler(button6);
            view.button4Click += new EventHandler(button4);
            view.button9Click += new EventHandler(button9);
            view.button5Click += new EventHandler(button5);
            view.button13Click += new EventHandler(button13);
            view.button14Click += new EventHandler(button14);
            view.button2_1Click += new EventHandler(button2_1);
            view.button18Click += new EventHandler(button18);
            view.button17Click += new EventHandler(button17);
            view.button19Click += new EventHandler(button19);
            view.button22Click += new EventHandler(button22);
            view.button23Click += new EventHandler(button23);
            view.button24Click += new EventHandler(button24);
            view.button25Click += new EventHandler(button25);
            view.listBox1KeyPress += new EventHandler(listBox1Press);
            view.listBox2KeyPress += new EventHandler(listBox2Press);

        }

        public void listBox1Press(object sender, EventArgs ev)
        {
            KeyPressEventArgs e = (KeyPressEventArgs)ev;
            string keys = "QqWwDdCcXxZzTtVvYyEeAaFfJjKk";
            if (!keys.Contains(e.KeyChar.ToString()))
            {
                try
                {
                    ListBox1DoubleClick(sender, ev);
                }
                catch { }

            }
            else
            {
                switch (e.KeyChar)
                {
                    case 'Q':
                        {
                            try
                            {
                                view.listBox1SelectedIndex = -1;
                                view.listBox2SelectedIndex = 0;
                                view.listBox2Focus();
                            }
                            catch { }

                        }
                        break;
                    case 'q':
                        {
                            try
                            {
                                view.listBox1SelectedIndex = -1;
                                view.listBox2SelectedIndex = 0;
                                view.listBox2Focus();
                            }
                            catch { }

                        }
                        break;
                    case 'W':
                        {
                            Back1(sender, EventArgs.Empty);
                        }
                        break;
                    case 'w':
                        {
                            Back1(sender, EventArgs.Empty);
                        }
                        break;
                    case 'C':
                        {
                            button4(sender, EventArgs.Empty);
                        }
                        break;
                    case 'c':
                        {
                            button4(sender, EventArgs.Empty);
                        }
                        break;
                    case 'X':
                        {
                            button6(sender, EventArgs.Empty);
                        }
                        break;
                    case 'x':
                        {
                            button6(sender, EventArgs.Empty);
                        }
                        break;
                    case 'D':
                        {
                            button7(sender, EventArgs.Empty);
                        }
                        break;
                    case 'd':
                        {
                            button7(sender, EventArgs.Empty);
                        }
                        break;
                    case 'R':
                        {
                            button3(sender, EventArgs.Empty);
                        }
                        break;
                    case 'r':
                        {
                            button3(sender, EventArgs.Empty);
                        }
                        break;
                    case 'Z':
                        {
                            button9(sender, EventArgs.Empty);
                        }
                        break;
                    case 'z':
                        {
                            button9(sender, EventArgs.Empty);
                        }
                        break;
                    case 'F':
                        {
                            button23(sender, EventArgs.Empty);
                        }
                        break;
                    case 'f':
                        {
                            button23(sender, EventArgs.Empty);
                        }
                        break;
                    case 'T':
                        {
                            button14(sender, EventArgs.Empty);
                        }
                        break;
                    case 't':
                        {
                            button14(sender, EventArgs.Empty);
                        }
                        break;
                    case 'V':
                        {
                            button18(sender, EventArgs.Empty);
                        }
                        break;
                    case 'v':
                        {
                            button18(sender, EventArgs.Empty);
                        }
                        break;
                    case 'Y':
                        {
                            button17(sender, EventArgs.Empty);
                        }
                        break;
                    case 'y':
                        {
                            button17(sender, EventArgs.Empty);
                        }
                        break;
                    case 'E':
                        {
                            button19(sender, EventArgs.Empty);
                        }
                        break;
                    case 'e':
                        {
                            button19(sender, EventArgs.Empty);
                        }
                        break;
                    case 'A':
                        {
                            button22(sender, EventArgs.Empty);
                        }
                        break;
                    case 'a':
                        {
                            button22(sender, EventArgs.Empty);
                        }
                        break;
                    case 'J':
                        {
                            button24(sender, EventArgs.Empty);
                        }
                        break;
                    case 'j':
                        {
                            button24(sender, EventArgs.Empty);
                        }
                        break;
                    case 'K':
                        {
                            button25(sender, EventArgs.Empty);
                        }
                        break;
                    case 'k':
                        {
                            button25(sender, EventArgs.Empty);
                        }
                        break;
                }
            }
        }

        public void listBox2Press(object sender, EventArgs ev)
        {
            string keys = "QqWwDdCcXxZzTtVvYyEeAaFfJjKk";
            KeyPressEventArgs e = (KeyPressEventArgs)ev;
            if (!keys.Contains(e.KeyChar.ToString()))
            {
                try
                {
                    ListBox2DoubleClick(sender, ev);
                }
                catch { }

            }
            else
            {
                switch (e.KeyChar)
                {
                    case 'Q':
                        {
                            try
                            {
                                view.listBox2SelectedIndex = -1;
                                view.listBox1SelectedIndex = 0;
                                view.listBox1Focus();
                            }
                            catch { }

                        }
                        break;
                    case 'q':
                        {
                            try
                            {
                                view.listBox2SelectedIndex = -1;
                                view.listBox1SelectedIndex = 0;
                                view.listBox1Focus();
                            }
                            catch { }

                        }
                        break;
                    case 'W':
                        {
                            Back2(sender, EventArgs.Empty);
                        }
                        break;
                    case 'w':
                        {
                            Back2(sender, EventArgs.Empty);
                        }
                        break;
                    case 'C':
                        {
                            button4(sender, EventArgs.Empty);
                        }
                        break;
                    case 'c':
                        {
                            button4(sender, EventArgs.Empty);
                        }
                        break;
                    case 'X':
                        {
                            button6(sender, EventArgs.Empty);
                        }
                        break;
                    case 'x':
                        {
                            button6(sender, EventArgs.Empty);
                        }
                        break;
                    case 'D':
                        {
                            button7(sender, EventArgs.Empty);
                        }
                        break;
                    case 'd':
                        {
                            button7(sender, EventArgs.Empty);
                        }
                        break;
                    case 'R':
                        {
                            button3(sender, EventArgs.Empty);
                        }
                        break;
                    case 'r':
                        {
                            button3(sender, EventArgs.Empty);
                        }
                        break;
                    case 'Z':
                        {
                            button9(sender, EventArgs.Empty);
                        }
                        break;
                    case 'z':
                        {
                            button9(sender, EventArgs.Empty);
                        }
                        break;
                    case 'F':
                        {
                            button23(sender, EventArgs.Empty);
                        }
                        break;
                    case 'f':
                        {
                            button23(sender, EventArgs.Empty);
                        }
                        break;
                    case 'T':
                        {
                            button14(sender, EventArgs.Empty);
                        }
                        break;
                    case 't':
                        {
                            button14(sender, EventArgs.Empty);
                        }
                        break;
                    case 'V':
                        {
                            button18(sender, EventArgs.Empty);
                        }
                        break;
                    case 'v':
                        {
                            button18(sender, EventArgs.Empty);
                        }
                        break;
                    case 'Y':
                        {
                            button17(sender, EventArgs.Empty);
                        }
                        break;
                    case 'y':
                        {
                            button17(sender, EventArgs.Empty);
                        }
                        break;
                    case 'E':
                        {
                            button19(sender, EventArgs.Empty);
                        }
                        break;
                    case 'e':
                        {
                            button19(sender, EventArgs.Empty);
                        }
                        break;
                    case 'A':
                        {
                            button22(sender, EventArgs.Empty);
                        }
                        break;
                    case 'a':
                        {
                            button22(sender, EventArgs.Empty);
                        }
                        break;
                    case 'J':
                        {
                            button24(sender, EventArgs.Empty);
                        }
                        break;
                    case 'j':
                        {
                            button24(sender, EventArgs.Empty);
                        }
                        break;
                    case 'K':
                        {
                            button25(sender, EventArgs.Empty);
                        }
                        break;
                    case 'k':
                        {
                            button25(sender, EventArgs.Empty);
                        }
                        break;

                }
            }


        }

        private void listBox1_SelectedChanged(object sender, EventArgs e)
        {
            try
            {
                WriteFileInfo1();
            }
            catch { }
            if (view.listBox1SelectedIndex != -1)
                view.listBox2ClearSelected();
        }

        private void listBox2_SelectedChanged(object sender, EventArgs e)
        {
            try
            {
                WriteFileInfo2();
            }
            catch { }
            if (view.listBox2SelectedIndex != -1)
                view.listBox1ClearSelected();
        }

        public void Back1(object sender, EventArgs e)
        {
            if (view.textBox1Text.Length != 3 && !(view.textBox1Text == "Drives" || view.textBox1Text == "drives" || view.textBox1Text == "Home" || view.textBox1Text == "home"))
            {
                string path = view.textBox1Text;
                path = path.Remove(path.Length - 1, 1);
                while (path[path.Length - 1] != '\\')
                {
                    path = path.Remove(path.Length - 1, 1);
                }
                var obj = Factory.Get(ref path);
                view.textBox1Text = path;
                view.DisplayItems1(obj.Open());
            }
            else
                WriteDrives1();
        }

        public void Back2(object sender, EventArgs e)
        {
            if (view.textBox2Text.Length != 3 && !(view.textBox2Text == "Drives" || view.textBox2Text == "drives" || view.textBox2Text == "Home" || view.textBox2Text == "home"))
            {
                string path = view.textBox2Text;
                path = path.Remove(path.Length - 1, 1);
                while (path[path.Length - 1] != '\\')
                {
                    path = path.Remove(path.Length - 1, 1);
                }
                var obj = Factory.Get(ref path);
                view.textBox2Text = path;
                view.DisplayItems2(obj.Open());
            }
            else
                WriteDrives2();
        }

        public void button7(object sendre, EventArgs e)
        {
            if (view.listBox1SelectedIndex != -1)
                Delete1();
            else if (view.listBox2SelectedIndex != -1)
                Delete2();
        }

        public void button3(object sender, EventArgs e)
        {
            try
            {
                if (view.listBox1SelectedIndex != -1)
                    Rename1();
                else if (view.listBox2SelectedIndex != -1)
                    Rename2();
            }
            catch { }
        }

        public void button6(object sender, EventArgs e)
        {
            try
            {
                if (view.listBox1SelectedIndex != -1)
                    Move1();
                else if (view.listBox2SelectedIndex != -1)
                    Move2();
            }
            catch { view.textBox2Text = "incorrect data selected"; }
        }

        public void button9(object sender, EventArgs e)
        {
                try
                {
                    if (view.listBox1SelectedIndex != -1)
                        Compress1();
                    else if (view.listBox2SelectedIndex != -1)
                        Compress2();
                }
                catch { view.textBox3Text = "incorrect data selected"; }
        }

        public void button4(object sender, EventArgs e)
        {
            try
            {
                if (view.listBox1SelectedIndex != -1)
                Copy1();
            else if (view.listBox2SelectedIndex != -1)
                Copy2();
            }
            catch { view.textBox3Text = "incorrect data selected"; }
        }

        public void button5(object sender, EventArgs e)
        {
            var progress = new Progress<int>(i => view.progressBar1Value = i * view.progressBar1MaxValue / 100);
            string path = "";
            if (new Files("Output.txt").Exist())
            {
                new Files("Output.txt").Delete();
            }
            new Files("Output.txt").Create();
            if (view.listBox1SelectedIndex != -1)
                path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            Task.Run(() =>
            {
            if (path != "")
            {
                ConcurrentBag<string> allfiles = new ConcurrentBag<string>();
               
                    int count = new Folder(path).GetFilesCount();
                    int c = 0;
                    new Files("").FindInFiles(path,ref allfiles,progress,count,ref c);
                    List<string> li =  FindInOnlyFiles(allfiles);
                    Thread.Sleep(100);
                    new Files("Output.txt").WriteAllBag(li);

                    DialogResult result = MessageBox.Show("Open results file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        Process.Start("Output.txt");
                    }
                    ClearProgress(progress);
                }
            
            else
                MessageBox.Show("Select directory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
            
        }

        public void ClearProgress(IProgress<int> progress)
        {
            progress.Report(0);
        }

        public void button13(object sender, EventArgs e)
        {
            List<string> nameslist = new List<string>();
            string mask = view.textBox5Text;
            string path = "";
            if (view.listBox1SelectedIndex != -1)
                path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            var progress = new Progress<int>(i => view.progressBar2Value = i * view.progressBar2MaxValue / 100);
            Task.Run(() =>
            {

                for (int i = 0; i < mask.Length; i++)
                {
                    if (mask[i] == '*')
                    {
                        mask = mask.Insert(i, ".");
                        i++;
                    }
                    if (mask[i] == '?')
                    {
                        mask = mask.Remove(i);
                        mask = mask.Insert(i, ".{1}");
                        i++;
                    }
                }
                var obj = Factory.Get(ref path);
                obj.Find(ref nameslist);
                Finder(nameslist, mask, Form1.tokenF, progress);
            });
        }

        public void button14(object sender, EventArgs e)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            if (new Files("FileInfoeData1.txt").Exist())
            {
                new Files("FileInfoData1.txt").Delete();
            }


            string path = "";
            if (view.listBox1SelectedIndex != -1)
                path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());

            Dictionary<string, int> Words = new Dictionary<string, int>();
            string Word = @"[\u0410-\u044f]+";
            ulong StringCount = 0;
            ulong WordsCount = 0;
            try
            {

                string[] s = new Files(path).ReadAllLines();
                string line;
                foreach (string elem in s)
                {
                    line = elem;
                    StringCount += 1;
                    foreach (Match m in Regex.Matches(line, Word))
                    {
                        string temp = m.Value.ToLower();
                        if (Words.ContainsKey(temp))
                            Words[temp] += 1;
                        else
                            Words.Add(temp, 1);
                        WordsCount += 1;
                    }

                }


            }
            catch
            {

            }
            var Result = from w in Words.AsParallel() orderby w.Value descending select new { w.Key, w.Value }.ToString();
            List<string> finallist = new List<string>();
            Files f = new Files("FileInfoData1.txt");
            finallist.Add("StringCount: " + StringCount);
            finallist.Add("WordsCount: " + WordsCount);
            finallist.Add("10 most popular words:");
            var res = Result.Take(100);
            foreach (var elem in res)
            {
                finallist.Add(elem);
            }
            sw1.Stop();
            finallist.Add("Parallel time: {0}" + sw1.Elapsed);
            f.WriteAllList(finallist);

            DialogResult result = MessageBox.Show("Open results file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Process.Start("FileInfoData1.txt");
            }


            // то же самое но не параллельно
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            if (new Files("FileInfoeData2.txt").Exist())
            {
                new Files("FileInfoData2.txt").Delete();
            }


            string path2 = "";
            if (view.listBox1SelectedIndex != -1)
                path2 = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path2 = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());

            Dictionary<string, int> Words2 = new Dictionary<string, int>();
            string Word2 = @"[\u0410-\u044f]+";
            ulong StringCount2 = 0;
            ulong WordsCount2 = 0;
            try
            {

                string[] s = new Files(path).ReadAllLines();
                string line;
                foreach (string elem in s)
                {
                    line = elem;
                    StringCount2 += 1;
                    foreach (Match m in Regex.Matches(line, Word2))
                    {
                        string temp = m.Value.ToLower();
                        if (Words2.ContainsKey(temp))
                            Words2[temp] += 1;
                        else
                            Words2.Add(temp, 1);
                        WordsCount2 += 1;
                    }

                }


            }
            catch
            {

            }
            var Result2 = Words2.OrderBy(u => u.Value).Reverse();

            Files f2 = new Files("FileInfoData2.txt");
            List<string> finallist2 = new List<string>();
            finallist2.Add("StringCount: " + StringCount);
            finallist2.Add("WordsCount: " + WordsCount);
            finallist2.Add("10 most popular words:");
            var re = Result2.Take(30);

            foreach (var elem in re)
            {
                finallist2.Add(elem.ToString());
            }
            sw2.Stop();
            finallist2.Add("time: {0}" + sw2.Elapsed);
            f2.WriteAllList(finallist2);

            DialogResult result2 = MessageBox.Show("Open results file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Process.Start("FileInfoData2.txt");
            }


        }

        public void button2_1(object sender, EventArgs e)
        {
            InputBox.InputBox ibox = new InputBox.InputBox();
            ibox.Text = "INPUT FILE NAME";
            string filename = ibox.getString();
            var progress = new Progress<int>(i => view.progressBar3Value = i * view.progressBar3MaxValue / 100);
            string adress = view.textBox6Text;
            Task.Run(() => DownloadAsync(adress, Form1.tokenD, progress, filename));
        }

        public void button18(object sender, EventArgs e)
        {
            string path = "";
            if (view.listBox1SelectedIndex != -1)
                path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());

            var obj = Factory.Get(ref path);
            MessageBox.Show(obj.Visit()); 
        }

        public void button17(object sender, EventArgs e)
        {
            string path = "";
            InputBox.InputBox inbox = new InputBox.InputBox();
            inbox.Text = "INPUT TEXT";
            string key = inbox.getString();
            if (view.listBox1SelectedIndex != -1)
                path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            var obj = Factory.Get(ref path);
            obj.Crypt(Convert.ToInt32(key));
        }

        public void button19(object sender, EventArgs e)
        {
            string path = "";
            InputBox.InputBox inbox = new InputBox.InputBox();
            inbox.Text = "INPUT TEXT";
            string key = inbox.getString();

            if (view.listBox1SelectedIndex != -1)
                path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            else if (view.listBox2SelectedIndex != -1)
                path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            var obj = Factory.Get(ref path);
            obj.DeCrypt(Convert.ToInt32(key));
        }

        private void ListBox1DoubleClick(object sender, EventArgs e)
        {
            string p = view.textBox1Text + view.listBox1SelectedItem;
            var obj = Factory.Get(ref p);
            view.textBox1Text = p;
            List<string> finallist = obj.Open();
            if (finallist != null)
            {
                view.DisplayItems1(finallist);
            }
        }

        private void ListBox2DoubleClick(object sender, EventArgs e)
        {
            string p = view.textBox2Text + view.listBox2SelectedItem;
            var obj = Factory.Get(ref p);
            view.textBox2Text = p;
            List<string> finallist = obj.Open();
            if (finallist != null)
            {
                view.DisplayItems2(finallist);
            }
        }

        public void WriteDrives1()
        {
            view.ChangeTextBox1("Drives");
            List<string> Drives = new Folder("").GetDrives();
            view.DisplayItems1(Drives);
        }

        public void Drives1(object sender, EventArgs e)
        {
            WriteDrives1();
        }

        public void Drives2(object sender, EventArgs e)
        {
            WriteDrives2();
        }

        public void Directories1(object sender, EventArgs e)
        {
            try
            {
                string p = view.textBox1Text;
                var obj = Factory.Get(ref p);
                List<string> finallist = obj.Open();
                if (finallist != null)
                {
                    view.DisplayItems1(finallist);
                }
                else
                {
                    string path = view.textBox1Text;
                    while (path[path.Length - 1] != '\\')
                        path = path.Remove(path.Length - 1, 1);
                    view.textBox1Text = path;
                    var o = Factory.Get(ref path);
                    List<string> finalList = o.Open();
                    view.DisplayItems1(finalList);
                }
            }
            catch { view.textBox4Text = "incorrect data selected"; }
        }

        public void Directories2(object sender, EventArgs e)
        {
            try
            {
                string p = view.textBox2Text;
                var obj = Factory.Get(ref p);
                List<string> finallist = obj.Open();
                if (finallist != null)
                {
                    view.DisplayItems2(finallist);
                }
                else
                {
                    string path = view.textBox2Text;
                    while (path[path.Length - 1] != '\\')
                        path = path.Remove(path.Length - 1, 1);
                    view.textBox2Text = path;
                    var o = Factory.Get(ref path);
                    List<string> finalList = o.Open();
                    view.DisplayItems2(finalList);
                }
            }
            catch { view.textBox3Text = "incorrect data selected"; }
        }

        public void WriteDirectories1()
        {
            if (view.textBox1Text == "Drives" || view.textBox1Text == "drives" || view.textBox1Text == "Home" || view.textBox1Text == "home")
                WriteDrives1();
            else
            {
                if (!(new Files(view.textBox1Text).Exist()) && (new Folder(view.textBox1Text).Exist()))
                {
                    try
                    {
                        Folder dir = new Folder(view.textBox1Text);
                        List<string> Dirs = dir.WriteDirs();
                        List<string> files = dir.WriteFiles();
                        foreach (string elem in files)
                        {
                            Dirs.Add(elem);
                        }
                        view.DisplayItems1(Dirs);
                    }
                    catch (Exception ex)
                    {
                        view.ChangeTextBox1("introduced a non-existent directory");
                    }
                }
            }
        }

        public void WriteDirectories2()
        {
            if (view.textBox2Text == "Drives" || view.textBox2Text == "drives" || view.textBox2Text == "Home" || view.textBox2Text == "home")
                WriteDrives2();
            else
            {
                if (!(new Files(view.textBox2Text).Exist()) && (new Folder(view.textBox2Text).Exist()))
                {
                    try
                    {
                        Folder dir = new Folder(view.textBox2Text);
                        List<string> Dirs = dir.WriteDirs();
                        List<string> files = dir.WriteFiles();
                        foreach (string elem in files)
                            Dirs.Add(elem);
                        view.DisplayItems2(Dirs);
                    }
                    catch (Exception ex)
                    {
                        view.ChangeTextBox2("introduced a non-existent directory");
                    }
                }
            }
        }

        public void WriteDrives2()
        {
            view.ChangeTextBox2("Drives");
            List<string> Drives = new Folder("").GetDrives();
            view.DisplayItems2(Drives);
        }

        public void Delete1()
        {
            string path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            var obj = Factory.Get(ref path);
            obj.Delete();
            Refresh();
        }

        public void Delete2()
        {
            string path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            var obj = Factory.Get(ref path);
            obj.Delete();
            Refresh();

        }

        public void Refresh()
        {
            string path;
            try
            {
                path = view.textBox1Text;
                var o1 = Factory.Get(ref path);
                List<string> finallist1 = o1.Open();
                view.DisplayItems1(finallist1);
            }
            catch { }
            try
            {
                path = view.textBox2Text;
                var o2 = Factory.Get(ref path);
                List<string> finallist2 = o2.Open();
                view.DisplayItems2(finallist2);
            }
            catch { }
        }

        public void Copy1()
        {
            string newpath = "";
            string path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            newpath = view.textBox2Text;
            var Oldobj = Factory.Get(ref path);
            Oldobj.Copy();
            var Newobj = Factory.Get(ref newpath);
            Newobj.Insert();
            Refresh();


        }

        public void Copy2()
        {
            string newpath = "";
            string path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            newpath = view.textBox1Text;
            var Oldobj = Factory.Get(ref path);
            Oldobj.Copy();
            var Newobj = Factory.Get(ref newpath);
            Newobj.Insert();
            Refresh();
        }

        public void Move1()
        {
            string path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            Copy1();
            var obj = Factory.Get(ref path);
            obj.Delete();
            Refresh();
        }

        public void Move2()
        {
            string path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            Copy2();
            var obj = Factory.Get(ref path);
            obj.Delete();
            Refresh();
        }

        public void WriteFileInfo1()
        {
            string path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            var obj = Factory.Get(ref path);
            view.textBox4Text = "File name:" + obj.GetName() + "     Time of creation" + obj.CreationTime() + "      Size" + obj.Length();
        }

        public void WriteFileInfo2()
        {
            string path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            var obj = Factory.Get(ref path);
            view.textBox3Text = "File name:" + obj.GetName() + "     Time of creation" + obj.CreationTime() + "      Size" + obj.Length();
        }

        public void Rename1()
        {
            string path = new Files("").Combine(view.textBox1Text, view.listBox1SelectedItem.ToString());
            string extention = new Files(path).GetExtension();
            InputBox.InputBox inputBox = new InputBox.InputBox();
            string newpath = inputBox.getString();
            newpath = newpath.Replace("\\", "");
            newpath = "\\" + newpath + extention;
            string n = view.textBox1Text + newpath;
            if (new Files(path).GetExtension() == "")
            {
                try
                {
                    new Folder(path).Moving(new Files("").Combine(view.textBox1Text, inputBox.getString()));
                }
                catch { }
            }

            else
            {
                try
                {
                    if (new Files(path).Exist())
                    {
                        new Files(path).Moving(n);
                    }
                }
                catch { }
            }
            WriteDirectories1();
            WriteDirectories2();
        }

        public void Rename2()
        {
            string path = new Files("").Combine(view.textBox2Text, view.listBox2SelectedItem.ToString());
            string extention = new Files(path).GetExtension();
            InputBox.InputBox inputBox = new InputBox.InputBox();
            string newpath = inputBox.getString();
            newpath = newpath.Replace("\\", "");
            newpath = "\\" + newpath + extention;
            string n = view.textBox2Text + newpath;
            if (new Files(path).GetExtension() == "")
            {
                try
                {
                    new Folder(path).Moving(new Files("").Combine(view.textBox2Text, inputBox.getString()));
                }
                catch { }
            }

            else
            {
                try
                {
                    if (new Files(path).Exist())
                    {
                        new Files(path).Moving(n);
                    }
                }
                catch { }
            }
            WriteDirectories1();
            WriteDirectories2();
        }

        public void Compress1()
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
               string newpath =  new ZippedFolder(view.textBox2Text + (new Files(view.listBox1SelectedItem).GetNameWithoutExtention())).CreateArchive();
                view.textBox2Text = newpath;
                Copy1();
                Back2(null,EventArgs.Empty);
                Refresh();
          
        }

        public void Compress2()
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
            string newpath = new ZippedFolder(view.textBox1Text + (new Files(view.listBox2SelectedItem).GetNameWithoutExtention())).CreateArchive();
            view.textBox1Text = newpath;
            Copy2();
            Back1(null, EventArgs.Empty);
            Refresh();

        }

        public void button22(object sender, EventArgs e)
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
            new Files("ExtractData\\" + view.textBox7Text).Create();
            string path = view.textBox1Text;
            var obj = Factory.Get(ref path);
            obj.Insert();
            Refresh();
            if (view.textBox7Text.Contains("NewFile"))
            {
                if (new Files(view.textBox7Text).GetNameWithoutExtention() == "NewFile")
                    view.textBox7Text = "NewFile1" + new Files(view.textBox7Text).GetExtention();
                else
                {
                    try
                    {
                        string s = new Files(view.textBox7Text).GetNameWithoutExtention()[new Files(view.textBox7Text).GetNameWithoutExtention().Length - 1].ToString();
                        int i = Convert.ToInt32(s)+1;
                        string str = new Files(view.textBox7Text).GetNameWithoutExtention();
                        view.textBox7Text = str.Remove(str.Length - 1, 1) + i + new Files(view.textBox7Text).GetExtention();
                    }
                    catch { }
                }
            }
                
        }

        public void button23(object sender, EventArgs e)
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
            new Folder("ExtractData\\" + view.textBox8Text).Create();
            string path = view.textBox1Text;
            var obj = Factory.Get(ref path);
            obj.Insert();
            Refresh();
            if (view.textBox8Text.Contains("NewFolder"))
            {
                if (view.textBox8Text == "NewFolder")
                    view.textBox8Text = "NewFolder1";
                else
                {
                    try
                    {
                        string s = view.textBox8Text[view.textBox8Text.Length - 1].ToString();
                        int i = Convert.ToInt32(s) + 1;
                        view.textBox8Text = view.textBox8Text.Remove(view.textBox8Text.Length - 1, 1) + i;
                    }
                    catch { }
                }
            }
        }

        public void button24(object sender, EventArgs e)
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
            new Files("ExtractData\\" + view.textBox9Text).Create();
            string path = view.textBox2Text;
            var obj = Factory.Get(ref path);
            obj.Insert();
            Refresh();
            if (view.textBox9Text.Contains("NewFile"))
            {
                if (new Files(view.textBox9Text).GetNameWithoutExtention() == "NewFile")
                    view.textBox9Text = "NewFile1" + new Files(view.textBox9Text).GetExtention();
                else
                {
                    try
                    {
                        string s = new Files(view.textBox9Text).GetNameWithoutExtention()[new Files(view.textBox9Text).GetNameWithoutExtention().Length - 1].ToString();
                        int i = Convert.ToInt32(s) + 1;
                        string str = new Files(view.textBox9Text).GetNameWithoutExtention();
                        view.textBox9Text = str.Remove(str.Length - 1, 1) + i + new Files(view.textBox9Text).GetExtention();
                    }
                    catch { }
                }
            }
        }

        public void button25(object sender, EventArgs e)
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
            new Folder("ExtractData\\" + view.textBox10Text).Create();
            string path = view.textBox2Text;
            var obj = Factory.Get(ref path);
            obj.Insert();
            Refresh();
            if (view.textBox10Text.Contains("NewFolder"))
            {
                if (view.textBox10Text == "NewFolder")
                    view.textBox10Text = "NewFolder1";
                else
                {
                    try
                    {
                        string s = view.textBox10Text[view.textBox10Text.Length - 1].ToString();
                        int i = Convert.ToInt32(s) + 1;
                        view.textBox10Text = view.textBox10Text.Remove(view.textBox10Text.Length - 1, 1) + i;
                    }
                    catch { }
                }
            }
        }

        public void Finder(List<string> nameslist ,string mask, CancellationToken tokenF, IProgress<int> progress)
        {
           
                List<string> finalList = new List<string>();
                int count = nameslist.Count;
                int c = 0;
                foreach (string elem in nameslist)
                {
                    if (tokenF.IsCancellationRequested == true)
                    {
                        progress.Report(0);
                        break;
                    }
                    string[] names = elem.Split(new char[] { '\\' });
                    foreach (string e in names)
                    {
                        if (e == Regex.Match(e, mask).Value && e != "")
                        {
                            finalList.Add(elem);
                        }
                    }

                    c++;
                    progress.Report((int)Math.Floor((double)c * 100 / count));
                    Thread.Sleep(20);  //ЭТО ДЛЯ НАГЛЯДНОСТИ ПРОГРЕССБАРА2. НА САМОМ ДЕЛЕ ЭТУ СТРОКУ НАДО УДАЛИТЬ
                }

                try
                {
                    new Files("OutputMaskFiles.txt").Delete();
                }
                catch { }
                new Files("OutputMaskFiles.txt").WriteAllList(finalList.Distinct().ToList());
                progress.Report(0);
                Process.Start("OutputMaskFiles.txt");
           
        }

        public static List<string> FindInOnlyFiles(ConcurrentBag<string> allfiles)
        {
            List<string> li = new List<string>();
            string Passport1 = @"\d{4}-\d{6}|\d{4}\s\d{6}";
            string Telephone = @"(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?";
            string VK = @"(https?:\/\/)?(www\.)?vk\.com\/(\w|\d)+?\/?";
            string HTTP = @"https?://([a-z1-9]+.)?[a-z1-9\-]+(\.[a-z]+){1,}/?";
            string EMAIL = @"[a-zA-Z1-9\-\._]+@[a-z1-9]+(.[a-z1-9]+){1,}";            
            if (allfiles != null)
            {
                                    foreach(string s in allfiles)
                                    {
                                        foreach (Match m in Regex.Matches(s, Passport1))
                                        {
                                            if ((!m.Value.Equals("0000-000000")) && (!m.Value.Equals("0000 000000")))
                                                li.Add(m.Value + " Номер пасспорта");
                                        }

                                        foreach (Match m in Regex.Matches(s, Telephone))
                                        {
                                            li.Add(m.Value + " Номер телефона");
                                        }

                                        foreach (Match m in Regex.Matches(s, VK))
                                        {
                                            li.Add(m.Value + " Страница ВК");
                                        }

                                        foreach (Match m in Regex.Matches(s, HTTP))
                                        {
                                            li.Add(m.Value + " Сайт");
                                        }

                                        foreach (Match m in Regex.Matches(s, EMAIL))
                                        {
                                            li.Add(m.Value + " е-маил");
                                        }

                                    }
            }
            return li;

        }
                
        public static async void DownloadAsync(string adress, CancellationToken tokenD, IProgress<int> progress, string filename)
        {
            try
            {
                int c = 0;
                WebRequest request = WebRequest.Create(adress);
                request.Method = WebRequestMethods.File.DownloadFile;
                WebResponse response = await request.GetResponseAsync();

                Files fs = new Files(@"C:\Downloads//" + filename);


                byte[] buffer = new byte[1024];
                int size = 0;
                long responsize = response.ContentLength;
                while ((size = await new Files("").ReadAsync(buffer, 0, buffer.Length, response)) > 0)
                {
                    progress.Report((int)Math.Floor((double)c * 100 / (responsize)));
                    if (tokenD.IsCancellationRequested == true)
                    {
                        progress.Report(0);
                        break;

                    }
                    c += size;
                    fs.FileStraemWrite(buffer, 0, size);
                }
 
                progress.Report(0);
                if (tokenD.IsCancellationRequested == true)
                {
                    new Files(@"C:\Downloads//" + filename).Delete();
                }
            }
            catch { }
        }       
    }
 }

