using System;


namespace RoverRanger
{
    class Program
    {
       public static void ExecuteCommand(Rover vehicle,char command)
        {
            if(command == 'L')
            {
                vehicle.LeftRotate();
            }
            else if(command == 'R')
            {
                vehicle.RightRotate();
            }
            else if(command == 'M')
            {
                vehicle.Move();
            }
        }
        static void Main(string[] args)
        {
            string[] cordinatesAndDirection = Console.ReadLine().Split(' ');
            string commands = Console.ReadLine();

            int xCordinate, yCordinate;
            string direction;

            xCordinate = Convert.ToInt32(cordinatesAndDirection[0]);
            yCordinate = Convert.ToInt32(cordinatesAndDirection[1]);
            direction = cordinatesAndDirection[2];

            Rover vehicle = new Rover(xCordinate,yCordinate,direction);

            

            foreach(char command in commands)
            {
                ExecuteCommand(vehicle, command);
            }

            Console.WriteLine(vehicle.xCordinate);
            Console.WriteLine(vehicle.yCordinate);
            Console.WriteLine(vehicle.direction);
        }
    }
}
