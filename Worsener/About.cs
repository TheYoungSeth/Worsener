using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worsener
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.discord.gg/YwMevvNbDY");
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/TheYoungSeth");
        }

        private void patreon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/theyoungseth");
        }
    }
}
