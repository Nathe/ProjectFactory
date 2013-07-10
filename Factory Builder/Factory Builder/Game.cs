using System;
using System.IO;
using System.Reflection;
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
        int money = 5000;
        MobileEntity entity = new MobileEntity(0, 0, 0);
        Ploppable ploppable = new Ploppable(1, 100, 300);

        public Game()
        {
            DoubleBuffered = true;

            InitializeComponent();

            //Game Loop Timer
            Timer GameTimer = new Timer();
            GameTimer.Interval = 1;
            GameTimer.Tick += new EventHandler(GameLoop);
            GameTimer.Start();

            Controls.Add(entity.GetPictureBox());
            Controls.Add(ploppable.GetPictureBox());
        }

        void GameLoop(object sender, EventArgs e)
        {
            ProcessFrame();
            RenderFrame();
        }

        public void ProcessFrame()
        {
            entity.RunBehaviour();
        }

        public void RenderFrame()
        {
            labelMoney.Text = money.ToString();
            Invalidate();
        }
    }
}
