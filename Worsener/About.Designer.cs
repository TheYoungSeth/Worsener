
namespace Worsener
{
    partial class About
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
            this.youtube = new System.Windows.Forms.Button();
            this.patreon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // youtube
            // 
            this.youtube.Location = new System.Drawing.Point(59, 379);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(140, 37);
            this.youtube.TabIndex = 0;
            this.youtube.Text = "Youtube";
            this.youtube.UseVisualStyleBackColor = true;
            // 
            // patreon
            // 
            this.patreon.Location = new System.Drawing.Point(547, 379);
            this.patreon.Name = "patreon";
            this.patreon.Size = new System.Drawing.Size(140, 37);
            this.patreon.TabIndex = 1;
            this.patreon.Text = "Patreon";
            this.patreon.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 459);
            this.Controls.Add(this.patreon);
            this.Controls.Add(this.youtube);
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Me";
            this.Load += new System.EventHandler(this.about_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button youtube;
        private System.Windows.Forms.Button patreon;
    }
}