namespace Disk_information
{
    partial class FormDiskInfo
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
            this.labelListOfDisks = new System.Windows.Forms.Label();
            this.comboBoxListOfDisks = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxAvailableDiscs = new System.Windows.Forms.ListBox();
            this.labelInformationAboutSelectedDrive = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelInfoDirectoriesAndFiles = new System.Windows.Forms.Label();
            this.listBoxInfoDirectoriesAndFiles = new System.Windows.Forms.ListBox();
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory = new System.Windows.Forms.Label();
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelInfoSelectedDirectoryOrFile = new System.Windows.Forms.Label();
            this.listBoxInfoSelectedDirectoryOrFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelListOfDisks
            // 
            this.labelListOfDisks.AutoSize = true;
            this.labelListOfDisks.Location = new System.Drawing.Point(13, 24);
            this.labelListOfDisks.Name = "labelListOfDisks";
            this.labelListOfDisks.Size = new System.Drawing.Size(142, 23);
            this.labelListOfDisks.TabIndex = 0;
            this.labelListOfDisks.Text = "Список дисків:";
            // 
            // comboBoxListOfDisks
            // 
            this.comboBoxListOfDisks.FormattingEnabled = true;
            this.comboBoxListOfDisks.Location = new System.Drawing.Point(161, 18);
            this.comboBoxListOfDisks.Name = "comboBoxListOfDisks";
            this.comboBoxListOfDisks.Size = new System.Drawing.Size(161, 31);
            this.comboBoxListOfDisks.TabIndex = 1;
            this.comboBoxListOfDisks.SelectedIndexChanged += new System.EventHandler(this.comboBoxListOfDisks_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonUpdate.Location = new System.Drawing.Point(344, 18);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 31);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Оновити";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listBoxAvailableDiscs
            // 
            this.listBoxAvailableDiscs.FormattingEnabled = true;
            this.listBoxAvailableDiscs.ItemHeight = 23;
            this.listBoxAvailableDiscs.Location = new System.Drawing.Point(17, 92);
            this.listBoxAvailableDiscs.Name = "listBoxAvailableDiscs";
            this.listBoxAvailableDiscs.Size = new System.Drawing.Size(467, 257);
            this.listBoxAvailableDiscs.TabIndex = 3;
            // 
            // labelInformationAboutSelectedDrive
            // 
            this.labelInformationAboutSelectedDrive.AutoSize = true;
            this.labelInformationAboutSelectedDrive.Location = new System.Drawing.Point(13, 66);
            this.labelInformationAboutSelectedDrive.Name = "labelInformationAboutSelectedDrive";
            this.labelInformationAboutSelectedDrive.Size = new System.Drawing.Size(289, 23);
            this.labelInformationAboutSelectedDrive.TabIndex = 4;
            this.labelInformationAboutSelectedDrive.Text = "Інформація про вибраний диск";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.Location = new System.Drawing.Point(1178, 715);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 34);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelInfoDirectoriesAndFiles
            // 
            this.labelInfoDirectoriesAndFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoDirectoriesAndFiles.AutoSize = true;
            this.labelInfoDirectoriesAndFiles.Location = new System.Drawing.Point(13, 376);
            this.labelInfoDirectoriesAndFiles.Name = "labelInfoDirectoriesAndFiles";
            this.labelInfoDirectoriesAndFiles.Size = new System.Drawing.Size(370, 23);
            this.labelInfoDirectoriesAndFiles.TabIndex = 6;
            this.labelInfoDirectoriesAndFiles.Text = "Каталоги та файли на вибраному диску";
            // 
            // listBoxInfoDirectoriesAndFiles
            // 
            this.listBoxInfoDirectoriesAndFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxInfoDirectoriesAndFiles.FormattingEnabled = true;
            this.listBoxInfoDirectoriesAndFiles.ItemHeight = 23;
            this.listBoxInfoDirectoriesAndFiles.Location = new System.Drawing.Point(17, 402);
            this.listBoxInfoDirectoriesAndFiles.Name = "listBoxInfoDirectoriesAndFiles";
            this.listBoxInfoDirectoriesAndFiles.Size = new System.Drawing.Size(467, 303);
            this.listBoxInfoDirectoriesAndFiles.TabIndex = 7;
            this.listBoxInfoDirectoriesAndFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxInfoDirectoriesAndFiles_SelectedIndexChanged);
            // 
            // labelSubdirectoriesAndFilesInTheSelectedDirectory
            // 
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.AutoSize = true;
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.Location = new System.Drawing.Point(523, 24);
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.Name = "labelSubdirectoriesAndFilesInTheSelectedDirectory";
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.Size = new System.Drawing.Size(409, 23);
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.TabIndex = 10;
            this.labelSubdirectoriesAndFilesInTheSelectedDirectory.Text = "Підкаталоги та файли у вибраному каталозі";
            // 
            // listBoxSubdirectoriesAndFilesInTheSelectedDirectory
            // 
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.FormattingEnabled = true;
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.ItemHeight = 23;
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Location = new System.Drawing.Point(527, 50);
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Name = "listBoxSubdirectoriesAndFilesInTheSelectedDirectory";
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Size = new System.Drawing.Size(743, 372);
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.TabIndex = 11;
            this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory.SelectedIndexChanged += new System.EventHandler(this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Клікніть по каталозі, якщо хочете дізнатись його підкаталоги та файли, або по фай" +
    "лу, щоб дізнатись інформацію.";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Location = new System.Drawing.Point(1170, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 31);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelInfoSelectedDirectoryOrFile
            // 
            this.labelInfoSelectedDirectoryOrFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoSelectedDirectoryOrFile.AutoSize = true;
            this.labelInfoSelectedDirectoryOrFile.Location = new System.Drawing.Point(523, 445);
            this.labelInfoSelectedDirectoryOrFile.Name = "labelInfoSelectedDirectoryOrFile";
            this.labelInfoSelectedDirectoryOrFile.Size = new System.Drawing.Size(429, 23);
            this.labelInfoSelectedDirectoryOrFile.TabIndex = 14;
            this.labelInfoSelectedDirectoryOrFile.Text = "Інформація по вибраному каталозі або файлу";
            // 
            // listBoxInfoSelectedDirectoryOrFile
            // 
            this.listBoxInfoSelectedDirectoryOrFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInfoSelectedDirectoryOrFile.FormattingEnabled = true;
            this.listBoxInfoSelectedDirectoryOrFile.ItemHeight = 23;
            this.listBoxInfoSelectedDirectoryOrFile.Location = new System.Drawing.Point(527, 471);
            this.listBoxInfoSelectedDirectoryOrFile.Name = "listBoxInfoSelectedDirectoryOrFile";
            this.listBoxInfoSelectedDirectoryOrFile.Size = new System.Drawing.Size(618, 234);
            this.listBoxInfoSelectedDirectoryOrFile.TabIndex = 15;
            // 
            // FormDiskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.listBoxInfoSelectedDirectoryOrFile);
            this.Controls.Add(this.labelInfoSelectedDirectoryOrFile);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSubdirectoriesAndFilesInTheSelectedDirectory);
            this.Controls.Add(this.labelSubdirectoriesAndFilesInTheSelectedDirectory);
            this.Controls.Add(this.listBoxInfoDirectoriesAndFiles);
            this.Controls.Add(this.labelInfoDirectoriesAndFiles);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelInformationAboutSelectedDrive);
            this.Controls.Add(this.listBoxAvailableDiscs);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxListOfDisks);
            this.Controls.Add(this.labelListOfDisks);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormDiskInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiskInfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListOfDisks;
        private System.Windows.Forms.ComboBox comboBoxListOfDisks;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ListBox listBoxAvailableDiscs;
        private System.Windows.Forms.Label labelInformationAboutSelectedDrive;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelInfoDirectoriesAndFiles;
        private System.Windows.Forms.ListBox listBoxInfoDirectoriesAndFiles;
        private System.Windows.Forms.Label labelSubdirectoriesAndFilesInTheSelectedDirectory;
        private System.Windows.Forms.ListBox listBoxSubdirectoriesAndFilesInTheSelectedDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelInfoSelectedDirectoryOrFile;
        private System.Windows.Forms.ListBox listBoxInfoSelectedDirectoryOrFile;
    }
}

