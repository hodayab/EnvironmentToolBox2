
namespace WinFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_openQueries = new System.Windows.Forms.Button();
            this.button_openGetVersion = new System.Windows.Forms.Button();
            this.button_openCommonTools = new System.Windows.Forms.Button();
            this.button_openConfiguration = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_openQueries
            // 
            this.button_openQueries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_openQueries.Image = global::WinFormsApp1.Properties.Resources.icons8_database_100;
            this.button_openQueries.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_openQueries.Location = new System.Drawing.Point(47, 81);
            this.button_openQueries.Name = "button_openQueries";
            this.button_openQueries.Size = new System.Drawing.Size(135, 135);
            this.button_openQueries.TabIndex = 0;
            this.button_openQueries.Text = "Queries";
            this.button_openQueries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_openQueries.UseVisualStyleBackColor = true;
            this.button_openQueries.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_openGetVersion
            // 
            this.button_openGetVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_openGetVersion.Image = ((System.Drawing.Image)(resources.GetObject("button_openGetVersion.Image")));
            this.button_openGetVersion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_openGetVersion.Location = new System.Drawing.Point(219, 81);
            this.button_openGetVersion.Name = "button_openGetVersion";
            this.button_openGetVersion.Size = new System.Drawing.Size(135, 135);
            this.button_openGetVersion.TabIndex = 1;
            this.button_openGetVersion.Text = "Get code version";
            this.button_openGetVersion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_openGetVersion.UseVisualStyleBackColor = true;
            // 
            // button_openCommonTools
            // 
            this.button_openCommonTools.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_openCommonTools.Image = ((System.Drawing.Image)(resources.GetObject("button_openCommonTools.Image")));
            this.button_openCommonTools.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_openCommonTools.Location = new System.Drawing.Point(404, 81);
            this.button_openCommonTools.Name = "button_openCommonTools";
            this.button_openCommonTools.Size = new System.Drawing.Size(135, 135);
            this.button_openCommonTools.TabIndex = 2;
            this.button_openCommonTools.Text = "Common tools";
            this.button_openCommonTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_openCommonTools.UseVisualStyleBackColor = true;
            this.button_openCommonTools.Click += new System.EventHandler(this.button_openCommonTools_Click);
            // 
            // button_openConfiguration
            // 
            this.button_openConfiguration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_openConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("button_openConfiguration.Image")));
            this.button_openConfiguration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_openConfiguration.Location = new System.Drawing.Point(572, 81);
            this.button_openConfiguration.Name = "button_openConfiguration";
            this.button_openConfiguration.Size = new System.Drawing.Size(135, 135);
            this.button_openConfiguration.TabIndex = 3;
            this.button_openConfiguration.Text = "Configurations";
            this.button_openConfiguration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_openConfiguration.UseVisualStyleBackColor = true;
            // 
            // button_log
            // 
            this.button_log.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_log.Image = ((System.Drawing.Image)(resources.GetObject("button_log.Image")));
            this.button_log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_log.Location = new System.Drawing.Point(749, 81);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(135, 135);
            this.button_log.TabIndex = 4;
            this.button_log.Text = "Logs";
            this.button_log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(766, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 135);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect to PulseSecure";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConnectToPulseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 315);
            this.Controls.Add(this.button_log);
            this.ClientSize = new System.Drawing.Size(988, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_openConfiguration);
            this.Controls.Add(this.button_openCommonTools);
            this.Controls.Add(this.button_openGetVersion);
            this.Controls.Add(this.button_openQueries);
            this.Name = "Main";
            this.Text = "Environment ToolBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_openQueries;
        private System.Windows.Forms.Button button_openGetVersion;
        private System.Windows.Forms.Button button_openCommonTools;
        private System.Windows.Forms.Button button_openConfiguration;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button1;
    }
}

