
namespace SimpleFileManager
{
    partial class fileManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileManagerForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 355);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(93, 12);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(546, 20);
            this.filePathTextBox.TabIndex = 2;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(645, 9);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(72, 428);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(13, 13);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Type";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(642, 428);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(13, 13);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Toma4025-Rumax-Folder-documents.ico");
            this.iconList.Images.SetKeyName(1, "Toma4025-Rumax-Folder-ok.ico");
            this.iconList.Images.SetKeyName(2, "Hopstarter-Sleek-Xp-Basic-Document-Blank.ico");
            this.iconList.Images.SetKeyName(3, "Royalflushxx-Systematrix-Document.ico");
            this.iconList.Images.SetKeyName(4, "Hopstarter-Soft-Scraps-Adobe-PDF-Document.ico");
            this.iconList.Images.SetKeyName(5, "Robsonbillponte-Sinem-File-Music-2.ico");
            this.iconList.Images.SetKeyName(6, "Pelfusion-Flat-File-Type-Exe.ico");
            this.iconList.Images.SetKeyName(7, "Papirus-Team-Papirus-Mimetypes-Unknown.ico");
            this.iconList.Images.SetKeyName(8, "Robsonbillponte-Sinem-File-Picture.ico");
            // 
            // fileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 477);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBack);
            this.Name = "fileManagerForm";
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.fileManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList iconList;
    }
}

