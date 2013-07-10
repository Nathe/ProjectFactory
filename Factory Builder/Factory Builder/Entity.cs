using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Builder
{
    class Entity
    {
        PictureBox _pictureBox = new PictureBox();
        int _image;

        public Entity(int imageIndex, int x, int y)
        {
            _image = imageIndex;

            // Load the image
            _pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureBox.Location = new System.Drawing.Point(x, y);
            _pictureBox.Size = new System.Drawing.Size(46, 46);
            _pictureBox.Image = ImageList.GetImage(_image);
            _pictureBox.BackColor = Color.Transparent;
        }

        public PictureBox GetPictureBox()
        {
            return _pictureBox;
        }

        public int GetX()
        {
            return _pictureBox.Location.X;
        }

        public void SetLocation(int x, int y)
        {
            _pictureBox.Location = new System.Drawing.Point(x, y);
        }

        public int GetY()
        {
            return _pictureBox.Location.Y;
        }
    }
}
