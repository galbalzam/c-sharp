using System;

namespace Matala
{
    class Car
    {
        private int speed = 0;
        
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void upSpeed()
        {
            speed = speed + 1;
            // speed += 1;
            // speed ++
        }

        public void downSpeed()
        {
            speed--;
        }
        public void stop()
        {
            speed = 0;
        }
        public void printSpeed()
        {
            Console.WriteLine(speed);
        }

    }
}
