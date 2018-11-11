namespace WindowsFileManager {
    partial class FileManagerForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagerForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LPathBox = new System.Windows.Forms.TextBox();
            this.RPathBox = new System.Windows.Forms.TextBox();
            this.LListView = new System.Windows.Forms.ListView();
            this.LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.LPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.LDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.LNewTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.RListView = new System.Windows.Forms.ListView();
            this.RName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.RPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.RDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.RNewTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.LContextMenuStrip.SuspendLayout();
            this.RContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextEditorToolStripMenuItem});
            this.FileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // TextEditorToolStripMenuItem
            // 
            this.TextEditorToolStripMenuItem.Name = "TextEditorToolStripMenuItem";
            this.TextEditorToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.TextEditorToolStripMenuItem.Text = "Text Editor";
            this.TextEditorToolStripMenuItem.Click += new System.EventHandler(this.TextEditorToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Drive");
            this.imageList.Images.SetKeyName(1, "Folder");
            this.imageList.Images.SetKeyName(2, "File");
            this.imageList.Images.SetKeyName(3, "TextFile");
            this.imageList.Images.SetKeyName(4, "Image");
            this.imageList.Images.SetKeyName(5, "Back");
            this.imageList.Images.SetKeyName(6, "Delete");
            this.imageList.Images.SetKeyName(7, "Copy");
            this.imageList.Images.SetKeyName(8, "Cut");
            this.imageList.Images.SetKeyName(9, "Paste");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LPathBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RPathBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RListView, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 634);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LPathBox
            // 
            this.LPathBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LPathBox.Enabled = false;
            this.LPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPathBox.Location = new System.Drawing.Point(3, 3);
            this.LPathBox.Name = "LPathBox";
            this.LPathBox.Size = new System.Drawing.Size(586, 23);
            this.LPathBox.TabIndex = 0;
            // 
            // RPathBox
            // 
            this.RPathBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPathBox.Enabled = false;
            this.RPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RPathBox.Location = new System.Drawing.Point(595, 3);
            this.RPathBox.Name = "RPathBox";
            this.RPathBox.Size = new System.Drawing.Size(586, 23);
            this.RPathBox.TabIndex = 1;
            // 
            // LListView
            // 
            this.LListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LName,
            this.LType,
            this.LSize});
            this.LListView.ContextMenuStrip = this.LContextMenuStrip;
            this.LListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LListView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LListView.LabelEdit = true;
            this.LListView.LargeImageList = this.imageList;
            this.LListView.Location = new System.Drawing.Point(3, 27);
            this.LListView.Name = "LListView";
            this.LListView.Size = new System.Drawing.Size(586, 604);
            this.LListView.SmallImageList = this.imageList;
            this.LListView.StateImageList = this.imageList;
            this.LListView.TabIndex = 2;
            this.LListView.UseCompatibleStateImageBehavior = false;
            this.LListView.View = System.Windows.Forms.View.Details;
            this.LListView.DoubleClick += new System.EventHandler(this.LListView_DoubleClick);
            this.LListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LListView_KeyDown);
            // 
            // LName
            // 
            this.LName.Text = "Name";
            this.LName.Width = 320;
            // 
            // LType
            // 
            this.LType.Text = "Type";
            // 
            // LSize
            // 
            this.LSize.Text = "Size";
            this.LSize.Width = 80;
            // 
            // LContextMenuStrip
            // 
            this.LContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LNewFolder,
            this.toolStripSeparator1,
            this.LCopy,
            this.LPaste,
            this.LDelete,
            this.LNewTXT});
            this.LContextMenuStrip.Name = "LContextMenuStrip";
            this.LContextMenuStrip.Size = new System.Drawing.Size(166, 120);
            // 
            // LNewFolder
            // 
            this.LNewFolder.Name = "LNewFolder";
            this.LNewFolder.Size = new System.Drawing.Size(165, 22);
            this.LNewFolder.Text = "Новая папка";
            this.LNewFolder.Click += new System.EventHandler(this.LNewFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // LCopy
            // 
            this.LCopy.Name = "LCopy";
            this.LCopy.Size = new System.Drawing.Size(165, 22);
            this.LCopy.Text = "Копировать";
            this.LCopy.Click += new System.EventHandler(this.CopyL_Click);
            // 
            // LPaste
            // 
            this.LPaste.Name = "LPaste";
            this.LPaste.Size = new System.Drawing.Size(165, 22);
            this.LPaste.Text = "Вставить";
            this.LPaste.Click += new System.EventHandler(this.LPaste_Click);
            // 
            // LDelete
            // 
            this.LDelete.Name = "LDelete";
            this.LDelete.Size = new System.Drawing.Size(165, 22);
            this.LDelete.Text = "Удалить";
            this.LDelete.Click += new System.EventHandler(this.DeleteL_Click);
            // 
            // LNewTXT
            // 
            this.LNewTXT.Name = "LNewTXT";
            this.LNewTXT.Size = new System.Drawing.Size(165, 22);
            this.LNewTXT.Text = "Создать txt файл";
            this.LNewTXT.Click += new System.EventHandler(this.LNewTXT_Click);
            // 
            // RListView
            // 
            this.RListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RName,
            this.RType,
            this.RSize});
            this.RListView.ContextMenuStrip = this.RContextMenuStrip;
            this.RListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RListView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RListView.LabelEdit = true;
            this.RListView.LargeImageList = this.imageList;
            this.RListView.Location = new System.Drawing.Point(595, 27);
            this.RListView.Name = "RListView";
            this.RListView.Size = new System.Drawing.Size(586, 604);
            this.RListView.SmallImageList = this.imageList;
            this.RListView.StateImageList = this.imageList;
            this.RListView.TabIndex = 3;
            this.RListView.UseCompatibleStateImageBehavior = false;
            this.RListView.View = System.Windows.Forms.View.Details;
            this.RListView.DoubleClick += new System.EventHandler(this.RListView_DoubleClick);
            this.RListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RListView_KeyDown);
            // 
            // RName
            // 
            this.RName.Text = "Name";
            this.RName.Width = 320;
            // 
            // RType
            // 
            this.RType.Text = "Type";
            // 
            // RSize
            // 
            this.RSize.Text = "Size";
            this.RSize.Width = 80;
            // 
            // RContextMenuStrip
            // 
            this.RContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RNewFolder,
            this.toolStripSeparator2,
            this.RCopy,
            this.RPaste,
            this.RDelete,
            this.RNewTXT});
            this.RContextMenuStrip.Name = "RContextMenuStrip";
            this.RContextMenuStrip.Size = new System.Drawing.Size(166, 120);
            // 
            // RNewFolder
            // 
            this.RNewFolder.Name = "RNewFolder";
            this.RNewFolder.Size = new System.Drawing.Size(165, 22);
            this.RNewFolder.Text = "Новая папка";
            this.RNewFolder.Click += new System.EventHandler(this.RNewFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // RCopy
            // 
            this.RCopy.Name = "RCopy";
            this.RCopy.Size = new System.Drawing.Size(165, 22);
            this.RCopy.Text = "Копировать";
            this.RCopy.Click += new System.EventHandler(this.CopyR_Click);
            // 
            // RPaste
            // 
            this.RPaste.Name = "RPaste";
            this.RPaste.Size = new System.Drawing.Size(165, 22);
            this.RPaste.Text = "Вставить";
            this.RPaste.Click += new System.EventHandler(this.RPaste_Click);
            // 
            // RDelete
            // 
            this.RDelete.Name = "RDelete";
            this.RDelete.Size = new System.Drawing.Size(165, 22);
            this.RDelete.Text = "Удалить";
            this.RDelete.Click += new System.EventHandler(this.DeleteR_Click);
            // 
            // RNewTXT
            // 
            this.RNewTXT.Name = "RNewTXT";
            this.RNewTXT.Size = new System.Drawing.Size(165, 22);
            this.RNewTXT.Text = "Создать txt файл";
            this.RNewTXT.Click += new System.EventHandler(this.RNewTXT_Click);
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cassini File Manager";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.LContextMenuStrip.ResumeLayout(false);
            this.RContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox LPathBox;
        private System.Windows.Forms.TextBox RPathBox;
        private System.Windows.Forms.ListView LListView;
        private System.Windows.Forms.ListView RListView;
        private System.Windows.Forms.ColumnHeader LName;
        private System.Windows.Forms.ColumnHeader LType;
        private System.Windows.Forms.ColumnHeader LSize;
        private System.Windows.Forms.ColumnHeader RName;
        private System.Windows.Forms.ColumnHeader RType;
        private System.Windows.Forms.ColumnHeader RSize;
        private System.Windows.Forms.ContextMenuStrip LContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LCopy;
        private System.Windows.Forms.ToolStripMenuItem LPaste;
        private System.Windows.Forms.ToolStripMenuItem LDelete;
        private System.Windows.Forms.ContextMenuStrip RContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RCopy;
        private System.Windows.Forms.ToolStripMenuItem RPaste;
        private System.Windows.Forms.ToolStripMenuItem RDelete;
        private System.Windows.Forms.ToolStripMenuItem LNewFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RNewFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem LNewTXT;
        private System.Windows.Forms.ToolStripMenuItem RNewTXT;
        private System.Windows.Forms.ToolStripMenuItem TextEditorToolStripMenuItem;
    }
}

