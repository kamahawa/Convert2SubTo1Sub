namespace Add2Sub
{
    partial class FrmTranslate
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
            this._txtEng = new System.Windows.Forms.TextBox();
            this._txtViet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnTranslate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtEng
            // 
            this._txtEng.Location = new System.Drawing.Point(2, 3);
            this._txtEng.Multiline = true;
            this._txtEng.Name = "_txtEng";
            this._txtEng.Size = new System.Drawing.Size(571, 626);
            this._txtEng.TabIndex = 0;
            // 
            // _txtViet
            // 
            this._txtViet.Location = new System.Drawing.Point(579, 3);
            this._txtViet.Multiline = true;
            this._txtViet.Name = "_txtViet";
            this._txtViet.Size = new System.Drawing.Size(571, 626);
            this._txtViet.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnTranslate);
            this.panel1.Location = new System.Drawing.Point(2, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 55);
            this.panel1.TabIndex = 2;
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Location = new System.Drawing.Point(474, 3);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(198, 49);
            this._btnTranslate.TabIndex = 0;
            this._btnTranslate.Text = "Load File And Translate";
            this._btnTranslate.UseVisualStyleBackColor = true;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // FrmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._txtViet);
            this.Controls.Add(this._txtEng);
            this.Name = "FrmTranslate";
            this.Text = "FrmTranslate";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtEng;
        private System.Windows.Forms.TextBox _txtViet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnTranslate;
    }
}