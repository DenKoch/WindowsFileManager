using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public class Disk : Container {
        public Disk(string fullPath) : base(fullPath) {

        }

        public override string GetSize() {
            return "<Диск>";
        }
    }
}
