namespace PFControls
{
    partial class FileSelector
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFileName = new System.Windows.Forms.ComboBox();
            this.buttonRefer = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Location = new System.Drawing.Point(3, 5);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFileName.TabIndex = 0;
            this.comboBoxFileName.TextChanged += new System.EventHandler(this.comboBoxFileName_TextChanged);
            // 
            // buttonRefer
            // 
            this.buttonRefer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRefer.Location = new System.Drawing.Point(130, 3);
            this.buttonRefer.Name = "buttonRefer";
            this.buttonRefer.Size = new System.Drawing.Size(75, 23);
            this.buttonRefer.TabIndex = 1;
            this.buttonRefer.Text = "参照(&R)";
            this.buttonRefer.UseVisualStyleBackColor = true;
            this.buttonRefer.Click += new System.EventHandler(this.buttonRefer_Click);
            // 
            // FileSelector
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonRefer);
            this.Controls.Add(this.comboBoxFileName);
            this.MaximumSize = new System.Drawing.Size(65535, 29);
            this.MinimumSize = new System.Drawing.Size(208, 29);
            this.Name = "FileSelector";
            this.Size = new System.Drawing.Size(208, 29);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFileName;
        private System.Windows.Forms.Button buttonRefer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
