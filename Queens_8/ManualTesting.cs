using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Queens_8
{
    public class ManualTesting
    {
        public List<Program.Coordinate> GetCoordsToCreate()
        {
            List<Program.Coordinate> coordinates = new List<Program.Coordinate>();

            Console.WriteLine("How many pieces would you like to add? (1-8): ");

            //Tom Prevention measures
            int.TryParse(Console.ReadLine(),out int result);
            while (result < 1 || result > 8)
            {
                int.TryParse(Console.ReadLine(),out result);
            }
            //Console.WriteLine($"the value you entered: {result}");


            for (int i = 1; i <= result; i++)
            {
                coordinates.Add(GetCoordinate(i));
            }

            return coordinates;
        }

        public Program.Coordinate GetCoordinate(int i)
        {
                            
            Console.WriteLine($"Creating the {i}th piece:" +
                              $"\nEnter X Coordinate: ");
            bool FailX  = int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Enter Y Coordinate: ");
            bool FailY  = int.TryParse(Console.ReadLine(), out int y);

            if (FailY != true || FailX != true)
            {
                Console.WriteLine($"calling recursively, Xvalidity: {FailX}, Yvalidity: {FailY}");
                return GetCoordinate(i);
            }
            else
            {
                return new Program.Coordinate(x, y);
            }
        }
        
        
        
    }
}