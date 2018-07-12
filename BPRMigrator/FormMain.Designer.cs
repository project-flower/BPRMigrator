namespace BPRMigrator
{
    partial class FormMain
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Source");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.fileSelector = new PFControls.FileSelector();
            this.checkBoxExcludeBpfFile = new System.Windows.Forms.CheckBox();
            this.checkBoxExcludeResFile = new System.Windows.Forms.CheckBox();
            this.buttonCopyLibPath = new System.Windows.Forms.Button();
            this.textBoxLibPath = new System.Windows.Forms.TextBox();
            this.labelLibPath = new System.Windows.Forms.Label();
            this.buttonCopyIncludePath = new System.Windows.Forms.Button();
            this.textBoxIncludePath = new System.Windows.Forms.TextBox();
            this.labelIncluePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            listViewItem1.StateImageIndex = 0;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView.Location = new System.Drawing.Point(12, 47);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 289);
            this.listView.StateImageList = this.imageList;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_ItemDrag);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "BPRMigrator.ico");
            // 
            // fileSelector
            // 
            this.fileSelector.AllowDrop = true;
            this.fileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.fileSelector.ButtonFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileSelector.ButtonText = "参照(&R)";
            this.fileSelector.ComboBoxFont = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileSelector.Location = new System.Drawing.Point(12, 12);
            this.fileSelector.MaximumSize = new System.Drawing.Size(65535, 29);
            this.fileSelector.MinimumSize = new System.Drawing.Size(208, 29);
            this.fileSelector.Name = "fileSelector";
            this.fileSelector.SelectedFile = "";
            this.fileSelector.Size = new System.Drawing.Size(776, 29);
            this.fileSelector.TabIndex = 0;
            this.fileSelector.SelectedFileChanged += new System.EventHandler(this.fileSelector_SelectedFileChanged);
            // 
            // checkBoxExcludeBpfFile
            // 
            this.checkBoxExcludeBpfFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxExcludeBpfFile.AutoSize = true;
            this.checkBoxExcludeBpfFile.Checked = true;
            this.checkBoxExcludeBpfFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExcludeBpfFile.Location = new System.Drawing.Point(12, 342);
            this.checkBoxExcludeBpfFile.Name = "checkBoxExcludeBpfFile";
            this.checkBoxExcludeBpfFile.Size = new System.Drawing.Size(79, 16);
            this.checkBoxExcludeBpfFile.TabIndex = 2;
            this.checkBoxExcludeBpfFile.Text = ".&bpf を除外";
            this.checkBoxExcludeBpfFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcludeResFile
            // 
            this.checkBoxExcludeResFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxExcludeResFile.AutoSize = true;
            this.checkBoxExcludeResFile.Checked = true;
            this.checkBoxExcludeResFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExcludeResFile.Location = new System.Drawing.Point(12, 364);
            this.checkBoxExcludeResFile.Name = "checkBoxExcludeResFile";
            this.checkBoxExcludeResFile.Size = new System.Drawing.Size(79, 16);
            this.checkBoxExcludeResFile.TabIndex = 3;
            this.checkBoxExcludeResFile.Text = ".&res を除外";
            this.checkBoxExcludeResFile.UseVisualStyleBackColor = true;
            // 
            // buttonCopyLibPath
            // 
            this.buttonCopyLibPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyLibPath.Location = new System.Drawing.Point(713, 415);
            this.buttonCopyLibPath.Name = "buttonCopyLibPath";
            this.buttonCopyLibPath.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyLibPath.TabIndex = 13;
            this.buttonCopyLibPath.Text = "コピー";
            this.buttonCopyLibPath.UseVisualStyleBackColor = true;
            this.buttonCopyLibPath.Click += new System.EventHandler(this.buttonCopyLibPath_Click);
            // 
            // textBoxLibPath
            // 
            this.textBoxLibPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLibPath.Location = new System.Drawing.Point(88, 417);
            this.textBoxLibPath.Name = "textBoxLibPath";
            this.textBoxLibPath.ReadOnly = true;
            this.textBoxLibPath.Size = new System.Drawing.Size(619, 19);
            this.textBoxLibPath.TabIndex = 12;
            // 
            // labelLibPath
            // 
            this.labelLibPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLibPath.AutoSize = true;
            this.labelLibPath.Location = new System.Drawing.Point(12, 420);
            this.labelLibPath.Name = "labelLibPath";
            this.labelLibPath.Size = new System.Drawing.Size(49, 12);
            this.labelLibPath.TabIndex = 11;
            this.labelLibPath.Text = "&Lib Path:";
            // 
            // buttonCopyIncludePath
            // 
            this.buttonCopyIncludePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyIncludePath.Location = new System.Drawing.Point(713, 386);
            this.buttonCopyIncludePath.Name = "buttonCopyIncludePath";
            this.buttonCopyIncludePath.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyIncludePath.TabIndex = 10;
            this.buttonCopyIncludePath.Text = "コピー";
            this.buttonCopyIncludePath.UseVisualStyleBackColor = true;
            this.buttonCopyIncludePath.Click += new System.EventHandler(this.buttonCopyIncludePath_Click);
            // 
            // textBoxIncludePath
            // 
            this.textBoxIncludePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIncludePath.Location = new System.Drawing.Point(88, 388);
            this.textBoxIncludePath.Name = "textBoxIncludePath";
            this.textBoxIncludePath.ReadOnly = true;
            this.textBoxIncludePath.Size = new System.Drawing.Size(619, 19);
            this.textBoxIncludePath.TabIndex = 9;
            // 
            // labelIncluePath
            // 
            this.labelIncluePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIncluePath.AutoSize = true;
            this.labelIncluePath.Location = new System.Drawing.Point(12, 391);
            this.labelIncluePath.Name = "labelIncluePath";
            this.labelIncluePath.Size = new System.Drawing.Size(70, 12);
            this.labelIncluePath.TabIndex = 8;
            this.labelIncluePath.Text = "&Include Path:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCopyLibPath);
            this.Controls.Add(this.textBoxLibPath);
            this.Controls.Add(this.labelLibPath);
            this.Controls.Add(this.buttonCopyIncludePath);
            this.Controls.Add(this.textBoxIncludePath);
            this.Controls.Add(this.labelIncluePath);
            this.Controls.Add(this.checkBoxExcludeResFile);
            this.Controls.Add(this.checkBoxExcludeBpfFile);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.fileSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "BPR Migrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PFControls.FileSelector fileSelector;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox checkBoxExcludeBpfFile;
        private System.Windows.Forms.CheckBox checkBoxExcludeResFile;
        private System.Windows.Forms.Button buttonCopyLibPath;
        private System.Windows.Forms.TextBox textBoxLibPath;
        private System.Windows.Forms.Label labelLibPath;
        private System.Windows.Forms.Button buttonCopyIncludePath;
        private System.Windows.Forms.TextBox textBoxIncludePath;
        private System.Windows.Forms.Label labelIncluePath;
    }
}

