using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            redTrackBar.ValueChanged += TrackBar_ValueChanged;
            greenTrackBar.ValueChanged += TrackBar_ValueChanged;
            blueTrackBar.ValueChanged += TrackBar_ValueChanged;
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            colorPanel.BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
        }

        private void redTrackBar_Validating(object sender, CancelEventArgs e)
        {
            if (redTrackBar.Value > 100)
            {
                errorProvider1.SetError(redTrackBar, "Hic");
            } else
            {
                errorProvider1.Clear();
            }
        }
    }
}
