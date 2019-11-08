using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
        abstract class Entry
        {
            protected string path;

            public Entry(string path)
            {
                this.path = path;
            }
            public string GetExtension()
            {
                string ext = Path.GetExtension(path);
                return ext;
            }
            public string Combine(string path1, string path2)
            {
                string pathFinal = Path.Combine(path1, path2);
                return pathFinal;
            }
            public FileStream FileStreamCreate()
            {
                FileStream file = new FileStream(path, FileMode.Open);
                return file;
            }
            public abstract bool Exist();
            public abstract string GetFullName(string name);
            public abstract string GetName();
            public abstract List<string> Open();
            public abstract void Copy();
            public virtual void Insert() { }
            public virtual void Find(ref List<string> nameslist) { }
            public abstract void Delete();
            public abstract string CreationTime();
            public abstract double Length();
            public virtual void Crypt(int code) { }
            public virtual void DeCrypt(int code) { }
            public abstract string Visit();
    }
}
