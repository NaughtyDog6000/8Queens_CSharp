using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using static Queens_8.Program;

namespace Queens_8
{
    public class BruteForceTest
    {
        public void BruteForce(Board board, string type, int numberOfPieces)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            //wait this is not going to work theres liek a ridiulous number of possibel combinations
            // while (true)
            // {
            //     //this is close enogh rihgt?
            // }

            public List<IPiece> Pieces = new List<IPiece>();


            sw.Stop();

            Console.WriteLine($"Time Elapsed to run test: {sw.Elapsed}");
        }


        public void OnePerColumn(Board board, string type, int numberOfPieces)
        {


            //this one should not attempt to put any in the same column as a previous one




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
