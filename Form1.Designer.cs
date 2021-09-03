
namespace PhantomRebels
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnFixBrowser = new System.Windows.Forms.Button();
            this.btnResetCache = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSteam = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRevert
            // 
            this.btnRevert.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRevert.Location = new System.Drawing.Point(12, 96);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(242, 36);
            this.btnRevert.TabIndex = 0;
            this.btnRevert.Text = "ERASE ALL SETTINGS (Revert to first run)";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnFixBrowser
            // 
            this.btnFixBrowser.Location = new System.Drawing.Point(12, 54);
            this.btnFixBrowser.Name = "btnFixBrowser";
            this.btnFixBrowser.Size = new System.Drawing.Size(242, 36);
            this.btnFixBrowser.TabIndex = 1;
            this.btnFixBrowser.Text = "FIX SERVER BROWSER";
            this.btnFixBrowser.UseVisualStyleBackColor = true;
            this.btnFixBrowser.Click += new System.EventHandler(this.btnFixBrowser_Click);
            // 
            // btnResetCache
            // 
            this.btnResetCache.Location = new System.Drawing.Point(12, 12);
            this.btnResetCache.Name = "btnResetCache";
            this.btnResetCache.Size = new System.Drawing.Size(242, 36);
            this.btnResetCache.TabIndex = 2;
            this.btnResetCache.Text = "RESET CACHE";
            this.btnResetCache.UseVisualStyleBackColor = true;
            this.btnResetCache.Click += new System.EventHandler(this.btnResetCache_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(151, 151);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© 2021 PhantomRebels.com. All Rights Reserved.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(151, 135);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(243, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Brought to you by MadMax@PhantomRebels.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(260, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(260, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 36);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSteam);
            this.groupBox1.Controls.Add(this.radNormal);
            this.groupBox1.Location = new System.Drawing.Point(306, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Version";
            // 
            // radSteam
            // 
            this.radSteam.AutoSize = true;
            this.radSteam.Location = new System.Drawing.Point(6, 42);
            this.radSteam.Name = "radSteam";
            this.radSteam.Size = new System.Drawing.Size(55, 17);
            this.radSteam.TabIndex = 3;
            this.radSteam.Text = "Steam";
            this.radSteam.UseVisualStyleBackColor = true;
            this.radSteam.CheckedChanged += new System.EventHandler(this.radSteam_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Checked = true;
            this.radNormal.Location = new System.Drawing.Point(6, 19);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(46, 17);
            this.radNormal.TabIndex = 2;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Epic";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnResetCache);
            this.Controls.Add(this.btnFixBrowser);
            this.Controls.Add(this.btnRevert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rising Storm 2: Vietnam - Client Fixer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnFixBrowser;
        private System.Windows.Forms.Button btnResetCache;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSteam;
        private System.Windows.Forms.RadioButton radNormal;
    }
}

