using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Windows.Forms;
using System.Threading;

namespace Worsener
{
    static class Program
    {
        public static ProgressBar m_bar;
        public static int m_videoLength;
        public static int m_width;
        public static int m_height;
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

        public static void Start(String input_path, String output_path, string bitrate, string audio_bitrate, string fps, String width, String height, ProgressBar bar)
        {
            ConversionOptions options = new ConversionOptions();
            var input_file = new MediaFile(filename: @input_path);
            var output_file = new MediaFile(filename: @output_path);
            if (width != null &&  width != "") m_width = int.Parse(width);
            if (height != null && height != "") m_height = int.Parse(height);
            if (bitrate != null && bitrate != "") m_bitrate = int.Parse(bitrate);
            if (audio_bitrate != null && audio_bitrate != "") m_audio_bitrate = int.Parse(audio_bitrate) + 11; //why +11 you must think, let me explain. this ffmpeg wrapper this piece of shit won't change the bitrate unless it's above fucking 11 why? I have no fucking idea I spent 2 hours on fixing this.
            if (fps != null && fps != "") m_fps = int.Parse(fps);
            m_bar = bar;

            if (input_path != null && output_path != null)
            {
                if (fps != null && m_fps != 0) options.VideoFps = m_fps;
                if (bitrate != null && m_bitrate != 0) options.VideoBitRate = m_bitrate;
                if (audio_bitrate != null && m_audio_bitrate != 0) options.AudioBitRate = m_audio_bitrate;
                if (width != null && m_width != 0) options.CustomWidth = m_width;
                if (height != null && m_height != 0) options.CustomHeight = m_height;

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
                MessageBox.Show("No Input or Output selected.", "No FIle Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ConversionStartedEvent(object sender, ConversionStartedEventArgs e)
        {
            Console.Out.WriteLine(m_bar.Maximum);
            m_bar.Maximum = (int) m_videoLength;
            Console.Out.WriteLine(m_bar.Maximum);
        }

        private static void ConvertProgressEvent(object sender, ConvertProgressEventArgs e)
        {
            Console.Out.WriteLine(m_videoLength + "|" + e.ProcessedDuration.Seconds);
            //if(!m_bar.IsDisposed) m_bar.Invoke(new MethodInvoker(delegate { m_bar.Value = (int)e.ProcessedDuration.Seconds; }));
        }

        private static void engine_ConversionCompleteEvent(object sender, ConversionCompleteEventArgs e)
        {
            Console.Out.WriteLine("bruh");
            MessageBox.Show("Conversion Successful!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
