using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public abstract class FileSystemObject {
        private string _fullPath;
        private string _parent;

        public FileSystemObject(string fullPath, string parent) {
            _fullPath = fullPath;
            _parent = parent;
        }
        public string GetPath() {
            return _fullPath;
        }
        /*virtual public string GetParent() {
            return _parent;
        }*/

        //public abstract void copyTo();
        //public abstract void delete();

        public abstract string GetName();
        public abstract new string GetType();
        public abstract string GetSize();
    }
}
