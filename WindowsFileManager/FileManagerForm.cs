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

            LPanel.ShowItems(LListView, "");
            RPanel.ShowItems(RListView, "");
        }

        private void LListView_DoubleClick(object sender, EventArgs e) {
            string path = null;
            if (LListView.SelectedItems.Count == 1) {
                if (LListView.SelectedItems[0].Text == "...") {
                    path = LPanel.currentPath.Remove(LPanel.currentPath.LastIndexOf(@"\") + 1, LPanel.currentPath.Length - LPanel.currentPath.LastIndexOf(@"\") - 1);
                    if (LPanel.currentPath == @"C:\" || LPanel.currentPath == @"F:\") {
                        path = "";
                    }
                } else if (LPanel.currentPath == "") {
                    path = LListView.SelectedItems[0].Text;
                } else {
                    path = LPanel.currentPath + @"\" + LListView.SelectedItems[0].Text;
                    if (LPanel.currentPath == @"C:\" || LPanel.currentPath == @"F:\") {
                        path = LPanel.currentPath + LListView.SelectedItems[0].Text;
                    }
                }
            }
            MessageBox.Show(path);

            try {
                if (Directory.Exists(path) || path == "") {
                    LPanel.GoToFolder(LListView, path);
                } else {
                    MessageBox.Show("папка не существует");
                }
            } catch (Exception ex) {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
