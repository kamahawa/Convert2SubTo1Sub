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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._btnProgress = new System.Windows.Forms.Button();
            this._txtSub = new System.Windows.Forms.TextBox();
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
            this.columnHeader1});
            this._lvSub.FullRowSelect = true;
            this._lvSub.Location = new System.Drawing.Point(12, 41);
            this._lvSub.Name = "_lvSub";
            this._lvSub.Size = new System.Drawing.Size(752, 744);
            this._lvSub.TabIndex = 1;
            this._lvSub.UseCompatibleStateImageBehavior = false;
            this._lvSub.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sub";
            this.columnHeader1.Width = 674;
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
            // _txtSub
            // 
            this._txtSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtSub.Location = new System.Drawing.Point(780, 41);
            this._txtSub.Multiline = true;
            this._txtSub.Name = "_txtSub";
            this._txtSub.Size = new System.Drawing.Size(761, 744);
            this._txtSub.TabIndex = 2;
            // 
            // Convert2SubTo1Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 797);
            this.Controls.Add(this._txtSub);
            this.Controls.Add(this._lvSub);
            this.Controls.Add(this._btnProgress);
            this.Controls.Add(this._btnLoadVietSub);
            this.Controls.Add(this._btnLoadEngSub);
            this.Name = "Convert2SubTo1Sub";
            this.Text = "Convert2SubTo1Sub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLoadEngSub;
        private System.Windows.Forms.Button _btnLoadVietSub;
        private System.Windows.Forms.ListView _lvSub;
        private System.Windows.Forms.Button _btnProgress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox _txtSub;
    }
}