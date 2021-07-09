using MarsRoverCase.Bussiness;
using MarsRoverCase.Bussiness.Command;
using MarsRoverCase.Bussiness.Vehicle;
using System;

namespace MarsRoverCase
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "5 5";
            string s2 = "1 2 N";
            string s3 = "LMLMLMLMM";
            string s4 = "3 3 E";
            string s5 = "MMRMMRMRRM";

            string[] str = s1.Split(' ');
            int row = Int32.Parse(str[0]);
            int col = Int32.Parse(str[1]);

            var direction = new Direction
            {
               Location=s2,
               RowMax=row,
               ColMax=col
            };

            Rover rover = new Rover(direction);
            rover.Operation(s3);
            Console.WriteLine(rover.direction.X+ " " + rover.direction.Y + " " + rover.direction.Dir);

            var direction2 = new Direction
            {
                Location = s4,
                RowMax = row,
                ColMax = col
            };

            Rover rover1 = new Rover(direction2);
            rover1.Operation(s5);
            Console.WriteLine(rover1.direction.X + " " + rover1.direction.Y + " " + rover1.direction.Dir);
        }
    }
}
