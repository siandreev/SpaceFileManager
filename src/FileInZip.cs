using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace Version1
{
    class FileInZip : Entry // файл В архиве
    {
        //int ZipPlace;
        string way; //путь к архиву 
        string ArchiveWay; // путь в архиве
        public FileInZip(string path) : base(path)
        {
             int ZipPlace = path.IndexOf(".zip\\");
             way = path.Substring(0, ZipPlace + 4);
             ArchiveWay = path.Substring(ZipPlace + 5);
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

        public override string GetFullName(string name)
        {
            ///string AWay = path.Substring(ZipPlace + 5);
            return ArchiveWay;
            //throw new NotImplementedException();
        }

        public override string GetName()
        {
            int i;
            while (ArchiveWay.Contains('\\'))
            {
                i = ArchiveWay.IndexOf('\\');
                ArchiveWay = ArchiveWay.Substring(i + 1);
            }
            return ArchiveWay;
          //  throw new NotImplementedException();
        }

        public override List<string>  Open()
        {
            using (ZipFile zip = ZipFile.Read(way))
            {
                while (way[way.Length - 1] != '\\')
                {
                    way = way.Remove(way.Length - 1, 1);
                } 
                foreach (ZipEntry e in zip)
                {
                    if (e.FileName == ArchiveWay.Replace('\\', '/'))
                        e.Extract(way, ExtractExistingFileAction.DoNotOverwrite);
                }

            }
            Process.Start(way + GetFullName(""));
            return null;
        }

        public override void Copy()
        {
            try
            {
                new Folder("ExtractData").Delete();
            }
            catch { }
            new Folder("ExtractData").Create();
            try
            {
                new Folder("ExtractData2").Delete();
            }
            catch { }
            new Folder("ExtractData2").Create();
            using (ZipFile zip = ZipFile.Read(way))
            {

                foreach (ZipEntry e in zip)
                {
                    if (e.FileName == ArchiveWay.Replace('\\', '/'))
                        e.Extract("ExtractData2", ExtractExistingFileAction.DoNotOverwrite);
                }
            }
            new Files("ExtractData2\\" + ArchiveWay).Copy();
            new Folder("ExtractData2").Delete();

        }


        public override void Delete()
        {
            int SleshCount = (ArchiveWay.Length - ArchiveWay.Replace("\\", "").Length) + 1;
            using (ZipFile zip = ZipFile.Read(way))
            {               
                ArchiveWay = ArchiveWay.Replace('\\', '/');
                zip.RemoveEntry(ArchiveWay);
                zip.Save();
            }
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
                // throw new NotImplementedException();
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
            // throw new NotImplementedException();
        }

        public override string Visit()
        {
            throw new NotImplementedException();
        }
    }
}
