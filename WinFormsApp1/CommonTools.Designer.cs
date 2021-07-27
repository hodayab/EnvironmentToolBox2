
namespace WinFormsApp1
{
    partial class CommonTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonTools));
            this.button_openSpooky = new System.Windows.Forms.Button();
            this.button_devTool = new System.Windows.Forms.Button();
            this.button_office = new System.Windows.Forms.Button();
            this.button_tfs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_openSpooky
            // 
            this.button_openSpooky.Image = global::WinFormsApp1.Properties.Resources.spooky;
            this.button_openSpooky.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_openSpooky.Location = new System.Drawing.Point(42, 32);
            this.button_openSpooky.Name = "button_openSpooky";
            this.button_openSpooky.Size = new System.Drawing.Size(108, 142);
            this.button_openSpooky.TabIndex = 0;
            this.button_openSpooky.Text = "Spooky";
            this.button_openSpooky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_openSpooky.UseVisualStyleBackColor = true;
            this.button_openSpooky.Click += new System.EventHandler(this.button_openSpooky_Click);
            // 
            // button_devTool
            // 
            this.button_devTool.Image = ((System.Drawing.Image)(resources.GetObject("button_devTool.Image")));
            this.button_devTool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_devTool.Location = new System.Drawing.Point(194, 32);
            this.button_devTool.Name = "button_devTool";
            this.button_devTool.Size = new System.Drawing.Size(110, 142);
            this.button_devTool.TabIndex = 1;
            this.button_devTool.Text = "Developer Tool";
            this.button_devTool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_devTool.UseVisualStyleBackColor = true;
            this.button_devTool.Click += new System.EventHandler(this.button_devTool_Click);
            // 
            // button_office
            // 
            this.button_office.Image = global::WinFormsApp1.Properties.Resources.office;
            this.button_office.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_office.Location = new System.Drawing.Point(340, 32);
            this.button_office.Name = "button_office";
            this.button_office.Size = new System.Drawing.Size(110, 142);
            this.button_office.TabIndex = 2;
            this.button_office.Text = "Office";
            this.button_office.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_office.UseVisualStyleBackColor = true;
            this.button_office.Click += new System.EventHandler(this.button_office_Click);
            // 
            // button_tfs
            // 
            this.button_tfs.Image = global::WinFormsApp1.Properties.Resources.tfs;
            this.button_tfs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_tfs.Location = new System.Drawing.Point(42, 202);
            this.button_tfs.Name = "button_tfs";
            this.button_tfs.Size = new System.Drawing.Size(110, 142);
            this.button_tfs.TabIndex = 3;
            this.button_tfs.Text = "Tfs";
            this.button_tfs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_tfs.UseVisualStyleBackColor = true;
            this.button_tfs.Click += new System.EventHandler(this.button_tfs_Click);
            // 
            // CommonTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 407);
            this.Controls.Add(this.button_tfs);
            this.Controls.Add(this.button_office);
            this.Controls.Add(this.button_devTool);
            this.Controls.Add(this.button_openSpooky);
            this.Name = "CommonTools";
            this.Text = "Common Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_openSpooky;
        private System.Windows.Forms.Button button_devTool;
        private System.Windows.Forms.Button button_office;
        private System.Windows.Forms.Button button_tfs;
    }
}