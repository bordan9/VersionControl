﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using week08_factorypattern.Abstractions;

namespace week08_factorypattern.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height);
        }
    }
}
