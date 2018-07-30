namespace Add2Sub
{
    partial class Convert2SubTo1Sub
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
            this._btnLoadEngSub = new System.Windows.Forms.Button();
            this._btnLoadVietSub = new System.Windows.Forms.Button();
            this._lvSub = new System.Windows.Forms.ListView();
            this.EngSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VietSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._btnProgress = new System.Windows.Forms.Button();
            this._lv2Sub = new System.Windows.Forms.ListView();
            this._pbSub = new System.Windows.Forms.ProgressBar();
            this._btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnLoadEngSub
            // 
            this._btnLoadEngSub.Location = new System.Drawing.Point(12, 12);
            this._btnLoadEngSub.Name = "_btnLoadEngSub";
            this._btnLoadEngSub.Size = new System.Drawing.Size(123, 23);
            this._btnLoadEngSub.TabIndex = 0;
            this._btnLoadEngSub.Text = "Load Eng sub";
            this._btnLoadEngSub.UseVisualStyleBackColor = true;
            this._btnLoadEngSub.Click += new System.EventHandler(this._btnLoadEngSub_Click);
            // 
            // _btnLoadVietSub
            // 
            this._btnLoadVietSub.Location = new System.Drawing.Point(141, 12);
            this._btnLoadVietSub.Name = "_btnLoadVietSub";
            this._btnLoadVietSub.Size = new System.Drawing.Size(134, 23);
            this._btnLoadVietSub.TabIndex = 0;
            this._btnLoadVietSub.Text = "Load Viet sub";
            this._btnLoadVietSub.UseVisualStyleBackColor = true;
            this._btnLoadVietSub.Click += new System.EventHandler(this._btnLoadVietSub_Click);
            // 
            // _lvSub
            // 
            this._lvSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvSub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EngSub,
            this.VietSub});
            this._lvSub.FullRowSelect = true;
            this._lvSub.Location = new System.Drawing.Point(12, 41);
            this._lvSub.Name = "_lvSub";
            this._lvSub.Size = new System.Drawing.Size(569, 696);
            this._lvSub.TabIndex = 1;
            this._lvSub.UseCompatibleStateImageBehavior = false;
            this._lvSub.View = System.Windows.Forms.View.Details;
            // 
            // EngSub
            // 
            this.EngSub.Text = "EngSub";
            this.EngSub.Width = 674;
            // 
            // VietSub
            // 
            this.VietSub.Text = "VietSub";
            // 
            // _btnProgress
            // 
            this._btnProgress.Location = new System.Drawing.Point(281, 12);
            this._btnProgress.Name = "_btnProgress";
            this._btnProgress.Size = new System.Drawing.Size(134, 23);
            this._btnProgress.TabIndex = 0;
            this._btnProgress.Text = "Progress sub";
            this._btnProgress.UseVisualStyleBackColor = true;
            this._btnProgress.Click += new System.EventHandler(this._btnProgress_Click);
            // 
            // _lv2Sub
            // 
            this._lv2Sub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lv2Sub.Location = new System.Drawing.Point(587, 41);
            this._lv2Sub.Name = "_lv2Sub";
            this._lv2Sub.Size = new System.Drawing.Size(771, 696);
            this._lv2Sub.TabIndex = 2;
            this._lv2Sub.UseCompatibleStateImageBehavior = false;
            this._lv2Sub.View = System.Windows.Forms.View.List;
            // 
            // _pbSub
            // 
            this._pbSub.Location = new System.Drawing.Point(444, 11);
            this._pbSub.Name = "_pbSub";
            this._pbSub.Size = new System.Drawing.Size(256, 23);
            this._pbSub.TabIndex = 3;
            // 
            // _btnExport
            // 
            this._btnExport.Location = new System.Drawing.Point(741, 11);
            this._btnExport.Name = "_btnExport";
            this._btnExport.Size = new System.Drawing.Size(177, 23);
            this._btnExport.TabIndex = 4;
            this._btnExport.Text = "Export";
            this._btnExport.UseVisualStyleBackColor = true;
            this._btnExport.Click += new System.EventHandler(this._btnExport_Click);
            // 
            // Convert2SubTo1Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this._btnExport);
            this.Controls.Add(this._pbSub);
            this.Controls.Add(this._lv2Sub);
            this.Controls.Add(this._lvSub);
            this.Controls.Add(this._btnProgress);
            this.Controls.Add(this._btnLoadVietSub);
            this.Controls.Add(this._btnLoadEngSub);
            this.Name = "Convert2SubTo1Sub";
            this.Text = "Convert2SubTo1Sub";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnLoadEngSub;
        private System.Windows.Forms.Button _btnLoadVietSub;
        private System.Windows.Forms.ListView _lvSub;
        private System.Windows.Forms.Button _btnProgress;
        private System.Windows.Forms.ColumnHeader EngSub;
        private System.Windows.Forms.ColumnHeader VietSub;
        private System.Windows.Forms.ListView _lv2Sub;
        private System.Windows.Forms.ProgressBar _pbSub;
        private System.Windows.Forms.Button _btnExport;
    }
}