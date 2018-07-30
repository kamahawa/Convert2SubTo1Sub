namespace Add2Sub
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSubtitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainMovie = new System.Windows.Forms.Panel();
            this._lvSub = new System.Windows.Forms.ListView();
            this.sub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._wdmMovie = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelContainControl = new System.Windows.Forms.Panel();
            this._btnPrevious = new System.Windows.Forms.Button();
            this._btnPlayPause = new System.Windows.Forms.Button();
            this._btnNext = new System.Windows.Forms.Button();
            this._btnCurrent = new System.Windows.Forms.Button();
            this.convertSubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSubLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelContainMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._wdmMovie)).BeginInit();
            this.panelContainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMovieToolStripMenuItem,
            this.loadSubtitlesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadMovieToolStripMenuItem
            // 
            this.loadMovieToolStripMenuItem.Name = "loadMovieToolStripMenuItem";
            this.loadMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadMovieToolStripMenuItem.Text = "Load Movie";
            this.loadMovieToolStripMenuItem.Click += new System.EventHandler(this.loadMovieToolStripMenuItem_Click);
            // 
            // loadSubtitlesToolStripMenuItem
            // 
            this.loadSubtitlesToolStripMenuItem.Name = "loadSubtitlesToolStripMenuItem";
            this.loadSubtitlesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadSubtitlesToolStripMenuItem.Text = "Load Subtitles";
            this.loadSubtitlesToolStripMenuItem.Click += new System.EventHandler(this.loadSubtitlesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSubToolStripMenuItem,
            this.convertSubToolStripMenuItem,
            this.changeSubLoadToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // editSubToolStripMenuItem
            // 
            this.editSubToolStripMenuItem.Name = "editSubToolStripMenuItem";
            this.editSubToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editSubToolStripMenuItem.Text = "Edit Sub";
            this.editSubToolStripMenuItem.Click += new System.EventHandler(this.editSubToolStripMenuItem_Click);
            // 
            // panelContainMovie
            // 
            this.panelContainMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainMovie.Controls.Add(this._lvSub);
            this.panelContainMovie.Controls.Add(this._wdmMovie);
            this.panelContainMovie.Location = new System.Drawing.Point(0, 27);
            this.panelContainMovie.Name = "panelContainMovie";
            this.panelContainMovie.Size = new System.Drawing.Size(1104, 606);
            this.panelContainMovie.TabIndex = 1;
            // 
            // _lvSub
            // 
            this._lvSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvSub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sub});
            this._lvSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lvSub.Location = new System.Drawing.Point(669, 4);
            this._lvSub.Name = "_lvSub";
            this._lvSub.Size = new System.Drawing.Size(432, 599);
            this._lvSub.TabIndex = 1;
            this._lvSub.UseCompatibleStateImageBehavior = false;
            this._lvSub.View = System.Windows.Forms.View.Details;
            // 
            // sub
            // 
            this.sub.Text = "Subtitle";
            this.sub.Width = 430;
            // 
            // _wdmMovie
            // 
            this._wdmMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._wdmMovie.Enabled = true;
            this._wdmMovie.Location = new System.Drawing.Point(4, 4);
            this._wdmMovie.Name = "_wdmMovie";
            this._wdmMovie.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("_wdmMovie.OcxState")));
            this._wdmMovie.Size = new System.Drawing.Size(659, 599);
            this._wdmMovie.TabIndex = 0;
            // 
            // panelContainControl
            // 
            this.panelContainControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainControl.Controls.Add(this._btnPrevious);
            this.panelContainControl.Controls.Add(this._btnPlayPause);
            this.panelContainControl.Controls.Add(this._btnNext);
            this.panelContainControl.Controls.Add(this._btnCurrent);
            this.panelContainControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContainControl.Location = new System.Drawing.Point(0, 639);
            this.panelContainControl.Name = "panelContainControl";
            this.panelContainControl.Size = new System.Drawing.Size(1104, 74);
            this.panelContainControl.TabIndex = 2;
            // 
            // _btnPrevious
            // 
            this._btnPrevious.Location = new System.Drawing.Point(12, 13);
            this._btnPrevious.Name = "_btnPrevious";
            this._btnPrevious.Size = new System.Drawing.Size(141, 49);
            this._btnPrevious.TabIndex = 4;
            this._btnPrevious.Text = "Previous";
            this._btnPrevious.UseVisualStyleBackColor = true;
            // 
            // _btnPlayPause
            // 
            this._btnPlayPause.Location = new System.Drawing.Point(453, 13);
            this._btnPlayPause.Name = "_btnPlayPause";
            this._btnPlayPause.Size = new System.Drawing.Size(141, 49);
            this._btnPlayPause.TabIndex = 3;
            this._btnPlayPause.Text = "Play/Pause";
            this._btnPlayPause.UseVisualStyleBackColor = true;
            this._btnPlayPause.Click += new System.EventHandler(this._btnPlayPause_Click);
            // 
            // _btnNext
            // 
            this._btnNext.Location = new System.Drawing.Point(306, 13);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(141, 49);
            this._btnNext.TabIndex = 2;
            this._btnNext.Text = "Next";
            this._btnNext.UseVisualStyleBackColor = true;
            // 
            // _btnCurrent
            // 
            this._btnCurrent.Location = new System.Drawing.Point(159, 13);
            this._btnCurrent.Name = "_btnCurrent";
            this._btnCurrent.Size = new System.Drawing.Size(141, 49);
            this._btnCurrent.TabIndex = 1;
            this._btnCurrent.Text = "Current";
            this._btnCurrent.UseVisualStyleBackColor = true;
            // 
            // convertSubToolStripMenuItem
            // 
            this.convertSubToolStripMenuItem.Name = "convertSubToolStripMenuItem";
            this.convertSubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.convertSubToolStripMenuItem.Text = "Convert Sub";
            this.convertSubToolStripMenuItem.Click += new System.EventHandler(this.convertSubToolStripMenuItem_Click);
            // 
            // changeSubLoadToolStripMenuItem
            // 
            this.changeSubLoadToolStripMenuItem.Name = "changeSubLoadToolStripMenuItem";
            this.changeSubLoadToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.changeSubLoadToolStripMenuItem.Text = "Change Sub Load";
            this.changeSubLoadToolStripMenuItem.Click += new System.EventHandler(this.changeSubLoadToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 714);
            this.Controls.Add(this.panelContainControl);
            this.Controls.Add(this.panelContainMovie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContainMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._wdmMovie)).EndInit();
            this.panelContainControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSubToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainMovie;
        private System.Windows.Forms.Panel panelContainControl;
        private System.Windows.Forms.Button _btnPlayPause;
        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.Button _btnCurrent;
        private System.Windows.Forms.Button _btnPrevious;
        private System.Windows.Forms.ListView _lvSub;
        private AxWMPLib.AxWindowsMediaPlayer _wdmMovie;
        private System.Windows.Forms.ToolStripMenuItem loadMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSubtitlesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader sub;
        private System.Windows.Forms.ToolStripMenuItem convertSubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSubLoadToolStripMenuItem;
    }
}