﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFileManager {
    public class Container : FileSystemObject {
        public Container(string fullPath, string parent) : base(fullPath, parent) {
        }


        public override string GetName() {
            throw new NotImplementedException();
        }
        public override string GetType() {
            throw new NotImplementedException();
        }
        public override string GetSize() {
            throw new NotImplementedException();
        }


        /*virtual public Folder[] getFolders() {

        }
        virtual public File[] getFiles() {

        }*/
        virtual public FileSystemObject[] GetChildren() {
            FileSystemObject[] children = new FileSystemObject[1];
            return children;
        }
    }
}