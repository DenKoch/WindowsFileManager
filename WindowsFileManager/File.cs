using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileManager {
    public class File : FileSystemObject {
        private string _name;
        private string _type;
        private long _size;

        public File(string fullPath) : base(fullPath) {
            FileInfo fi = new FileInfo(fullPath);
            _name = Path.GetFileNameWithoutExtension(fullPath);
            _size = fi.Length;
            _type = fi.Extension;
        }

        public override string GetName() {
            return _name;
        }
        public override string GetSize() {
            return _size.ToString();
        }
        public override string GetType() {
            return _type;
        }
        public void Show(ListView lv) {
            ListViewItem dirItem = new ListViewItem {
                Text = _name,
                ImageIndex = 2
            };
            lv.Items.Add(dirItem);
        }
    }
}
