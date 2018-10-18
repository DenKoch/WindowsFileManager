using System.Windows.Forms;
using System.IO;
using System;

namespace WindowsFileManager {
    public class Panel {
        public string currentPath;
        public Panel() {
            currentPath = "";
        }

        public void RefreshLV(ListView lv, string path) {
            lv.Items.Clear();
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
            currentPath = newPath;
            TextBox.Text = currentPath;
            RefreshLV(lv, currentPath);
        }



        public void Delete(ListView lv, string[] selection) {
            int n = selection.Length;
            for (int i = 0; i < n; i++) {
                try {
                    if (Directory.Exists(selection[i])) {
                        Folder folder = new Folder(selection[i]);
                        folder.Delete(selection[i]);
                    } else {
                        MessageBox.Show(selection[i]);
                        File file = new File(selection[i]);
                        file.Delete(selection[i]);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CreateFolderName(ListView lv, Panel panel, TextBox textBox) {
            ListViewItem newf = new ListViewItem();
            newf.ImageIndex = 1;
            lv.Items.Add(newf);
            lv.Items[lv.Items.Count - 1].BeginEdit();
        }

        public void CreateFolderSubmit(ListView lv, Panel panel, TextBox textBox) {
            try {
                if (lv.Items[lv.Items.Count - 1].Text != " ") {
                    string path = textBox.Text + @"\" + lv.Items[lv.Items.Count - 1].Text;
                    Directory.CreateDirectory(path);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

