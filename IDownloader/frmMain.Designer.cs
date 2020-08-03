namespace IDownloader
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.downloadBtn = new MaterialSkin.Controls.MaterialButton();
            this.gvVideos = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.videoNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchtxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseBtn = new MaterialSkin.Controls.MaterialButton();
            this.qualityComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadBtn
            // 
            this.downloadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadBtn.Depth = 0;
            this.downloadBtn.DrawShadows = true;
            this.downloadBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.HighEmphasis = true;
            this.downloadBtn.Icon = ((System.Drawing.Image)(resources.GetObject("downloadBtn.Icon")));
            this.downloadBtn.Location = new System.Drawing.Point(395, 120);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.downloadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(150, 36);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = " Get Playlist";
            this.downloadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.downloadBtn.UseAccentColor = false;
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // gvVideos
            // 
            this.gvVideos.AllowUserToAddRows = false;
            this.gvVideos.AllowUserToDeleteRows = false;
            this.gvVideos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvVideos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvVideos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvVideos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCol,
            this.selectCol,
            this.videoNameCol,
            this.statusCol,
            this.sizeCol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvVideos.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvVideos.Location = new System.Drawing.Point(12, 165);
            this.gvVideos.Name = "gvVideos";
            this.gvVideos.Size = new System.Drawing.Size(876, 286);
            this.gvVideos.TabIndex = 2;
            // 
            // numCol
            // 
            this.numCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numCol.HeaderText = "No.";
            this.numCol.MinimumWidth = 30;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 30;
            // 
            // selectCol
            // 
            this.selectCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.selectCol.HeaderText = "Select";
            this.selectCol.MinimumWidth = 45;
            this.selectCol.Name = "selectCol";
            this.selectCol.Width = 45;
            // 
            // videoNameCol
            // 
            this.videoNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.videoNameCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.videoNameCol.HeaderText = "Video Name";
            this.videoNameCol.MinimumWidth = 500;
            this.videoNameCol.Name = "videoNameCol";
            this.videoNameCol.ReadOnly = true;
            this.videoNameCol.Width = 500;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.statusCol.HeaderText = "Status";
            this.statusCol.MinimumWidth = 190;
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Width = 190;
            // 
            // sizeCol
            // 
            this.sizeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeCol.HeaderText = "Size";
            this.sizeCol.MinimumWidth = 50;
            this.sizeCol.Name = "sizeCol";
            this.sizeCol.ReadOnly = true;
            this.sizeCol.Width = 50;
            // 
            // searchtxtBox
            // 
            this.searchtxtBox.AccessibleDescription = "";
            this.searchtxtBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxtBox.ForeColor = System.Drawing.Color.Silver;
            this.searchtxtBox.Location = new System.Drawing.Point(12, 80);
            this.searchtxtBox.Name = "searchtxtBox";
            this.searchtxtBox.Size = new System.Drawing.Size(734, 31);
            this.searchtxtBox.TabIndex = 3;
            this.searchtxtBox.Tag = "";
            this.searchtxtBox.Text = "Paste Playlist URL...";
            this.searchtxtBox.Enter += new System.EventHandler(this.searchtxtBox_Enter);
            this.searchtxtBox.Leave += new System.EventHandler(this.searchtxtBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseBtn.Depth = 0;
            this.browseBtn.DrawShadows = true;
            this.browseBtn.HighEmphasis = true;
            this.browseBtn.Icon = ((System.Drawing.Image)(resources.GetObject("browseBtn.Icon")));
            this.browseBtn.Location = new System.Drawing.Point(843, 77);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.browseBtn.MaximumSize = new System.Drawing.Size(22, 22);
            this.browseBtn.MinimumSize = new System.Drawing.Size(45, 35);
            this.browseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(45, 35);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.browseBtn.UseAccentColor = false;
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // qualityComboBox
            // 
            this.qualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityComboBox.FormattingEnabled = true;
            this.qualityComboBox.Location = new System.Drawing.Point(758, 84);
            this.qualityComboBox.Name = "qualityComboBox";
            this.qualityComboBox.Size = new System.Drawing.Size(71, 21);
            this.qualityComboBox.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(12, 465);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseBtn.BackgroundImage")));
            this.pauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseBtn.Location = new System.Drawing.Point(12, 129);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(29, 27);
            this.pauseBtn.TabIndex = 9;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Visible = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // resumeBtn
            // 
            this.resumeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resumeBtn.BackgroundImage")));
            this.resumeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resumeBtn.Location = new System.Drawing.Point(47, 129);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(29, 27);
            this.resumeBtn.TabIndex = 10;
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Visible = false;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.qualityComboBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchtxtBox);
            this.Controls.Add(this.gvVideos);
            this.Controls.Add(this.downloadBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDownloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton downloadBtn;
        private System.Windows.Forms.DataGridView gvVideos;
        private System.Windows.Forms.TextBox searchtxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton browseBtn;
        private System.Windows.Forms.ComboBox qualityComboBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeCol;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button resumeBtn;
    }
}

