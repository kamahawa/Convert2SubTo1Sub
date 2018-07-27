namespace Add2Sub
{
    partial class FrmEditSub
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
            this.txtEngsub = new System.Windows.Forms.TextBox();
            this.txtVietsub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadEngsub = new System.Windows.Forms.Button();
            this.btnLoadVietsub = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEngsub
            // 
            this.txtEngsub.Location = new System.Drawing.Point(13, 34);
            this.txtEngsub.Multiline = true;
            this.txtEngsub.Name = "txtEngsub";
            this.txtEngsub.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEngsub.Size = new System.Drawing.Size(553, 418);
            this.txtEngsub.TabIndex = 0;
            // 
            // txtVietsub
            // 
            this.txtVietsub.Location = new System.Drawing.Point(590, 34);
            this.txtVietsub.Multiline = true;
            this.txtVietsub.Name = "txtVietsub";
            this.txtVietsub.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVietsub.Size = new System.Drawing.Size(518, 418);
            this.txtVietsub.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Engsub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vietsub";
            // 
            // btnLoadEngsub
            // 
            this.btnLoadEngsub.Location = new System.Drawing.Point(82, 5);
            this.btnLoadEngsub.Name = "btnLoadEngsub";
            this.btnLoadEngsub.Size = new System.Drawing.Size(89, 23);
            this.btnLoadEngsub.TabIndex = 4;
            this.btnLoadEngsub.Text = "Load Engsub";
            this.btnLoadEngsub.UseVisualStyleBackColor = true;
            this.btnLoadEngsub.Click += new System.EventHandler(this.btnLoadEngsub_Click);
            // 
            // btnLoadVietsub
            // 
            this.btnLoadVietsub.Location = new System.Drawing.Point(648, 5);
            this.btnLoadVietsub.Name = "btnLoadVietsub";
            this.btnLoadVietsub.Size = new System.Drawing.Size(97, 23);
            this.btnLoadVietsub.TabIndex = 5;
            this.btnLoadVietsub.Text = "Load Vietsub";
            this.btnLoadVietsub.UseVisualStyleBackColor = true;
            this.btnLoadVietsub.Click += new System.EventHandler(this.btnLoadVietsub_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(16, 513);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(75, 23);
            this.btnProgress.TabIndex = 6;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 476);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(347, 479);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(761, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title : ";
            // 
            // FrmEditSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnLoadVietsub);
            this.Controls.Add(this.btnLoadEngsub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVietsub);
            this.Controls.Add(this.txtEngsub);
            this.Name = "FrmEditSub";
            this.Text = "Edit Subsence";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEngsub;
        private System.Windows.Forms.TextBox txtVietsub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadEngsub;
        private System.Windows.Forms.Button btnLoadVietsub;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
    }
}

