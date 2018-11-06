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
            //_type = fi.Extension.Remove(0, 1);
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
            ListViewItem fileItem = new ListViewItem(new[] { this.GetName(), this.GetType(), this.GetSize() });
            if (this.GetType() == ".txt") {
                fileItem.ImageIndex = 3;
            } else {
                fileItem.ImageIndex = 2;
            }
            lv.Items.Add(fileItem);
        }

        static public void Delete(string path) {
            System.IO.File.Delete(path);
        }

        static public bool Exists(string path) {
            return System.IO.File.Exists(path);
        }

        static public void Copy(string sourcePath, string targetPath, bool _override) {
            System.IO.File.Copy(sourcePath, targetPath, _override);
        }
        static public void Copy(string sourcePath, string targetPath) {
            System.IO.File.Copy(sourcePath, targetPath);
        }

        static public void Create(string path) {

            /*
            FileInfo fi = new FileInfo(path);
            string ext = fi.Extension;
            string pathWithoutExt = Path.GetFileNameWithoutExtension(path);
            if (copy) {
                pathWithoutExt += " - копия";
            }
            string newPath = pathWithoutExt + ext;
            */


            FileStream fs = System.IO.File.Create(path);
            fs.Close();
            return;
        }
    }
}
