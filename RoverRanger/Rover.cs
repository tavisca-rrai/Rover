using System;
using System.Collections.Generic;
using System.Text;

namespace RoverRanger
{
    public class Rover
    {
        public int xCordinate { get; set; }
        public int yCordinate { get; set; }

        public string direction { get; set; }

        public Rover(int xCordinate, int yCordinate, string direction)
        {
            this.xCordinate = xCordinate;
            this.yCordinate = yCordinate;
            this.direction = direction;
        }


    }
}
