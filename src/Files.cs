using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Threading;
using System.Collections.Concurrent;
using System.Net;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Version1
{
    class Files : Entry
    {
        public Files(string path) : base(path)
        {

        }
        public override bool Exist()
        {
            if (File.Exists(path) == true)
            { return true; }
            else { return false; }
        }

        public override List<string> Open()
        {
            Process.Start(path);
            return null;
           // throw new NotImplementedException();
        }
        public void Create()
        {
            var file = File.Create(path);
            file.Close();
            
        }
        public override void Copy()
        {
            try
            {
                Directory.Delete("ExtractData", true);
            }
            catch { }
            Directory.CreateDirectory("ExtractData");
            string name = new Files(path).GetName();
            File.Copy(path, "ExtractData\\" +name);
        }


        public string GetExtention()
        {
            return Path.GetExtension(path);
        }

        public string GetNameWithoutExtention()
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        public override string CreationTime()
        {
            FileInfo fileinfo = new FileInfo(path);
            return fileinfo.CreationTime.ToString();
          
        }


        public override void Delete()
        {
            File.Delete(path);
        }
        public override string GetName()
        {
            string name = Path.GetFileName(path);
            return name;
        }
        public override string GetFullName(string name)
        {
            string fullname = Path.GetFullPath(name);

            return name;
        }

        public string GetFullNam(string name)
        {
            string fullname = Path.GetFullPath(name);

            return fullname;
        }

        public void AppendText(string contain, Encoding encoding)
        {
            File.AppendAllText(path, contain, encoding);
        }

        public void WriteText(string contain, Encoding encoding)
        {
            File.WriteAllText(path, contain, encoding);
        }
        public void WriteText(string contain)
        {
            File.WriteAllText(path, contain);
        }

        public void Zip(string newpath)
        {
            ZipFile.CreateFromDirectory(path, newpath);
        }

        public void Moving(string newpath)
        {
            File.Move(path, newpath);
        }
        public string ReadText()
        {
            var text = File.ReadAllText(path, Encoding.GetEncoding(1251));
            return text;
        }

        public override double Length()
        {
            FileInfo file = new FileInfo(path);
            return file.Length;
        }

       

        public override void Find(ref List<string> nameslist)
        {
            nameslist.Add(path);
        }

        public void FileStraemWrite(byte[] b, int i, int j)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            fs.Write(b, i, j);
            fs.Close();
        }


        public void FindInFiles(string directory, ref ConcurrentBag<string> s,IProgress<int> progress,int count,ref int currentcount)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            FileInfo[] files = dir.GetFiles();
                foreach (FileInfo elem in files)
                {
                    currentcount++;
                    progress.Report((int)Math.Floor((double)currentcount * 100 / count));
                    string[] array = new Files(elem.FullName).ReadAllLines();
                    foreach (string e in array)
                       s.Add(e);                 
                }
                var Dirs = dir.GetDirectories();
                foreach (DirectoryInfo elem in Dirs)
                {

                FindInFiles(elem.FullName.ToString(), ref s,progress,count,ref currentcount);
                }
            

        }

        public string[] ReadAllLines()
        {
            return File.ReadAllLines(path,Encoding.Default);
        }

        public void WriteAllLines(string[] s)
        {
            File.WriteAllLines(path, s);
        }

        public void WriteAllBag(List<string> bag)
        {
            int count = bag.Count;
            string[] s = new string[count];
            int i = 0;
            foreach (string elem in bag)
            {
                s[i] = elem;
                i++;
            }
            File.WriteAllLines(path, s);
        }

        public void WriteAllList(List<string> list)
        {
            int count = list.Count;
            string[] s = new string[count];
            int i = 0;
            foreach (string elem in list)
            {
                s[i] = elem;
                i++;
            }
            File.WriteAllLines(path, s);
        }

        public void CreateFromDirectory(string newpath)
        {
            ZipFile.CreateFromDirectory(path, newpath);
        }

        public async Task<int> ReadAsync(byte[] b, int i, int j, WebResponse response)
        {
            Stream responsesStream = response.GetResponseStream();
            return await responsesStream.ReadAsync(b, i, j);
        }


        public override void Crypt(int code)
        {
            Files file = new Files(path);
            string text = file.ReadText();
            byte[] bytes = Encoding.GetEncoding(1251).GetBytes(text);
            string array = Encrypt(bytes, code);
            file.WriteText(array, Encoding.GetEncoding(1251));
        }

        public override void DeCrypt(int code)
        {
            Files file = new Files(path);
            var text = file.ReadText();
            file.WriteText(Decrypt(text, code), Encoding.Default);
        }

        public string Encrypt(byte[] bytes, int key)
        {

            byte[] bytesCrypt = new byte[bytes.Length];
            for (int i = 0; i < bytesCrypt.Length; i++)
            {
                bytesCrypt[i] = (byte)(bytes[i] ^ key);
            }

            return Encoding.Default.GetString(bytesCrypt);
        }

        public string Decrypt(string oldtext, int key)
        {
            byte[] bytes = Encoding.Default.GetBytes(oldtext);
            return Encrypt(bytes, key);
        }

        public override string Visit()
        {
            var file = new Files(path).FileStreamCreate();

            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] val = md5.ComputeHash(file);

            file.Close();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < val.Length; i++)

            {
                sb.Append(val[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
