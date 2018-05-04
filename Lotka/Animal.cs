using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        private int count;
        public int Count { get {return count; } }

        private float engry=0;
        public float Engry
        {
            get { return engry; }
            set
            {
                engry = value;
                if (engry >= 1 || engry < -1)
                {
                    count += (int)engry;
                    engry = engry - (int)engry;
                }
            }
        }
        public Animal(int count)
        {
            this.count = count;
        }
      
    }

}

