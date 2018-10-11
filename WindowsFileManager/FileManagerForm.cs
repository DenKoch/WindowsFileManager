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
                    path = LPanel.currentPath.Remove(LPanel.currentPath.LastIndexOf(@"\"), 1);
                    path = path.Remove(path.LastIndexOf(@"\") + 1, path.Length - path.LastIndexOf(@"\") - 1);
                } else {
                    path = LPanel.currentPath + LListView.SelectedItems[0].Text;
                    if (LPanel.currentPath != "") {
                        path += @"\";
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
