using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08_factorypattern.Abstractions;
using System.Drawing;

namespace week08_factorypattern.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }

        protected override void DrawImage(Graphics g)
        {
            
        }
    }
}
