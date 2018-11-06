using System.Windows.Forms;
using System.IO;
using System;

namespace WindowsFileManager {
    public class Panel {
        public string currentPath;
        private bool _isNewFolderCreated;
        private bool _isNewFileCreated;


        public Panel() {
            currentPath = "";
            _isNewFolderCreated = false;
            _isNewFileCreated = false;
        }

        public bool IsNewFolderCreated() {
            return _isNewFolderCreated;
        }

        public bool IsNewFileCreated() {
            return _isNewFileCreated;
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
                ListViewItem lvi = new ListViewItem(d.GetPath(), 0);
                lv.Items.Add(lvi);
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
                        Folder.Delete(selection[i]);
                    } else {
                        File.Delete(selection[i]);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CreateFolderName(ListView lv, Panel panel, TextBox textBox) {
            _isNewFolderCreated = true;
            ListViewItem newf = new ListViewItem {
                ImageIndex = 1
            };
            lv.Items.Add(newf);
            lv.Items[lv.Items.Count - 1].BeginEdit();

        }

        public void CreateFolderSubmit(ListView lv, Panel panel, TextBox textBox) {
            if (lv.Items[lv.Items.Count - 1].ImageIndex != 1) {
                return;
            }
            try {
                if (lv.Items[lv.Items.Count - 1].Text != " ") {
                    string path = textBox.Text + @"\" + lv.Items[lv.Items.Count - 1].Text;
                    if (Directory.Exists(path)) {
                        MessageBox.Show("Папка с таким именем уже существует!");
                        _isNewFolderCreated = false;
                        return;
                    }
                    Directory.CreateDirectory(path);
                    _isNewFolderCreated = false;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        public void CreateTXT(ListView lv, Panel panel, TextBox textBox) {
            _isNewFileCreated = true;
            ListViewItem newf = new ListViewItem {
                ImageIndex = 3
            };
            lv.Items.Add(newf);
            lv.Items[lv.Items.Count - 1].BeginEdit();
        }

        public void CreateTXTSubmit(ListView lv, Panel panel, TextBox textBox) {
            if (lv.Items[lv.Items.Count - 1].ImageIndex != 3) {
                return;
            }
            try {
                if (lv.Items[lv.Items.Count - 1].Text != " ") {
                    string path = textBox.Text + lv.Items[lv.Items.Count - 1].Text + ".txt";
                    if (!File.Exists(path)) {
                        File.Create(path);
                    } else if (MessageBox.Show("Файл с таким именем уже существует. Перезаписать файл?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        File.Create(path);
                    }
                    _isNewFileCreated = false;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void Copy(ListView lv, Panel panel) {
            Clipboard.Clear();
            string path = null;
            string sourcePath = panel.currentPath;
            path += sourcePath + "*";

            foreach (ListViewItem select in lv.SelectedItems) {
                path += select.Text + select.SubItems[1].Text + "*";
            }

            path = path.Remove(path.Length - 1, 1);
            Clipboard.SetText(path);
        }

        public void Paste(ListView lv, Panel panel) {
            string path = Clipboard.GetText();
            char separator = '*';

            string[] filePathTemp = path.Split(separator);

            string[] filePaths = new string[filePathTemp.Length - 1];
            for (int i = 0; i < filePaths.Length; i++) {
                filePaths[i] = filePathTemp[i + 1];
            }

            string sourcePath = filePathTemp[0];
            string targetPath = panel.currentPath;

            foreach (string sourceFilePath in filePaths) {
                if (sourceFilePath != "") {
                    if (System.IO.File.Exists(sourcePath + sourceFilePath)) {
                        //если это файл
                        try {
                            if (File.Exists(targetPath + sourceFilePath)) {
                                //файл в целевой директории существует
                                FileInfo fi = new FileInfo(targetPath + sourceFilePath);
                                string ext = fi.Extension;
                                string filename = Path.GetFileNameWithoutExtension(targetPath + sourceFilePath);

                                File.Copy(sourcePath + sourceFilePath, targetPath + filename + " - копия" + fi.Extension);
                            } else {
                                File.Copy(sourcePath + sourceFilePath, targetPath + sourceFilePath);
                            }
                        } catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
                    } else {
                        //если это папка
                        Folder.Copy(sourcePath + sourceFilePath, targetPath + sourceFilePath);
                    }
                }
            }
        }
    }
}

