using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileManager {
    public class FileManagerInterface {
        public void Refresh(ListView listView, Panel panel, TextBox pathBox) {

        }

        public void OpenItem(ListView lv) {
            if (lv.SelectedItems.Count > 0) {
                if (lv.SelectedItems[0].ImageIndex == 0 || lv.SelectedItems[0].ImageIndex == 1) {
                    try {
                        //LPanel.GoToFolder(lv, );
                    } catch {
                        MessageBox.Show("Нет доступа!");
                    }
                } else {

                }
            }
        }
    }
}
