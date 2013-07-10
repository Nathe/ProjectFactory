using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Builder
{
    public partial class Game : Form
    {
        PictureBox picture = new PictureBox();

        int x = 0;
        int y = 0;

        public Game()
        {
            InitializeComponent();

            //Game Loop Timer
            Timer GameTimer = new Timer();
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameLoop);
            GameTimer.Start();

            //Debug code
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new System.Drawing.Point(x, y);
            picture.Size = new System.Drawing.Size(50, 50);
            picture.Image = new Bitmap("C:/Users/Nathaniel/Documents/GitHub/ProjectFactory/Factory Builder/Factory Builder/Untitled-1.png");
            Controls.Add(picture);
            //End debug code
        }

        void GameLoop(object sender, EventArgs e)
        {
            ProcessFrame();
            RenderFrame();

        }

        public void ProcessFrame()
        {
            x++;
            y++;

        }

        public void RenderFrame()
        {
            picture.Location = new System.Drawing.Point(x, y);
            this.Refresh();
        }
    }
}
