using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTO218.BrainWorkshop.Helpers
{
    public class Colorizer
    {            
        Random r = new Random();

        public Colorizer()
        {
            colorArray = new Color[6];
            colorArray[0] = Color.Red;
            colorArray[1] = Color.Green;
            colorArray[2] = Color.Blue;
            colorArray[3] = Color.Yellow;
            colorArray[4] = Color.Orange;
            colorArray[5] = Color.Purple;
        }
        private Color[] colorArray;
        public Color getRandomColor()
        {
            return colorArray[r.Next(0, 6)];
        }
    }
}
