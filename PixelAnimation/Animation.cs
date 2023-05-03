using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelAnimation
{
    public class Animation
    {
        public Bitmap anim;
        public Bitmap mapAnim;
        public Bitmap colorMap;
        public Bitmap texture;
        public int frameIndex;
        public int width, height;
        public System.Drawing.Imaging.PixelFormat format;
        public Rectangle frameZone;

        public Bitmap NextFrame()
        {
            Bitmap frame = new Bitmap(width, width);
            Color target;
            frameIndex = frameIndex * width + width >= height ? 0 : frameIndex + 1;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    target = mapAnim.GetPixel(i, (frameIndex * width) + j);
                    frame.SetPixel(i, j, texture.GetPixel(target.R, target.G));
                }
            }
            return frame;
        }

        public Animation(Bitmap animation, Bitmap colormap, Bitmap texture)
        {
            frameIndex = 0;
            this.anim = animation;
            this.width = animation.Width;
            this.height = animation.Height;
            this.format = animation.PixelFormat;
            this.frameZone = new Rectangle(0, 0, this.width, this.width);
            this.colorMap = colormap;
            this.texture = texture;

            Color target;
            this.mapAnim = new Bitmap(animation.Width, animation.Height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    target = animation.GetPixel(i, j);
                    for (int mx = 0; mx < colormap.Width; mx++)
                    {
                        for (int my = 0; my < colormap.Height; my++)
                        {
                            if (colormap.GetPixel(mx, my) == target)
                            {
                                mapAnim.SetPixel(i, j, Color.FromArgb(mx, my, 0));
                                mx = colormap.Width; my = colormap.Height;
                            }
                        }
                    }
                }
            }
        }
    }
}
