using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace Version1
{
    class ZippedFolder : Entry // папка В архиве
    {
        int ZipPlace;
        string way; //путь к архиву 
        string ArchiveWay; // путь в архиве
        int SleshCount;
        public ZippedFolder(string path) : base(path)
        {
            ZipPlace = path.IndexOf(".zip\\");
            way = path.Substring(0, ZipPlace + 4);
            ArchiveWay = path.Substring(ZipPlace + 5);
            ArchiveWay = ArchiveWay.Remove(ArchiveWay.Length - 1, 1) + "\\";
            SleshCount = (ArchiveWay.Length - ArchiveWay.Replace("\\", "").Length);
        }

        public override string CreationTime()
        {
            using (ZipFile zip = ZipFile.Read(way))
            {
                foreach (ZipEntry e in zip)
                {
                    if (e.FileName == ArchiveWay.Replace('\\', '/'))
                        return e.CreationTime.ToString();
                }
            }
            return "";
            //  throw new NotImplementedException();
        }

        public override double Length()
        {
            using (ZipFile zip = ZipFile.Read(way))
            {
                foreach (ZipEntry e in zip)
                {
                    if (e.FileName == ArchiveWay.Replace('\\', '/'))
                        return e.CompressedSize;
                }
            }
            return 0;
        }

        public override bool Exist()
        {
            using (ZipFile zip = ZipFile.Read(way))
            {
                foreach (ZipEntry e in zip)
                {
                    if (e.FileName == ArchiveWay.Replace('\\', '/'))
                        return true;
                }
            }
            return false;
        }

        public override string GetName()
        {
            ArchiveWay = ArchiveWay.Remove(ArchiveWay.Length - 1, 1);
            int i;
            while (ArchiveWay.Contains('\\'))
            {
                i = ArchiveWay.IndexOf('\\');
                ArchiveWay = ArchiveWay.Substring(i + 1);
            }
            return ArchiveWay + "/";
            // throw new NotImplementedException();
        }

        public override string GetFullName(string name)
        {
            return ArchiveWay;
            // throw new NotImplementedException();
        }

        public override List<string> Open()
        {
            using (ZipFile zip = ZipFile.Read(way))
            {
                string name = ArchiveWay.Replace('\\', '/');
                List<string> fulList = zip.EntryFileNames.ToList();
                string[] shortList = new string[fulList.Count];
                string[] newList = new string[fulList.Count];
                List<string> finalList = new List<string>();


                shortList = fulList.ToArray();
                int k = 0;
                for (int i = 0; i < fulList.Count; i++)
                {
                    if (shortList[i].Contains(name) && shortList[i].IndexOf(name) == 0)
                    {
                        newList[k] = shortList[i];
                        k++;
                    }

                }
                k = 0;
                int count = 0;
                while (k < newList.Length && newList[k] != null)
                {
                    count++;
                    k++;
                }


                string[] s = new string[count];
                k = 0;
                while (k < newList.Length && newList[k] != null)
                {
                    s[k] = newList[k];
                    k++;
                }

                for (int i = 1; i <= SleshCount; i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        k = s[j].IndexOf("/");
                        s[j] = s[j].Substring(k + 1);
                    }
                }

                foreach (string elem in s)
                {
                    k = elem.IndexOf("/");
                    if (k != -1)
                        if (elem.Substring(0, k) != "")
                            finalList.Add(elem.Substring(0, k) + "/");
                        else { }
                    else
                       if (elem != "")
                        finalList.Add(elem);
                }
                return finalList.Distinct().ToList();
            }
        }

        public override void Delete()
        {
            using (ZipFile zip = ZipFile.Read(way))
            {
                string AWay = (ArchiveWay.Remove(ArchiveWay.Length - 1, 1) + "\\").Replace('\\', '/');
                List<string> fullList = GetDeleteList(AWay, way);
                foreach (string elem in fullList)
                {
                    zip.RemoveEntry(elem);
                }
                zip.Save();
            }
        }

        public List<string> GetDeleteList(string AWay, string Path)
        {
            using (ZipFile zip = ZipFile.Read(Path))
            {
                List<string> list = zip.EntryFileNames.ToList();
                List<string> finalList = new List<string>();
                foreach(string elem in list)
                {
                    if (elem.Contains(AWay) && elem.IndexOf(AWay)==0)
                    {
                        finalList.Add(elem);
                    }
                }
                return finalList;
            }
        }

       

        public override void Copy()
        {
            try
            {
                new Folder("ExtractData2").Delete();
            }
            catch { }
            new Folder("ExtractData2").Create();
            ArchiveWay = ArchiveWay.Remove(ArchiveWay.Length - 1, 1) + "\\";
            using (ZipFile zip = ZipFile.Read(way))
            {
                foreach (ZipEntry e in zip)
                {
                    if (e.FileName.Contains(ArchiveWay.Replace('\\', '/')) && e.FileName.IndexOf(ArchiveWay.Replace('\\', '/')) == 0)
                    {
                        e.Extract("ExtractData2", ExtractExistingFileAction.DoNotOverwrite);
                    }
                }
            }

            new Folder("ExtractData2\\" + ArchiveWay.Remove(ArchiveWay.Length-1,1)).Copy();
            new Folder("ExtractData2").Delete();

        }

        public override void Insert()
        {
            using (ZipFile newzip = ZipFile.Read(way))
            {
                string name;
                string fullname;
                foreach (string felem in new Folder("ExtractData").GetFiles())
                {
                    newzip.AddItem(new Files("").GetFullNam(felem), ArchiveWay.Replace('\\', '/'));
                }
                foreach (string delem in new Folder("ExtractData").GetAllDirectories())
                {
                    fullname=new Folder("").GetFullNam(delem);
                    name = new Folder(fullname).GetName();
                    newzip.AddDirectory(fullname + "\\", ArchiveWay.Replace('\\', '/')  + name);
                }
                    
                newzip.Save();
                try { new Folder("ExtractData").Delete(); }
                catch { }                
               
            }
        }




        public override string Visit()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllFilesInArchive()
        {
            using (ZipFile zip = ZipFile.Read(path))
            {
                List<string> newlist = new List<string>(); 
                List<string> fulList = zip.EntryFileNames.ToList();
                foreach (string elem in fulList)
                {
                    newlist.Add(elem.Replace('/', '\\'));
                }
                return newlist.Distinct().ToList();
            }
        }

        public string CreateArchive()
        {
            path = path + ".zip";
            using (ZipFile zip = new ZipFile())
            {
                zip.Save(path);
            }
            return path;
        }
    }
}
