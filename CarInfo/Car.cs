using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.CarInfo
{
    public class Car
    {
        public string name;
        public string color;
        public int position;
        public int number;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
        }
        public int Position
        {
            get
            {
                return position;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
        }
    }
}