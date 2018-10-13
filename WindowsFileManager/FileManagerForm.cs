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
            LPanel.ShowItems(LListView, "", LPathBox);
            RPanel.ShowItems(RListView, "", RPathBox);
        }

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

        private void LListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control == true && e.KeyCode == Keys.Z) {
                Interface.GoBack(LListView, LPanel, LPathBox);
            }
        }
        private void RListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control == true && e.KeyCode == Keys.Z) {
                Interface.GoBack(RListView, RPanel, RPathBox);
            }
        }

    }
}
