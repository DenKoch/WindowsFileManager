using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFileManager {
    public partial class FileManagerForm : Form {

        Panel LPanel = new Panel();
        Panel RPanel = new Panel();
        FileManagerInterface Interface = new FileManagerInterface();

        public FileManagerForm() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            LPanel.GoToFolder(LListView, "", LPathBox);
            RPanel.GoToFolder(RListView, "", RPathBox);
        }

        //обновление обоих панелей
        private void Refresh() {
            LPanel.RefreshLV(LListView, LPanel.currentPath);
            RPanel.RefreshLV(RListView, RPanel.currentPath);
        }


        //дабл клик
        private void LListView_DoubleClick(object sender, EventArgs e) {
            string path = null;
            if (LListView.SelectedItems.Count != 1) {
                return;
            }

            if (LListView.SelectedItems[0].Text == "...") { //ход назад
                Interface.GoBack(LListView, LPanel, LPathBox);
            } else if (LListView.SelectedItems[0].ImageIndex == 1 || LListView.SelectedItems[0].ImageIndex == 0) { //открытие папки или диска
                path = LPanel.currentPath + LListView.SelectedItems[0].Text;
                if (LPanel.currentPath != "") {
                    path += @"\";
                }
                Interface.OpenFolder(LListView, LPanel, LPathBox);
            } else { //открытие файла
                Interface.OpenFile();
            }
        }
        private void RListView_DoubleClick(object sender, EventArgs e) {
            string path = null;
            if (RListView.SelectedItems.Count != 1) {
                return;
            }

            if (RListView.SelectedItems[0].Text == "...") { //ход назад
                Interface.GoBack(RListView, RPanel, RPathBox);
            } else if (RListView.SelectedItems[0].ImageIndex == 1 || RListView.SelectedItems[0].ImageIndex == 0) { //открытие папки или диска
                path = RPanel.currentPath + RListView.SelectedItems[0].Text;
                if (RPanel.currentPath != "") {
                    path += @"\";
                }
                Interface.OpenFolder(RListView, RPanel, RPathBox);
            } else { //открытие файла
                Interface.OpenFile();
            }
        }




        //нажатие клавиши
        private void LListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (LPanel.isNewFolderCreated()) {
                    Interface.CreateFolderSubmit(LListView, LPanel, LPathBox);
                } else if (LPanel.isNewFileCreated()) {
                    Interface.CreateTXTSubmit(LListView, LPanel, LPathBox);
                }
                Refresh();
            }
            if (e.KeyCode == Keys.Delete) {
                Interface.Delete(LListView, LPanel, LPathBox);
            }
            if (e.Control == true && e.KeyCode == Keys.Z) {
                Interface.GoBack(LListView, LPanel, LPathBox);
            }
        }
        private void RListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (RPanel.isNewFolderCreated()) {
                    Interface.CreateFolderSubmit(RListView, RPanel, RPathBox);
                } else if (RPanel.isNewFileCreated()) {
                    Interface.CreateTXTSubmit(RListView, RPanel, RPathBox);
                }
                Refresh();
            }
            if (e.KeyCode == Keys.Delete) {
                Interface.Delete(RListView, RPanel, RPathBox);
            }
            if (e.Control == true && e.KeyCode == Keys.Z) {
                Interface.GoBack(RListView, RPanel, RPathBox);
            }
        }

        //удалить
        private void DeleteL_Click(object sender, EventArgs e) {
            Interface.Delete(LListView, LPanel, LPathBox);
            Refresh();
        }
        private void DeleteR_Click(object sender, EventArgs e) {
            Interface.Delete(RListView, RPanel, RPathBox);
            Refresh();
        }

        //копировать
        private void CopyL_Click(object sender, EventArgs e) {
            Interface.Copy(LListView, LPanel);
        }
        private void CopyR_Click(object sender, EventArgs e) {
            Interface.Copy(RListView, RPanel);
        }

        //новая папка
        private void LNewFolder_Click(object sender, EventArgs e) {
            Interface.CreateFolderName(LListView, LPanel, LPathBox);
        }
        private void RNewFolder_Click(object sender, EventArgs e) {
            Interface.CreateFolderName(RListView, RPanel, RPathBox);
        }

        //вставить
        private void LPaste_Click(object sender, EventArgs e) {
            Interface.Paste(LListView, LPanel);
            Refresh();

        }
        private void RPaste_Click(object sender, EventArgs e) {
            Interface.Paste(RListView, RPanel);
            Refresh();

        }

        //новый текстовый файл
        private void LNewTXT_Click(object sender, EventArgs e) {
            Interface.CreateTextFile(LListView, LPanel, LPathBox);
        }
        private void RNewTXT_Click(object sender, EventArgs e) {
            Interface.CreateTextFile(RListView, RPanel, RPathBox);
        }

        //справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Made by Denis Kochetkov, K-26", "Справка");
        }
    }
}
