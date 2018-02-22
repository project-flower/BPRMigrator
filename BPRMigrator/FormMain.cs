using BPRMigrator.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BPRMigrator
{
    public partial class FormMain : Form
    {
        private readonly string fileListElementName;
        private readonly string fileNameElementName;
        private readonly string includePathElementName;
        private readonly string libPathElementName;
        private readonly string macrosElementName;

        private void setTextToClipboard(string text)
        {
            try
            {
                Clipboard.SetText(text);
                MessageBox.Show("クリップボードにコピーしました。", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public FormMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = Size;
            fileListElementName = Resources.FileListElementName;
            fileNameElementName = Resources.FileNameElementName;
            includePathElementName = Resources.IncludePathElementName;
            libPathElementName = Resources.LibPathElementName;
            macrosElementName = Resources.MacrosElementName;
            Icon.Save(new FileStream(".\\BPRMigrator.ico", FileMode.CreateNew, FileAccess.Write));
        }

        private void fileSelector_SelectedFileChanged(object sender, EventArgs e)
        {
            string fileName;

            try
            {
                var fileInfo = new FileInfo(fileSelector.SelectedFile);

                if (!(fileInfo.Exists))
                {
                    return;
                }

                fileName = fileInfo.FullName;
            }
            catch (ArgumentException)
            {
                return;
            }

            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }

            try
            {
                textBoxIncludePath.Text = MainEngine.GetFormattedPaths(fileName, macrosElementName, includePathElementName);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }

            try
            {
                textBoxLibPath.Text = MainEngine.GetFormattedPaths(fileName, macrosElementName, libPathElementName);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
        }

        private void listView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string selectedFile = fileSelector.SelectedFile;

            if (string.IsNullOrEmpty(selectedFile))
            {
                return;
            }

            string[] fileNames;

            try
            {
                fileNames = MainEngine.GetProjectFiles(selectedFile, fileListElementName, fileNameElementName).ToArray();
            }
            catch (Exception exception)
            {
                showErrorMessage(selectedFile + "\r\n" + exception.Message);
                return;
            }

            DragDropEffects effect = listView.DoDragDrop(new DataObject(DataFormats.FileDrop, fileNames), DragDropEffects.All);
        }

        private void buttonCopyIncludePath_Click(object sender, EventArgs e)
        {
            setTextToClipboard(textBoxIncludePath.Text);
        }

        private void buttonCopyLibPath_Click(object sender, EventArgs e)
        {
            setTextToClipboard(textBoxLibPath.Text);
        }
    }
}
