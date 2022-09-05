
namespace ImageClassificationDecider
{
    partial class ImageClassificationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageClassificationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.howToPanel = new System.Windows.Forms.Panel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.howToExplanationLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHotkeyInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgressInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblActionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.howToPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1266, 890);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // howToPanel
            // 
            this.howToPanel.Controls.Add(this.btnSelectFolder);
            this.howToPanel.Controls.Add(this.howToExplanationLabel);
            this.howToPanel.Location = new System.Drawing.Point(9, 12);
            this.howToPanel.Name = "howToPanel";
            this.howToPanel.Size = new System.Drawing.Size(1228, 381);
            this.howToPanel.TabIndex = 7;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(95, 239);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(87, 32);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "HERE";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // howToExplanationLabel
            // 
            this.howToExplanationLabel.AutoSize = true;
            this.howToExplanationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.howToExplanationLabel.Location = new System.Drawing.Point(3, 12);
            this.howToExplanationLabel.Name = "howToExplanationLabel";
            this.howToExplanationLabel.Size = new System.Drawing.Size(1113, 288);
            this.howToExplanationLabel.TabIndex = 0;
            this.howToExplanationLabel.Text = resources.GetString("howToExplanationLabel.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHotkeyInfo,
            this.lblProgressInfo,
            this.lblActionInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 868);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1266, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHotkeyInfo
            // 
            this.lblHotkeyInfo.Name = "lblHotkeyInfo";
            this.lblHotkeyInfo.Size = new System.Drawing.Size(222, 17);
            this.lblHotkeyInfo.Text = "Hotkeys: 1 = bananas, 2 = apples (demo)";
            // 
            // lblProgressInfo
            // 
            this.lblProgressInfo.Name = "lblProgressInfo";
            this.lblProgressInfo.Size = new System.Drawing.Size(156, 17);
            this.lblProgressInfo.Text = "Progress: 80 files left (demo)";
            // 
            // lblActionInfo
            // 
            this.lblActionInfo.Name = "lblActionInfo";
            this.lblActionInfo.Size = new System.Drawing.Size(218, 17);
            this.lblActionInfo.Text = "1234.jpg moved to folder apples (demo)";
            // 
            // ImageClassificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 890);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.howToPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageClassificationForm";
            this.Text = "Quick Image Classifier for Deep Learning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.howToPanel.ResumeLayout(false);
            this.howToPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel howToPanel;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label howToExplanationLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHotkeyInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblActionInfo;
    }
}

