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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.SplitContainer();
            this.LPath = new System.Windows.Forms.TextBox();
            this.LListView = new System.Windows.Forms.ListView();
            this.LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RPath = new System.Windows.Forms.TextBox();
            this.RListView = new System.Windows.Forms.ListView();
            this.RName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.Panel1.SuspendLayout();
            this.mainPanel.Panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.IsSplitterFixed = true;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            // 
            // mainPanel.Panel1
            // 
            this.mainPanel.Panel1.Controls.Add(this.LPath);
            this.mainPanel.Panel1.Controls.Add(this.LListView);
            // 
            // mainPanel.Panel2
            // 
            this.mainPanel.Panel2.Controls.Add(this.RPath);
            this.mainPanel.Panel2.Controls.Add(this.RListView);
            this.mainPanel.Size = new System.Drawing.Size(984, 437);
            this.mainPanel.SplitterDistance = 492;
            this.mainPanel.TabIndex = 1;
            // 
            // LPath
            // 
            this.LPath.Location = new System.Drawing.Point(3, 30);
            this.LPath.Name = "LPath";
            this.LPath.ReadOnly = true;
            this.LPath.Size = new System.Drawing.Size(474, 20);
            this.LPath.TabIndex = 1;
            // 
            // LListView
            // 
            this.LListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LName,
            this.LType,
            this.LSize});
            this.LListView.LargeImageList = this.imageList1;
            this.LListView.Location = new System.Drawing.Point(3, 54);
            this.LListView.Name = "LListView";
            this.LListView.Size = new System.Drawing.Size(474, 371);
            this.LListView.SmallImageList = this.imageList1;
            this.LListView.StateImageList = this.imageList1;
            this.LListView.TabIndex = 1;
            this.LListView.UseCompatibleStateImageBehavior = false;
            this.LListView.View = System.Windows.Forms.View.Details;
            this.LListView.DoubleClick += new System.EventHandler(this.LListView_DoubleClick);
            // 
            // LName
            // 
            this.LName.Text = "Имя";
            this.LName.Width = 300;
            // 
            // LType
            // 
            this.LType.Text = "Тип";
            // 
            // LSize
            // 
            this.LSize.Text = "Размер";
            this.LSize.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imageres_32.ico");
            this.imageList1.Images.SetKeyName(1, "shell32_264.ico");
            this.imageList1.Images.SetKeyName(2, "shell32_1.ico");
            this.imageList1.Images.SetKeyName(3, "imageres_102.ico");
            this.imageList1.Images.SetKeyName(4, "imageres_132.ico");
            this.imageList1.Images.SetKeyName(5, "imageres_5311.ico");
            // 
            // RPath
            // 
            this.RPath.Location = new System.Drawing.Point(11, 28);
            this.RPath.Name = "RPath";
            this.RPath.ReadOnly = true;
            this.RPath.Size = new System.Drawing.Size(474, 20);
            this.RPath.TabIndex = 2;
            // 
            // RListView
            // 
            this.RListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RName,
            this.RType,
            this.RSize});
            this.RListView.LargeImageList = this.imageList1;
            this.RListView.Location = new System.Drawing.Point(11, 54);
            this.RListView.Name = "RListView";
            this.RListView.Size = new System.Drawing.Size(474, 371);
            this.RListView.SmallImageList = this.imageList1;
            this.RListView.StateImageList = this.imageList1;
            this.RListView.TabIndex = 2;
            this.RListView.UseCompatibleStateImageBehavior = false;
            this.RListView.View = System.Windows.Forms.View.Details;
            // 
            // RName
            // 
            this.RName.Text = "Имя";
            this.RName.Width = 300;
            // 
            // RType
            // 
            this.RType.Text = "Тип";
            // 
            // RSize
            // 
            this.RSize.Text = "Размер";
            this.RSize.Width = 100;
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FileManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cassini";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.Panel1.ResumeLayout(false);
            this.mainPanel.Panel1.PerformLayout();
            this.mainPanel.Panel2.ResumeLayout(false);
            this.mainPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainPanel;
        private System.Windows.Forms.ListView LListView;
        private System.Windows.Forms.ListView RListView;
        private System.Windows.Forms.ColumnHeader LName;
        private System.Windows.Forms.ColumnHeader LType;
        private System.Windows.Forms.ColumnHeader LSize;
        private System.Windows.Forms.TextBox LPath;
        private System.Windows.Forms.TextBox RPath;
        private System.Windows.Forms.ColumnHeader RName;
        private System.Windows.Forms.ColumnHeader RType;
        private System.Windows.Forms.ColumnHeader RSize;
        private System.Windows.Forms.ImageList imageList1;
    }
}

