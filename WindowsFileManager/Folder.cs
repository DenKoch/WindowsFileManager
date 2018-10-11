using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public class Folder : Container {
        private string _name;
        public Folder(string fullPath) : base(fullPath) {
            DirectoryInfo di = new DirectoryInfo(fullPath);
            _name = di.Name;
        }

        public override string GetName() {
            return _name;
        }
        public override string GetType() {
            throw new NotImplementedException();
        }
        public override string GetSize() {
            return "<Папка>";
        }
        public void Show(ListView lv) {
            ListViewItem dirItem = new ListViewItem {
                Text = _name,
                ImageIndex = 1
            };
            lv.Items.Add(dirItem);
        }
    }
}
