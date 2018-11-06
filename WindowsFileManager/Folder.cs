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
        private string _path;
        public Folder(string fullPath) : base(fullPath) {
            DirectoryInfo di = new DirectoryInfo(fullPath);
            _path = fullPath;
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
            ListViewItem dirItem = new ListViewItem(new[] { this.GetName(), "", this.GetSize() }) {
                ImageIndex = 1
            };
            lv.Items.Add(dirItem);
        }

        static public void Delete(string path) {
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) {
                file.Delete();
            }
            foreach (DirectoryInfo subdir in dirs) {
                Delete(path + @"\" + subdir.Name);
            }
            Directory.Delete(path);
        }

        static public void Copy(string sourcePath, string targetPath) {
            if (Directory.Exists(targetPath)) {
                targetPath += " - копия";
            }

            Directory.CreateDirectory(targetPath);
            foreach (string filePath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories)) {
                try {
                    File.Copy(filePath, filePath.Replace(sourcePath, targetPath));
                } catch (Exception ex) {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }

            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories)) {
                try {
                    Folder subfolder = new Folder(dirPath);
                    Folder.Copy(dirPath, targetPath + subfolder._name);
                } catch (Exception ex) {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
