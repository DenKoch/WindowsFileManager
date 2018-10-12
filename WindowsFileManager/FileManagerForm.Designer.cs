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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LPathBox = new System.Windows.Forms.TextBox();
            this.RPathBox = new System.Windows.Forms.TextBox();
            this.LListView = new System.Windows.Forms.ListView();
            this.LName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RListView = new System.Windows.Forms.ListView();
            this.LType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.LListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LListView.LargeImageList = this.imageList1;
            this.LListView.Location = new System.Drawing.Point(3, 27);
            this.LListView.Name = "LListView";
            this.LListView.Size = new System.Drawing.Size(486, 407);
            this.LListView.SmallImageList = this.imageList1;
            this.LListView.StateImageList = this.imageList1;
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
            // RListView
            // 
            this.RListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RName,
            this.RType,
            this.RSize});
            this.RListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RListView.LargeImageList = this.imageList1;
            this.RListView.Location = new System.Drawing.Point(495, 27);
            this.RListView.Name = "RListView";
            this.RListView.Size = new System.Drawing.Size(486, 407);
            this.RListView.SmallImageList = this.imageList1;
            this.RListView.StateImageList = this.imageList1;
            this.RListView.TabIndex = 3;
            this.RListView.UseCompatibleStateImageBehavior = false;
            this.RListView.View = System.Windows.Forms.View.Details;
            this.RListView.DoubleClick += new System.EventHandler(this.RListView_DoubleClick);
            this.RListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RListView_KeyDown);
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
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FileManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cassini";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
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
    }
}

