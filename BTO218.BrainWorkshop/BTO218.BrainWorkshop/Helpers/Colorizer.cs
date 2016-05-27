using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTO218.BrainWorkshop.Helpers
{

    //Programda kullandığımız renkleri veren helper.
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

        }
        private Color[] colorArray;

        //Tanımlı renkler arasından rastgele renk veren fonksiyon.
        public Color getRandomColor()
        {
            return colorArray[r.Next(0, 4)];
        }
    }
}
