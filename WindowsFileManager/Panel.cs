using System.Windows.Forms;
using System.IO;
using System;

namespace WindowsFileManager {
    public class Panel {
        public string currentPath;
        public Panel() {
            currentPath = "";
        }

        public void ShowItems(ListView lv, string path, TextBox TextBox) {
            TextBox.Text = path;
            if (path == "") {
                LoadDrives(lv);
                return;
            }
            ListViewItem goBack = new ListViewItem {
                Text = "...",
                ImageIndex = 5
            };
            lv.Items.Add(goBack);

            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string dir in dirs) {
                Folder newDir = new Folder(dir);
                newDir.Show(lv);
            }
            foreach (string file in files) {
                File newFile = new File(file);
                newFile.Show(lv);
            }
        }

        public void LoadDrives(ListView lv) {
            MyComputer myComp = new MyComputer("");
            Disk[] disks = myComp.GetDisks();
            foreach (Disk d in disks) {
                try {
                    ListViewItem lvi = new ListViewItem(d.GetPath(), 0);
                    lv.Items.Add(lvi);
                } catch { }
            }
            currentPath = "";
        }

        public void GoToFolder(ListView lv, string newPath, TextBox TextBox) {
            lv.Items.Clear();
            currentPath = newPath;
            ShowItems(lv, currentPath, TextBox);
        }
    }
}

