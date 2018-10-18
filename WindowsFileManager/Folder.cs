﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public class Folder : Container {
        private string _name;
        //private string _path;
        public Folder(string fullPath) : base(fullPath) {
            DirectoryInfo di = new DirectoryInfo(fullPath);
            //_path = fullPath;
            _name = di.Name;
        }

        public override string GetName() {
            return _name;
        }
        public override string GetType() {
            throw new NotImplementedException();
        }
        public override string GetSize() {
            return "<Папка>";
        }
        public void Show(ListView lv) {
            ListViewItem dirItem = new ListViewItem(new[] { this.GetName(), "", this.GetSize() });
            dirItem.ImageIndex = 1;
            lv.Items.Add(dirItem);
        }

        public void Delete(string path) {
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) {
                file.Delete();
            }
            foreach (DirectoryInfo subdir in dirs) {
                Delete(path + @"\" + subdir.Name);
            }
            Directory.Delete(path);
        }
    }
}
