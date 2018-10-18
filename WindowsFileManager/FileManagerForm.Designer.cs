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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LCut = new System.Windows.Forms.ToolStripMenuItem();
            this.LCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.LPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.LDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.RListView = new System.Windows.Forms.ListView();
            this.RName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RCut = new System.Windows.Forms.ToolStripMenuItem();
            this.RCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.RPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.RDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.LContextMenuStrip.SuspendLayout();
            this.RContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LPathBox
            // 
            this.LPathBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LPathBox.Enabled = false;
            this.LPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LPathBox.Location = new System.Drawing.Point(3, 3);
            this.LPathBox.Name = "LPathBox";
            this.LPathBox.Size = new System.Drawing.Size(486, 23);
            this.LPathBox.TabIndex = 0;
            // 
            // RPathBox
            // 
            this.RPathBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPathBox.Enabled = false;
            this.RPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RPathBox.Location = new System.Drawing.Point(495, 3);
            this.RPathBox.Name = "RPathBox";
            this.RPathBox.Size = new System.Drawing.Size(486, 23);
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
            this.LListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LListView.LabelEdit = true;
            this.LListView.LargeImageList = this.imageList;
            this.LListView.Location = new System.Drawing.Point(3, 27);
            this.LListView.Name = "LListView";
            this.LListView.Size = new System.Drawing.Size(486, 407);
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
            this.LName.Text = "Имя";
            this.LName.Width = 320;
            // 
            // LType
            // 
            this.LType.Text = "Тип";
            // 
            // LSize
            // 
            this.LSize.Text = "Размер";
            this.LSize.Width = 80;
            // 
            // LContextMenuStrip
            // 
            this.LContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LNewFolder,
            this.toolStripSeparator1,
            this.LCut,
            this.LCopy,
            this.LPaste,
            this.LDelete});
            this.LContextMenuStrip.Name = "LContextMenuStrip";
            this.LContextMenuStrip.Size = new System.Drawing.Size(144, 120);
            // 
            // LNewFolder
            // 
            this.LNewFolder.Name = "LNewFolder";
            this.LNewFolder.Size = new System.Drawing.Size(180, 22);
            this.LNewFolder.Text = "Новая папка";
            this.LNewFolder.Click += new System.EventHandler(this.LNewFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // LCut
            // 
            this.LCut.Name = "LCut";
            this.LCut.Size = new System.Drawing.Size(180, 22);
            this.LCut.Text = "Вырезать";
            // 
            // LCopy
            // 
            this.LCopy.Name = "LCopy";
            this.LCopy.Size = new System.Drawing.Size(143, 22);
            this.LCopy.Text = "Копировать";
            this.LCopy.Click += new System.EventHandler(this.CopyL_Click);
            // 
            // LPaste
            // 
            this.LPaste.Name = "LPaste";
            this.LPaste.Size = new System.Drawing.Size(180, 22);
            this.LPaste.Text = "Вставить";
            this.LPaste.Click += new System.EventHandler(this.LPaste_Click);
            // 
            // LDelete
            // 
            this.LDelete.Name = "LDelete";
            this.LDelete.Size = new System.Drawing.Size(180, 22);
            this.LDelete.Text = "Удалить";
            this.LDelete.Click += new System.EventHandler(this.DeleteL_Click);
            // 
            // RListView
            // 
            this.RListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RName,
            this.RType,
            this.RSize});
            this.RListView.ContextMenuStrip = this.RContextMenuStrip;
            this.RListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RListView.LabelEdit = true;
            this.RListView.LargeImageList = this.imageList;
            this.RListView.Location = new System.Drawing.Point(495, 27);
            this.RListView.Name = "RListView";
            this.RListView.Size = new System.Drawing.Size(486, 407);
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
            this.RName.Text = "Имя";
            this.RName.Width = 320;
            // 
            // RType
            // 
            this.RType.Text = "Тип";
            // 
            // RSize
            // 
            this.RSize.Text = "Размер";
            this.RSize.Width = 80;
            // 
            // RContextMenuStrip
            // 
            this.RContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RNewFolder,
            this.toolStripSeparator2,
            this.RCut,
            this.RCopy,
            this.RPaste,
            this.RDelete});
            this.RContextMenuStrip.Name = "RContextMenuStrip";
            this.RContextMenuStrip.Size = new System.Drawing.Size(144, 120);
            // 
            // RNewFolder
            // 
            this.RNewFolder.Name = "RNewFolder";
            this.RNewFolder.Size = new System.Drawing.Size(143, 22);
            this.RNewFolder.Text = "Новая папка";
            this.RNewFolder.Click += new System.EventHandler(this.RNewFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // RCut
            // 
            this.RCut.Name = "RCut";
            this.RCut.Size = new System.Drawing.Size(143, 22);
            this.RCut.Text = "Вырезать";
            // 
            // RCopy
            // 
            this.RCopy.Name = "RCopy";
            this.RCopy.Size = new System.Drawing.Size(143, 22);
            this.RCopy.Text = "Копировать";
            this.RCopy.Click += new System.EventHandler(this.CopyR_Click);
            // 
            // RPaste
            // 
            this.RPaste.Name = "RPaste";
            this.RPaste.Size = new System.Drawing.Size(180, 22);
            this.RPaste.Text = "Вставить";
            this.RPaste.Click += new System.EventHandler(this.RPaste_Click);
            // 
            // RDelete
            // 
            this.RDelete.Name = "RDelete";
            this.RDelete.Size = new System.Drawing.Size(143, 22);
            this.RDelete.Text = "Удалить";
            this.RDelete.Click += new System.EventHandler(this.DeleteR_Click);
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 461);
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
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem LCut;
        private System.Windows.Forms.ToolStripMenuItem LCopy;
        private System.Windows.Forms.ToolStripMenuItem LPaste;
        private System.Windows.Forms.ToolStripMenuItem LDelete;
        private System.Windows.Forms.ContextMenuStrip RContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RCut;
        private System.Windows.Forms.ToolStripMenuItem RCopy;
        private System.Windows.Forms.ToolStripMenuItem RPaste;
        private System.Windows.Forms.ToolStripMenuItem RDelete;
        private System.Windows.Forms.ToolStripMenuItem LNewFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RNewFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

