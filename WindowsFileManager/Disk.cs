using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public class Disk : Container {
        public Disk(string fullPath, string parent) : base(fullPath, parent) {

        }

        public override string GetSize() {
            return "<Диск>";
        }
    }
}
