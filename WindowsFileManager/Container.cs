using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public class Container : FileSystemObject {
        public Container(string fullPath) : base(fullPath) {
        }

        public override string GetName() {
            throw new NotImplementedException();
        }
        public override string GetType() {
            throw new NotImplementedException();
        }
        public override string GetSize() {
            throw new NotImplementedException();
        }

        virtual public FileSystemObject[] GetChildren() {
            FileSystemObject[] children = new FileSystemObject[1];
            return children;
        }
    }
}
