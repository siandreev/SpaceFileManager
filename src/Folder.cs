using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class Folder : Entry
    {
        public Folder(string path) : base(path)
        {

        }

        public override List<string> Open()
        {
            
            List<string> Dirs = WriteDirs();
            List<string> files = WriteFiles();
            foreach (string elem in files)
            {
                Dirs.Add(elem);
            }
            return Dirs;
            //throw new NotImplementedException();
        }

        public DirectoryInfo FolderWork()
        {
            var folder = new DirectoryInfo(path);
            return folder;
        }

        public IEnumerator<DirectoryInfo> Getcollect()
        {
            DirectoryInfo di = new DirectoryInfo(path);

            IEnumerable<DirectoryInfo> dirinfo = di.EnumerateDirectories("*", SearchOption.TopDirectoryOnly);
            var enumr = dirinfo.GetEnumerator();
            return enumr;
        }
        public string[] GetDirectories(DirectoryInfo dir)
        {
            DirectoryInfo[] dirs = dir.GetDirectories();
            string[] dirs1 = new string[200];
            for (int i = 0; i < dirs.Length; i++)
            {
                dirs1[i] = dirs[i].ToString();
            }
            return dirs1;
        }
        public string[] GetAllFiles(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();
            string[] file1 = new string[200];
            for (int i = 0; i < files.Length; i++)
            {
                file1[i] = files[i].ToString();
            }
            return file1;
        }
        public string[] GetFiles()
        {
            string[] files = Directory.GetFiles(path);
            return files;
        }
        public string[] GetAllDirectories()
        {
            string[] files = Directory.GetDirectories(path);
            return files;
        }

       
        public override bool Exist()
        {
            if (Directory.Exists(path) == true)
            { return true; }
            else { return false; }
        }
        public DirectoryInfo Create()
        {
            var dir = Directory.CreateDirectory(path);
            return dir;
        }
        public override void Delete()
        {
            Directory.Delete(path, true);
        }

        public override string GetFullName(string name)
        {
            var dir = new DirectoryInfo(path);
            string fullname = dir.FullName;
            return fullname;
        }

        public string GetFullNam(string name)
        {
            string fullname = Path.GetFullPath(name);
            return fullname;
        }

        public override string GetName()
        {
            var dir = new DirectoryInfo(path);
            string name = dir.Name;
            return name;
        }
        public string CurrentDirectory()
        {
            string pass = Directory.GetCurrentDirectory();
            return pass;
        }
        public void Zip(string newpath)
        {
            ZipFile.CreateFromDirectory(path, newpath);
        }

        public List<string> GetDrives()
        {
            DriveInfo[] Drives = DriveInfo.GetDrives();
            List<string> files = new List<string>();
            foreach (DriveInfo d in Drives)
            {
                files.Add(d.ToString());
            }
            return files;
        }
        public override void Copy()
        {
            try
            {
                Directory.Delete("ExtractData",true);
            }
            catch { }
            Directory.CreateDirectory("ExtractData");
            CopyDir(path, "ExtractData\\" + new Folder(path).GetName());
        }

        public override void Insert()
        {
            foreach (string felem in Directory.GetFiles("ExtractData"))
                File.Copy("ExtractData\\" + new Files(felem).GetName(), path + "\\"+new Files(felem).GetName());
            foreach (string delem in Directory.GetDirectories("ExtractData"))
                CopyDir(delem, path + "\\" + new Folder(delem).GetName());
            try { Directory.Delete("ExtractData"); }
            catch { }
        }

    

        public  void CopyDir(string path, string newpath)
        {             
                Directory.CreateDirectory(newpath);
                foreach (string s1 in Directory.GetFiles(path))
                {
                    string s2 = newpath + "\\" + Path.GetFileName(s1);
                    File.Copy(s1, s2);
                }
                foreach (string s in Directory.GetDirectories(path))
                {
                    CopyDir(s, newpath + "\\" + Path.GetFileName(s));
                }           
        }

        public void Moving(string newpath)
        {
            Directory.Move(path, newpath);
        }

        public override string CreationTime()
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            return dir.CreationTime.ToString();
        }

        public override double Length()
        {
            double size = 0;
            GetFolderLength(path, ref size);
            //throw new NotImplementedException();
            return size;
        }

        public void GetFolderLength(string path, ref double size)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (FileInfo elem in files)
            {
                size += elem.Length;
            }
            foreach (DirectoryInfo elem in dirs)
            {
                GetFolderLength(elem.FullName,ref size);
            }
        }

        public List<string> WriteDirs()
        {
            
            List<string> l = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (var elem in dirs)
            {
                l.Add(elem.Name);
            }
            return (l);
        }

        public List<string> WriteFiles()
        {
            List<string> l = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            foreach (var elem in files)
            {
                l.Add(elem.Name);
            }
            return (l);
        }

        public override void Find(ref List<string> nameslist)
        {
            DirectoryInfo MainDir = new DirectoryInfo(path);
            GetNamesList(MainDir,ref nameslist);
        }
        public void GetNamesList(DirectoryInfo dir, ref List<string> nameslist)
        {
            string p;
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo elem in files)
            {
                p = elem.FullName;
                var obj = Factory.Get(ref p);
                obj.Find(ref nameslist);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo elem in dirs)
            {
                nameslist.Add(elem.FullName);
                GetNamesList(elem, ref nameslist);
            }
        }

        public int GetFilesCount()
        {
            int count = new DirectoryInfo(path).GetFiles().Length;
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs =  dir.GetDirectories(); 
            foreach (DirectoryInfo elem in dirs)
            {
                count += new Folder(elem.FullName).GetFilesCount();
            }
            return count;
        }

        public override void Crypt(int code)
        {
            Folder folder = new Folder(path);
            var dirs = folder.GetAllDirectories();

            foreach (var dir in dirs)
            {
                new Folder(dir).Crypt(code);
            }
            foreach (string files in folder.GetFiles())
            {
                new Files(files).Crypt(code);
            }
        }

        public override void DeCrypt(int code)
        {
            Folder folder = new Folder(path);
            var dirs = folder.GetAllDirectories();
            foreach (string dir in dirs)
            {
                new Folder(dir).DeCrypt(code);
            }
            foreach (string files in folder.GetFiles())
            {
                var file = new Files(files);
                new Files(files).DeCrypt(code);
            }

        }

        public override string Visit()
        {
            var dirs = new Folder(path).GetAllDirectories();
            string sub = "";
            foreach (string d in dirs)
            {
               new Folder(d).Visit();
            }
            foreach (string f in new Folder(path).GetFiles())
            {
                sub += new Files(f).Visit();
            }
            return sub;
        }
    }

}
