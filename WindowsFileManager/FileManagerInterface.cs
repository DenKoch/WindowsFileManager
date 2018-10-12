using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileManager {
    public class FileManagerInterface {

        public void Open(ListView lv, string currentPath, Panel panel, TextBox TextBox, bool goBack) {
            string path = null;
            if (lv.SelectedItems.Count == 1) {
                if (lv.SelectedItems[0].Text == "...") {
                    goBack = true;
                } else {
                    path = currentPath + lv.SelectedItems[0].Text;
                    if (currentPath != "") {
                        path += @"\";
                    }
                }
            }
            if (goBack && currentPath != "") {
                path = currentPath.Remove(currentPath.LastIndexOf(@"\"), 1);
                path = path.Remove(path.LastIndexOf(@"\") + 1, path.Length - path.LastIndexOf(@"\") - 1);
            }
            //MessageBox.Show(path);
            try {
                if (Directory.Exists(path) || path == "") {
                    panel.GoToFolder(lv, path, TextBox);
                } else {
                    MessageBox.Show("Папка не существует");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }




    }
}
