using System.Drawing;
using System;
using System.Windows.Forms;

namespace DrawingBoardApp
{
    class DrawingBoard
    {
        int tick;
		private int scrWidth, scrHeight;
        private bool y=false;
        private bool x=false;
        


        
        public DrawingBoard(MainForm mainForm)
        {
            scrWidth = mainForm.ClientSize.Width;
            scrHeight = mainForm.ClientSize.Height;
			tick = 0;
        }

        public void Draw(Graphics g)
        {
            // Clear the screen - for this frame
            g.Clear(Color.FromArgb(228, 228, 228));

            g.DrawEllipse(Pens.Red, 20+tick, 25+tick, 50, 50);
        }

        public void Tick()
        {
            if (x==true)
            {
                tick += 20;
                if (tick >= scrWidth)
                {
                    x = false;
                }
            }
            
            if (x==false)
            {
                tick -= 20;
                if (tick <= 0)
                {
                    x = true;
                }
            }
            if (y == true)
            {
                tick += 20;
                if (tick >= scrWidth)
                {
                    y = false;
                }
            }

            if (y == false)
            {
                tick -= 20;
                if (tick <= 0)
                {
                    y = true;
                }
            }


            Console.WriteLine("Tick {0}", tick);
        }
    }
}
