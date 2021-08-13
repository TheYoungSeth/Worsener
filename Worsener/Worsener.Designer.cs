using System;

namespace Worsener {
    partial class Worsener {

        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worsener));
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fps_box = new System.Windows.Forms.TextBox();
            this.fps_label = new System.Windows.Forms.Label();
            this.fps = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.audio_bitrate_box = new System.Windows.Forms.TextBox();
            this.audio_bitrate_label = new System.Windows.Forms.Label();
            this.audio_bitrate = new System.Windows.Forms.TrackBar();
            this.bitrate_warning = new System.Windows.Forms.Label();
            this.bitrate_box = new System.Windows.Forms.TextBox();
            this.bitrate_label = new System.Windows.Forms.Label();
            this.bitrate = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.output_button = new System.Windows.Forms.Button();
            this.output_box = new System.Windows.Forms.TextBox();
            this.input_button = new System.Windows.Forms.Button();
            this.input_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio_bitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.start.Location = new System.Drawing.Point(332, 986);
            this.start.Margin = new System.Windows.Forms.Padding(5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(260, 47);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.width);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fps_box);
            this.panel1.Controls.Add(this.fps_label);
            this.panel1.Controls.Add(this.fps);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.audio_bitrate_box);
            this.panel1.Controls.Add(this.audio_bitrate_label);
            this.panel1.Controls.Add(this.audio_bitrate);
            this.panel1.Controls.Add(this.bitrate_warning);
            this.panel1.Controls.Add(this.bitrate_box);
            this.panel1.Controls.Add(this.bitrate_label);
            this.panel1.Controls.Add(this.bitrate);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.output_button);
            this.panel1.Controls.Add(this.output_box);
            this.panel1.Controls.Add(this.input_button);
            this.panel1.Controls.Add(this.input_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.start);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 1095);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 813);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "leave blank or 0 if you don\'t want to override it.";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.height.Location = new System.Drawing.Point(168, 823);
            this.height.MaxLength = 4;
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 30);
            this.height.TabIndex = 24;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.width.Location = new System.Drawing.Point(168, 789);
            this.width.MaxLength = 4;
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 30);
            this.width.TabIndex = 23;
            this.width.TextChanged += new System.EventHandler(this.width_TextChanged);
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.width_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(79, 826);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(79, 792);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 753);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Resolution:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "leave blank or 0 if you don\'t want to override it.";
            // 
            // fps_box
            // 
            this.fps_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fps_box.Location = new System.Drawing.Point(84, 694);
            this.fps_box.MaxLength = 3;
            this.fps_box.Name = "fps_box";
            this.fps_box.Size = new System.Drawing.Size(160, 35);
            this.fps_box.TabIndex = 18;
            this.fps_box.TextChanged += new System.EventHandler(this.fps_box_TextChanged);
            this.fps_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fps_box_KeyPress);
            // 
            // fps_label
            // 
            this.fps_label.AutoSize = true;
            this.fps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fps_label.Location = new System.Drawing.Point(12, 697);
            this.fps_label.Name = "fps_label";
            this.fps_label.Size = new System.Drawing.Size(66, 29);
            this.fps_label.TabIndex = 17;
            this.fps_label.Text = "FPS:";
            // 
            // fps
            // 
            this.fps.Location = new System.Drawing.Point(12, 657);
            this.fps.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(889, 69);
            this.fps.TabIndex = 16;
            this.fps.Scroll += new System.EventHandler(this.fps_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "leave blank or 0 if you don\'t want to override it.";
            // 
            // audio_bitrate_box
            // 
            this.audio_bitrate_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.audio_bitrate_box.Location = new System.Drawing.Point(168, 599);
            this.audio_bitrate_box.MaxLength = 4;
            this.audio_bitrate_box.Name = "audio_bitrate_box";
            this.audio_bitrate_box.Size = new System.Drawing.Size(160, 35);
            this.audio_bitrate_box.TabIndex = 14;
            this.audio_bitrate_box.TextChanged += new System.EventHandler(this.audio_bitrate_box_TextChanged);
            this.audio_bitrate_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.audio_bitrate_box_KeyPress);
            // 
            // audio_bitrate_label
            // 
            this.audio_bitrate_label.AutoSize = true;
            this.audio_bitrate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.audio_bitrate_label.Location = new System.Drawing.Point(12, 602);
            this.audio_bitrate_label.Name = "audio_bitrate_label";
            this.audio_bitrate_label.Size = new System.Drawing.Size(162, 29);
            this.audio_bitrate_label.TabIndex = 13;
            this.audio_bitrate_label.Text = "Audio Bitrate: ";
            // 
            // audio_bitrate
            // 
            this.audio_bitrate.Location = new System.Drawing.Point(12, 562);
            this.audio_bitrate.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.audio_bitrate.Name = "audio_bitrate";
            this.audio_bitrate.Size = new System.Drawing.Size(889, 69);
            this.audio_bitrate.TabIndex = 12;
            this.audio_bitrate.Scroll += new System.EventHandler(this.audio_bitrate_Scroll);
            // 
            // bitrate_warning
            // 
            this.bitrate_warning.AutoSize = true;
            this.bitrate_warning.Location = new System.Drawing.Point(334, 514);
            this.bitrate_warning.Name = "bitrate_warning";
            this.bitrate_warning.Size = new System.Drawing.Size(331, 20);
            this.bitrate_warning.TabIndex = 11;
            this.bitrate_warning.Text = "leave blank or 0 if you don\'t want to override it.";
            // 
            // bitrate_box
            // 
            this.bitrate_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bitrate_box.Location = new System.Drawing.Point(168, 504);
            this.bitrate_box.MaxLength = 4;
            this.bitrate_box.Name = "bitrate_box";
            this.bitrate_box.Size = new System.Drawing.Size(160, 35);
            this.bitrate_box.TabIndex = 10;
            this.bitrate_box.TextChanged += new System.EventHandler(this.bitrate_box_TextChanged);
            this.bitrate_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bitrate_box_KeyPress);
            // 
            // bitrate_label
            // 
            this.bitrate_label.AutoSize = true;
            this.bitrate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bitrate_label.Location = new System.Drawing.Point(12, 507);
            this.bitrate_label.Name = "bitrate_label";
            this.bitrate_label.Size = new System.Drawing.Size(163, 29);
            this.bitrate_label.TabIndex = 9;
            this.bitrate_label.Text = "Video Bitrate: ";
            // 
            // bitrate
            // 
            this.bitrate.Location = new System.Drawing.Point(12, 467);
            this.bitrate.Name = "bitrate";
            this.bitrate.Size = new System.Drawing.Size(889, 69);
            this.bitrate.TabIndex = 8;
            this.bitrate.Scroll += new System.EventHandler(this.bitrate_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 1041);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(889, 44);
            this.progressBar1.TabIndex = 7;
            // 
            // output_button
            // 
            this.output_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.output_button.Location = new System.Drawing.Point(12, 391);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(247, 40);
            this.output_button.TabIndex = 6;
            this.output_button.Text = "Choose Output Path";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // output_box
            // 
            this.output_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.output_box.Location = new System.Drawing.Point(12, 350);
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_box.Size = new System.Drawing.Size(889, 35);
            this.output_box.TabIndex = 5;
            this.output_box.Text = "Output Path: None Selected";
            // 
            // input_button
            // 
            this.input_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_button.Location = new System.Drawing.Point(12, 265);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(247, 40);
            this.input_button.TabIndex = 4;
            this.input_button.Text = "Choose Input File";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // input_box
            // 
            this.input_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_box.Location = new System.Drawing.Point(12, 224);
            this.input_box.Name = "input_box";
            this.input_box.ReadOnly = true;
            this.input_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_box.Size = new System.Drawing.Size(889, 35);
            this.input_box.TabIndex = 3;
            this.input_box.Text = "Input File: None Selected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Worsener.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Worsener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 1097);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Worsener";
            this.Text = "Worsener";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audio_bitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.TextBox output_box;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar bitrate;
        private System.Windows.Forms.TextBox bitrate_box;
        private System.Windows.Forms.Label bitrate_label;
        private System.Windows.Forms.Label bitrate_warning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox audio_bitrate_box;
        private System.Windows.Forms.Label audio_bitrate_label;
        private System.Windows.Forms.TrackBar audio_bitrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fps_box;
        private System.Windows.Forms.Label fps_label;
        private System.Windows.Forms.TrackBar fps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

