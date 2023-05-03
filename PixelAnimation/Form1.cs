using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelAnimation
{
    public partial class Form1 : Form
    {
        public static System.Timers.Timer aTimer;
        public static Graphics mainGraphics, animGraphics, colorGraphics, textureGrapgics;
        public static Animation a, pa;
        public static Bitmap[] skins = {};
        public static Bitmap[] anims = {};
        public Form1()
        {
            InitializeComponent();

            DirectoryInfo sd = new DirectoryInfo("skins");

            FileInfo[] skinFiles = sd.GetFiles("*.png"); //Getting Text files
            foreach (FileInfo file in skinFiles)
            {
                Array.Resize(ref skins, skins.Length + 1);
                skins[skins.Length - 1] = new Bitmap($"{file.FullName}");
                skinComboBox.Items.Add($"{file.Name}");
            }
            skinComboBox.SelectedIndex = 0;

            DirectoryInfo ad = new DirectoryInfo("animations");

            FileInfo[] animFiles = ad.GetFiles("*.png"); //Getting Text files
            foreach (FileInfo file in animFiles)
            {
                Array.Resize(ref anims, anims.Length + 1);
                anims[anims.Length - 1] = new Bitmap($"{file.FullName}");
                animCombo.Items.Add($"{file.Name}");
            }
            animCombo.SelectedIndex = 0;
        }

        private void RenderFrame(object sender, EventArgs e)
        {
            mainGraphics.Clear(SystemColors.Control);
            mainGraphics.DrawImage(a.NextFrame(), 0, 0, mainBox.Width, mainBox.Height);

            animGraphics.Clear(SystemColors.Control);
            animGraphics.DrawImage(pa.NextFrame(), 0, 0, colorAnimationBox.Width, colorAnimationBox.Height);
            colorGraphics.Clear(SystemColors.Control);
            colorGraphics.DrawImage(a.colorMap, 0, 0, colorMapBox.Width, colorMapBox.Height);
            textureGrapgics.Clear(SystemColors.Control);
            textureGrapgics.DrawImage(a.texture, 0, 0, textureBox.Width, textureBox.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mainGraphics = mainBox.CreateGraphics();
            mainGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            animGraphics = colorAnimationBox.CreateGraphics();
            animGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            colorGraphics = colorMapBox.CreateGraphics();
            colorGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            textureGrapgics = textureBox.CreateGraphics();
            textureGrapgics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            a = new Animation(anims[animCombo.SelectedIndex], new Bitmap("Colormap.png"), skins[skinComboBox.SelectedIndex]);
            pa = new Animation(a.anim, a.colorMap, a.colorMap);
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000 / freqTrackBar.Value;
            aTimer.Elapsed += RenderFrame;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void freqTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (freqTrackBar.Value > 0)
            {
                aTimer.Enabled = true;
                aTimer.Interval = 1000 / freqTrackBar.Value;
            }
            else
            {
                aTimer.Enabled = false;
            }
        }

        private void skinComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
            a.texture = skins[skinComboBox.SelectedIndex];
            aTimer.Enabled = true;
        }

        private void animCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
            a = new Animation(anims[animCombo.SelectedIndex], new Bitmap("Colormap.png"), skins[skinComboBox.SelectedIndex]);
            pa = new Animation(a.anim, a.colorMap, a.colorMap);
            aTimer.Enabled = true;
        }
    }
}
