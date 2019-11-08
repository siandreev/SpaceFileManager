using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class Factory 
    {
        public static Entry Get(ref string path)
        {
            if (path.Contains(".zip\\") && path.IndexOf(".zip\\")== path.Length-5)
                path = path.Remove(path.Length - 1, 1);
            if (path.Contains(".zip") && !path.Contains(".zip\\") && new Files(path).Exist() && !new Folder(path).Exist())
            {
                path = path + "\\";
                return new ZippedFile(path.Remove(path.Length - 1, 1));
            }
            if (path.Contains(".zip\\") && !(path[path.Length - 1] == '/' || (path[path.Length - 1] == '\\')))
            {
                string newpath = path;
                while (path[path.Length - 1] != '\\')
                {
                    path = path.Remove(path.Length - 1, 1);
                }
                return new FileInZip(newpath);
            }
            if (path.Contains(".zip\\") && (path[path.Length - 1] == '/' || (path[path.Length - 1] == '\\')))
            {
                string newpath = path;
                path = path.Remove(path.Length - 1, 1) + "\\";
                return new ZippedFolder(newpath);
            }
            if (path.Contains("Drives") && path.IndexOf("Drives") == 0)
            {
                path = path.Substring(6);
                return new Folder(path);
            }
            if (path.Length == 3)
            {
                return new Folder(path);
            }
            if (!path.Contains(".zip\\") && path[path.Length-1]=='\\')
                path = path.Remove(path.Length - 1, 1);
            if (new Files(path).Exist() && !new Folder(path).Exist())
            {
                string newpath = path;
                while (path[path.Length - 1] != '\\')
                {
                    path = path.Remove(path.Length - 1, 1);
                }
                return new Files(newpath);
            }
           
            path = path + "\\";
            return new Folder(path.Remove(path.Length - 1, 1));
        }
    }
}
