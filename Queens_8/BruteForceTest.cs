using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Configuration;
using static Queens_8.Program;

namespace Queens_8
{
    public class BruteForceTest
    {
        public void BruteForce(Board board, IPiece type, int numberOfPieces)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine($"Type: {type.GetType()}");
            
            sw.Start();
            //BruteForce by trying every possible combination (stupid)
            
            
            
            sw.Stop();
            Console.WriteLine($"Time Elapsed: {sw.Elapsed}");

        }

        


        public void OnePerColumn(Board board, string type, int numberOfPieces)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //this one should not attempt to put any in the same column as a previous one
            


            sw.Stop();
            Console.WriteLine($"Time Elapsed: {sw.Elapsed}");
        }

        public void OnePerColumnAndOnePerRow(Board board, string type, int numberOfPieces)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //this one should not attempt to put any in the same column as a previous one and skip previously done rows



            sw.Stop();

            Console.WriteLine($"Time Elapsed to run test: {sw.Elapsed}");
        }


        public void SmartestICanThinkOf(Board board, string type, int numberOfPieces)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //this is somethign I will think about when its not 3 in the morning and my brain isnt fried



            sw.Stop();

            Console.WriteLine($"Time Elapsed to run test: {sw.Elapsed}");
        }


        
    }
}
