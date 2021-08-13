using System;
using System.Windows.Forms;
using System.Threading;

namespace Worsener
{
    public partial class Worsener : Form
    {

        public static String input_path;
        public static String output_path;
        private int bitrate_Maximum = 3000;
        private int audio_bitrate_Maximum = 2000;
        private int fps_Maximum = 300;
        private int result;

        public Worsener()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitrate.Maximum = this.bitrate_Maximum;
            audio_bitrate.Maximum = this.audio_bitrate_Maximum;
            fps.Maximum = this.fps_Maximum;
        }

        public void start_Click(object sender, EventArgs e)
        {
            Program.Start(input_path, output_path, bitrate_box.Text, audio_bitrate_box.Text, fps_box.Text, width.Text, height.Text, progressBar1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About popup = new About();
            popup.Show();
        }
        private void input_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Choose the file to make worse";
            dialog.Filter = "MP4 Video Format (*.mp4)|*.mp4|MOV Video Format (*.mov)|*.mov|Markov Video Format (*.mkv)|*.mkv";
            dialog.ShowDialog();
            if (dialog.CheckFileExists && dialog.CheckPathExists)
            {
                input_box.Text = "Input File: " + dialog.FileName;
                input_path = dialog.FileName;
            }
            else
            {
                input_box.Text = "Error: File or Path does not exist.";
            }

        }

        private void output_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Choose where you want to save your meme";
            dialog.Filter = "MP4 Video Format (*.mp4)|*.mp4|MOV Video Format (*.mov)|*.mov|Markov Video Format (*.mkv)|*.mkv";
            dialog.DefaultExt = "mp4";
            dialog.AddExtension = true;
            dialog.FileName = "New Video.mp4";
            dialog.SupportMultiDottedExtensions = true;
            dialog.ShowDialog();
            if (dialog.CheckPathExists)
            {
                output_box.Text = "Output Path: " + dialog.FileName;
                output_path = dialog.FileName;
            }
            else
            {
                output_box.Text = "Error: Path not accessible or does not exist.";
            }
        }

        private void bitrate_Scroll(object sender, EventArgs e)
        {
            bitrate_box.Text = bitrate.Value.ToString();
        }

        private void bitrate_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void bitrate_box_TextChanged(object sender, EventArgs e)
        {
            if(!IsDigitsOnly(bitrate_box.Text))
            {
                bitrate_box.Text = "";
                bitrate.Value = int.Parse(bitrate_box.Text);
            }
        }

        private void audio_bitrate_Scroll(object sender, EventArgs e)
        {
            audio_bitrate_box.Text = audio_bitrate.Value.ToString();
        }

        private void audio_bitrate_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void audio_bitrate_box_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigitsOnly(audio_bitrate_box.Text))
            {
                audio_bitrate_box.Text = "";
                audio_bitrate.Value = int.Parse(audio_bitrate_box.Text);
            }
        }

        private void fps_box_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigitsOnly(fps_box.Text))
            {
                fps_box.Text = "";
                fps.Value = int.Parse(fps_box.Text);
            }
        }

        private void fps_Scroll(object sender, EventArgs e)
        {
            fps_box.Text = fps.Value.ToString();
        }
        private void fps_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigitsOnly(width.Text))
            {
                width.Text = "";
            }
        }

        private void width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            if (!IsDigitsOnly(height.Text))
            {
                height.Text = "";
            }
        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
