using System;
using System.Windows.Forms;

namespace WindowsFileManager {
    public partial class TextEditorForm : Form {
        private TextEditorController Controller = new TextEditorController();

        public TextEditorForm(string path) {
            InitializeComponent();
            Controller.LoadFile(path, richTextBox1, currentFileName);
        }

        private void TextEditor_Load(object sender, EventArgs e) {
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e) {
            Controller.NewFile(richTextBox1, currentFileName);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            Controller.OpenFile(richTextBox1, currentFileName);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            Controller.SaveFile(richTextBox1, currentFileName);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            Controller.SaveFileAs(richTextBox1, currentFileName);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Controller.Close(richTextBox1, currentFileName)) {
                this.Close();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Made by Denis Kochetkov, K-26", "About");
        }








        private void richTextBox1_KeyDown(object sender, KeyEventArgs e) {
            Controller.CheckTextBox(richTextBox1, currentFileName);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e) {
            Controller.CheckTextBox(richTextBox1, currentFileName);
        }




        private void inverseRegisterToolStripMenuItem_Click(object sender, EventArgs e) {
            Controller.InverseRegister(richTextBox1);
        }

        private void mergeHTMLToolStripMenuItem_Click(object sender, EventArgs e) {
            Controller.MergeHTML(richTextBox1, currentFileName);
        }

        private void TextEditorForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control) {
                if (e.KeyCode == Keys.S) {
                    Controller.SaveFile(richTextBox1, currentFileName);
                } else if (e.KeyCode == Keys.N) {
                    Controller.NewFile(richTextBox1, currentFileName);
                } else if (e.KeyCode == Keys.O) {
                    Controller.OpenFile(richTextBox1, currentFileName);
                }
            }
        }
    }
}
