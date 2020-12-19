using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Disk_information
{
    public partial class FormDiskInfo : Form
    {
        DriveInfo[] drives;
        List<string> tempDirName = new List<string>();
        public FormDiskInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonUpdate_Click(sender, e);
        }

        private void comboBoxListOfDisks_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAvailableDiscs.Items.Clear();
            int current = comboBoxListOfDisks.SelectedIndex;
            if (current >= 0)
            {
                listBoxAvailableDiscs.Items.Add($"Ім’я: {drives[current].Name}");
                listBoxAvailableDiscs.Items.Add($"Тип диска: {drives[current].DriveType}");
                listBoxAvailableDiscs.Items.Add($"Чи готовий диск: {drives[current].IsReady}");
                if (drives[current].IsReady)
                {
                    listBoxAvailableDiscs.Items.Add($"Ім'я файлової системи: {drives[current].DriveFormat}");
                    listBoxAvailableDiscs.Items.Add($"Обсяг: {drives[current].TotalSize} B  =  {drives[current].TotalSize / 1073741824.0, 0:f3} GB");
                    listBoxAvailableDiscs.Items.Add($"Вільне місце: {drives[current].AvailableFreeSpace} B  =  {drives[current].AvailableFreeSpace / 1073741824.0, 0:f3} GB");
                    if (drives[current].VolumeLabel != "")
                        listBoxAvailableDiscs.Items.Add($"Мітка тому: {drives[current].VolumeLabel}");
                }
                string dirName = drives[current].Name;
                FillListBoxDirectoryAndFile(listBoxInfoDirectoriesAndFiles, dirName);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            comboBoxListOfDisks.SelectedIndex = -1;
            comboBoxListOfDisks.Items.Clear();
            listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Items.Clear();
            listBoxInfoSelectedDirectoryOrFile.Items.Clear();
            listBoxInfoDirectoriesAndFiles.Items.Clear();
            tempDirName.Clear();

            drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
                comboBoxListOfDisks.Items.Add(drive.Name);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxInfoDirectoriesAndFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string dirName = listBoxInfoDirectoriesAndFiles.SelectedItem.ToString();
                tempDirName.Clear();
                tempDirName.Add(dirName);
                FillListBoxDirectoryAndFile(listBoxSubdirectoriesAndFilesInTheSelectedDirectory, dirName);
                FillBoxInfo(listBoxInfoSelectedDirectoryOrFile, dirName);
            }
            catch (Exception exc)
            {
                listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Items.Add(exc.ToString());
            }
        }

        private void listBoxSubdirectoriesAndFilesInTheSelectedDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string dirName = listBoxSubdirectoriesAndFilesInTheSelectedDirectory.SelectedItem.ToString();
                if (Directory.Exists(dirName))
                    tempDirName.Add(dirName);
                FillListBoxDirectoryAndFile(listBoxSubdirectoriesAndFilesInTheSelectedDirectory, dirName);
                FillBoxInfo(listBoxInfoSelectedDirectoryOrFile, dirName);
            }
            catch (Exception exc)
            {
                listBoxSubdirectoriesAndFilesInTheSelectedDirectory.Items.Add(exc.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (tempDirName.Count() >= 2)
            {
                tempDirName.Remove(tempDirName[tempDirName.Count() - 1]);
                string dirName = tempDirName[tempDirName.Count() - 1];
                FillListBoxDirectoryAndFile(listBoxSubdirectoriesAndFilesInTheSelectedDirectory, dirName);
            }
        }

        public void FillListBoxDirectoryAndFile(ListBox lBox, string dirName)
        {
            try
            {
                if (Directory.Exists(dirName))
                {
                    lBox.Items.Clear();
                    string[] dirs = Directory.GetDirectories(dirName);
                    lBox.Items.Add($"Каталоги:({dirs.Count()})");
                    foreach (string s in dirs)
                        lBox.Items.Add(s);

                    lBox.Items.Add("");

                    string[] files = Directory.GetFiles(dirName);
                    lBox.Items.Add($"Файли:({files.Count()})");
                    foreach (string s in files)
                        lBox.Items.Add(s);
                }
            }
            catch (Exception exc)
            {
                lBox.Items.Add(exc.ToString());
            }
        }

        public void FillBoxInfo(ListBox lBox, string objectName)
        {
            try
            {
                lBox.Items.Clear();
                if (Directory.Exists(objectName))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(objectName);
                    lBox.Items.Add($"Назва каталогу: {dirInfo.Name}");
                    lBox.Items.Add($"Повна назва каталогу: {dirInfo.FullName}");
                    lBox.Items.Add($"Час створення каталогу: {dirInfo.CreationTime}");
                    lBox.Items.Add($"Кореневий каталог: {dirInfo.Root}");
                    if (dirInfo.Parent.ToString() != "")
                        lBox.Items.Add($"Батьківський каталог: {dirInfo.Parent}");
                    lBox.Items.Add($"Час останнього доступу до директорії: {dirInfo.LastAccessTime}");
                    lBox.Items.Add($"Час останньої зміни файлів в директорії: {dirInfo.LastWriteTime}");
                }
                else if (File.Exists(objectName))
                {
                    FileInfo fileInfo = new FileInfo(objectName);
                    lBox.Items.Add($"Iм'я файлу: {fileInfo.Name}");
                    lBox.Items.Add($"Повне ім'я файлу: {fileInfo.FullName}");
                    lBox.Items.Add($"Розширення файлу: {fileInfo.Extension}");
                    lBox.Items.Add($"Повний шлях до батьківського каталогу: {fileInfo.DirectoryName}");
                    lBox.Items.Add($"Час створення: {fileInfo.CreationTime}");
                    lBox.Items.Add($"Розмір: {fileInfo.Length} B");
                    lBox.Items.Add($"Час останнього доступу до файла: {fileInfo.LastAccessTime}");
                    lBox.Items.Add($"Час останньої зміни файла: {fileInfo.LastWriteTime}");
                }
            }
            catch (Exception exc)
            {
                lBox.Items.Add(exc.ToString());
            }
        }
    }
}
