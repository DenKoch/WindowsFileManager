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
            Interface.Open(LListView, LPanel.currentPath, LPanel, LPathBox, false);
        }
        private void RListView_DoubleClick(object sender, EventArgs e) {
            Interface.Open(RListView, RPanel.currentPath, RPanel, RPathBox, false);
        }

        private void LListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control == true && e.KeyCode == Keys.Z) {
                Interface.Open(LListView, LPanel.currentPath, LPanel, LPathBox, true);
            }
        }
        private void RListView_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control == true && e.KeyCode == Keys.Z) {
                Interface.Open(RListView, RPanel.currentPath, RPanel, RPathBox, true);
            }
        }

    }
}
