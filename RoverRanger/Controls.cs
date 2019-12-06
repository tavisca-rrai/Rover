using System;
using System.Collections.Generic;
using System.Text;

namespace RoverRanger
{
    public static class Controls
    {   
        public static void LeftRotate(this Rover vehicle)
        {
            int currentDirectionIndex = (int)((Direction)Enum.Parse(typeof(Direction), vehicle.direction));
            int directionindexAfterLeftRotation = (currentDirectionIndex + 1) % 4;

            var enumDisplayStatus = (Direction)directionindexAfterLeftRotation;
            vehicle.direction = enumDisplayStatus.ToString();
        }

        public static void RightRotate(this Rover vehicle)
        {
            int currentDirectionIndex = (int)((Direction)Enum.Parse(typeof(Direction), vehicle.direction));
            int directionindexAfterLeftRotation = (currentDirectionIndex - 1) % 4;

            var enumDisplayStatus = (Direction)directionindexAfterLeftRotation;
            vehicle.direction = enumDisplayStatus.ToString();
        }

        public static void Move(this Rover vehicle)
        {
            Dictionary<string, Tuple<int, int>> dictionary = new Dictionary<string, Tuple<int, int>>() {
            { "East" , Tuple.Create(1,0)},
            { "North" , Tuple.Create(0,1)},
            { "West" , Tuple.Create(-1,0)},
            { "South" , Tuple.Create(0,-1)}
        };

            vehicle.xCordinate += dictionary[vehicle.direction].Item1;
            vehicle.yCordinate += dictionary[vehicle.direction].Item2;

        }
    }
}
