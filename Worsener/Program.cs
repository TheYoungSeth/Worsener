using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Worsener
{
    static class Program
    {
        public static ProgressBar m_bar;
        public static Label m_status;
        public static int m_videoLength;
        public static int m_bitrate;
        public static int m_audio_bitrate;
        public static int m_fps;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Worsener());
        }

        public static void Start(String input_path, String output_path, string bitrate, string audio_bitrate, string fps, Label status, ProgressBar bar) {
            ConversionOptions options = new ConversionOptions();
            var input_file = new MediaFile(filename: @input_path);
            var output_file = new MediaFile(filename: @output_path);
            if (bitrate != null && bitrate != "") m_bitrate = int.Parse(bitrate);
            if (audio_bitrate != null && audio_bitrate != "") m_audio_bitrate = int.Parse(audio_bitrate) + 9; //why +11 you must think, let me explain. this ffmpeg wrapper this piece of shit won't change the bitrate unless it's above fucking 11 why? I have no fucking idea I spent 2 hours on fixing this.
            if (fps != null && fps != "") m_fps = int.Parse(fps);
            if (bar != null) m_bar = bar;
            m_status = status;

            if (input_path != null && output_path != null)
            {
                if (fps != null && m_fps != 0) options.VideoFps = m_fps;
                if (bitrate != null && m_bitrate != 0) options.VideoBitRate = m_bitrate;
                if (audio_bitrate != null && m_audio_bitrate != 0) options.AudioBitRate = m_audio_bitrate;

                using (var engine = new Engine())
                {
                    engine.GetMetadata(input_file);
                    m_videoLength = (int)input_file.Metadata.Duration.Seconds;
                    engine.ConversionStartedEvent += ConversionStartedEvent;
                    engine.ConvertProgressEvent += ConvertProgressEvent;
                    engine.ConversionCompleteEvent += engine_ConversionCompleteEvent;
                    engine.Convert(input_file, output_file, options);
                }
            } else
            {
                MessageBox.Show("No Input or Output selected.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ConversionStartedEvent(object sender, ConversionStartedEventArgs e) {
            m_bar.Maximum = m_videoLength;
        }

        //why does this event use another thread for no reason? it didn't do anything but fuck up my code and make my program hang while it's in this stage.
        public static void ConvertProgressEvent(object sender, ConvertProgressEventArgs e) {
            Console.Out.WriteLine(m_videoLength + "|" + e.ProcessedDuration.Seconds);
            //m_bar.Value = e.ProcessedDuration.Seconds;
            if (m_videoLength == e.ProcessedDuration.Seconds) {
                MessageBox.Show("Conversion Successful!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Doesn't work????? bro what am I doing wrong a8fzdzuefvszuhfks<ul
        public static void engine_ConversionCompleteEvent(object sender, ConversionCompleteEventArgs e) {
            Console.Out.WriteLine("bruh");
            MessageBox.Show("Conversion Successful!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
