using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;


namespace Version1
{
    class ZippedFile : Files //файл-архив
    {
      

        public ZippedFile(string path) : base (path)
        {
        }

        public override List<string> Open() //возвращает список имен всех файлов и папок на первом уровне архива
        {
            using (ZipFile zip = ZipFile.Read(path))
            {
                List<string> fulList = zip.EntryFileNames.ToList();
                List<string> shortList = new List<string>();
                int i = 0;
                foreach (string elem in fulList)
                {
                    i = elem.IndexOf("/");
                    if (i != -1)
                        shortList.Add(elem.Substring(0, i) + "/");
                    else
                        shortList.Add(elem);
                }
                return shortList.Distinct().ToList();
            }
        }

        public override void Insert()
        {
            using (ZipFile newzip = ZipFile.Read(path))
            {
                foreach (string felem in new Folder("ExtractData").GetFiles())
                {
                    newzip.AddItem(new Files("").GetFullNam(felem),"");
                }
                foreach (string delem in new Folder("ExtractData").GetAllDirectories())
                {
                    newzip.AddDirectory(new Folder("").GetFullNam(delem) + "\\","");
                }
                newzip.Save();
                try { new Folder("ExtractData").Delete(); }
                catch { }
            }
        }

        public override void Find(ref List<string> nameslist)
        {
            List<string> zipList = new ZippedFolder(path).GetAllFilesInArchive();
                foreach (string e in zipList)
                nameslist.Add(path + "\\" + e);
        }

    }
}
