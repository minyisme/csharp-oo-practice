using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeOO
{
    class Ball
    {
        private int size;
        private Color color;
        private int timesThrown;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (this.size != 0)
            {
                this.timesThrown += 1;
            }
        }

        public int DisplayTimesThrown()
        {
            return this.timesThrown;
        }

    }
}
