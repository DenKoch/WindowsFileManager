using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFileManager {
    public class MyComputer : Container {
        public MyComputer(string fullPath, string parent) : base(fullPath, parent) {
        }

        public Disk[] GetDisks() {
            string[] diskPaths = Environment.GetLogicalDrives();
            Disk[] disks = new Disk[diskPaths.Length];
            for (int i = 0; i < diskPaths.Length; i++) {
                disks[i] = new Disk(diskPaths[i], "");
            }
            return disks;
        }

        public override FileSystemObject[] GetChildren() {
            return GetDisks();
        }

    }
}
