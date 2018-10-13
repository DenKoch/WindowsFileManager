using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileManager {
    public class FileManagerInterface {

        public void GoBack(ListView lv, Panel panel, TextBox textBox) {
            string path = null;
            if (panel.currentPath != "") {
                path = panel.currentPath.Remove(panel.currentPath.LastIndexOf(@"\"), 1);
                path = path.Remove(path.LastIndexOf(@"\") + 1, path.Length - path.LastIndexOf(@"\") - 1);
            }

            try {
                if (Directory.Exists(path) || path == "") {
                    panel.GoToFolder(lv, path, textBox);
                } else {
                    MessageBox.Show("Папка не существует");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        public void OpenFolder(ListView lv, Panel panel, TextBox textBox) {
            string path = null;
            path = panel.currentPath + lv.SelectedItems[0].Text;
            if (panel.currentPath != "") {
                path += @"\";
            }

            try {
                if (Directory.Exists(path) || path == "") {
                    panel.GoToFolder(lv, path, textBox);
                } else {
                    MessageBox.Show("Папка не существует");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void OpenFile() {
            //MessageBox.Show("efskgh");
        }


    }
}
