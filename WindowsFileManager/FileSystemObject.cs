using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public abstract class FileSystemObject {
        private string _fullPath;

        public FileSystemObject(string fullPath) {
            _fullPath = fullPath;
        }
        public virtual string GetPath() {
            return _fullPath;
        }

        public abstract string GetName();
        public abstract new string GetType();
        public abstract string GetSize();
    }
}
