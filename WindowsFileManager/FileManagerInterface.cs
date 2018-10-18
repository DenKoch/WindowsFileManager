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

        public void Delete(ListView lv, Panel panel, TextBox textBox) {
            int n = lv.SelectedItems.Count;
            if (n == 0) {
                return;
            }
            if (textBox.Text == "") {
                MessageBox.Show("Вы не можете удалить локальный диск!", "Удалить");
                return;
            }

            string[] selection = new string[n];
            for (int i = 0; i < n; i++) {
                selection[i] = textBox.Text + lv.SelectedItems[i].Text + lv.SelectedItems[i].SubItems[1].Text;
            }

            if (MessageBox.Show("Вы действительно хотите это удалить?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                panel.Delete(lv, selection);
                panel.RefreshLV(lv, panel.currentPath);
            }
        }

        public void CreateFolderName(ListView lv, Panel panel, TextBox textBox) {
            if (textBox.Text == "") {
                return;
            }
            panel.CreateFolderName(lv, panel, textBox);
        }

        public void CreateFolderSubmit(ListView lv, Panel panel, TextBox textBox) {
            panel.CreateFolderSubmit(lv, panel, textBox);
            panel.RefreshLV(lv, panel.currentPath);
        }

        public void Copy(ListView lv, Panel panel) {
            Clipboard.Clear();
            string sourcePath = panel.currentPath;
            Clipboard.SetText(panel.currentPath + lv.SelectedItems[0].Text +
                lv.SelectedItems[0].SubItems[1].Text);

            /*
            int n = lv.SelectedItems.Count;
            string[] selection = new string[n];
            string totalPath = null;
            for(int i = 0; i < n; i++) {
                selection[i] = lv.SelectedItems[i].Text + lv.SelectedItems[i].SubItems[1].Text;
                totalPath += selection[i] + "*";
            }
            Clipboard.SetText(totalPath);
            */

        }

        public void Paste(ListView lv, Panel panel) {
            string source = Clipboard.GetText();
            string target = panel.currentPath;

            FileInfo fi = new FileInfo(source);
            target += Path.GetFileName(source);

            System.IO.File.Copy(source, target, true);
            panel.RefreshLV(lv, panel.currentPath);
        }
    }
}


