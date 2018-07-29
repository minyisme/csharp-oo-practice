using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeOO
{
    class Color
    {
        private int red;
        private int blue;
        private int green;
        private int alpha;

        public Color(int red, int blue, int green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        public Color(int red, int blue, int green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = 255;
        }

        public int GetRed()
        {
            return red;
        }

        public int GetBlue()
        {
            return blue;
        }

        public int GetGreen()
        {
            return green;
        }

        public void SetRed(int red)
        {
            this.red = red;
        }

        public void SetBlue(int blue)
        {
            this.blue = blue;
        }

        public void SetGreen(int green)
        {
            this.green = green;
        }

        public float GetGrayscale()
        {
            return (red + blue + green) / 3.0f;
        }
    }
}
