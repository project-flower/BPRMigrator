using System;
using System.Drawing;
using System.Windows.Forms;

namespace PFControls
{
    public partial class FileSelector : UserControl
    {
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return comboBoxFileName.AutoCompleteSource;
            }

            set
            {
                switch (value)
                {
                    case AutoCompleteSource.FileSystem:
                    case AutoCompleteSource.FileSystemDirectories:
                        comboBoxFileName.AutoCompleteSource = value;
                        break;
                }
            }
        }

        public Font ButtonFont
        {
            get
            {
                return buttonRefer.Font;
            }

            set
            {
                value = buttonRefer.Font = value;
            }
        }

        public string ButtonText
        {
            get
            {
                return buttonRefer.Text;
            }

            set
            {
                value = buttonRefer.Text = value;
            }
        }

        public Font ComboBoxFont
        {
            get
            {
                return comboBoxFileName.Font;
            }

            set
            {
                value = comboBoxFileName.Font = value;
            }
        }

        public FolderBrowserDialog FolderBrowserDialog
        {
            get
            {
                return folderBrowserDialog;
            }
        }

        public OpenFileDialog OpenFileDialog
        {
            get
            {
                return openFileDialog;
            }
        }

        public string SelectedFile
        {
            get
            {
                return comboBoxFileName.Text;
            }

            set
            {
                value = comboBoxFileName.Text = value;
            }
        }

        public new Size Size
        {
            get
            {
                return base.Size;
            }

            set
            {
                value = base.Size = new Size(value.Width, Height);
            }
        }

        public event EventHandler SelectedFileChanged = delegate { };

        public FileSelector()
        {
            InitializeComponent();
        }

        private void buttonRefer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            string fileName;

            switch (AutoCompleteSource)
            {
                case AutoCompleteSource.FileSystem:
                    openFileDialog.FileName = comboBoxFileName.Text;
                    dialogResult = openFileDialog.ShowDialog();
                    fileName = openFileDialog.FileName;
                    break;

                case AutoCompleteSource.FileSystemDirectories:
                    folderBrowserDialog.SelectedPath = comboBoxFileName.Text;
                    dialogResult = folderBrowserDialog.ShowDialog();
                    fileName = folderBrowserDialog.SelectedPath;
                    break;

                default:
                    return;
            }

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            comboBoxFileName.Text = fileName;
        }

        private void comboBoxFileName_TextChanged(object sender, EventArgs e)
        {
            SelectedFileChanged(sender, e);
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop) as string[];

            if ((data == null) || (data.Length < 1))
            {
                return;
            }

            comboBoxFileName.Text = data[0];
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None);
        }
    }
}
