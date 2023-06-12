using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Xml;
using Queens_8.Pieces;

namespace Queens_8
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();

            
            List<Coordinate> coordinates = new ManualTesting().GetCoordsToCreate();

            //testing manual coord creeation
            
            // foreach (var coordinate in coordinates)
            // {
            //     Console.WriteLine(coordinate.ToString());
            //     board.AddPieceToBoard(coordinate, "Queen");
            // }
            BruteForceTest bruteForceTest = new BruteForceTest();
            
            bruteForceTest.BruteForce(board, new Queen(), 8);
            
            bruteForceTest.OnePerColumn(board, "Queen", 8);
            
            
            Console.WriteLine("\n CREATED PIECES:");
            board.DebugAllPiecePositions();
            
            Console.WriteLine("DONE!");
            // Console.ReadLine(); //only necessary for console (Rider runs in built in terminal)

        }


        public struct Coordinate
        {
            public int XPos { get; set; }
            public int YPos { get; set; }
            
            public Coordinate(int x, int y)
            {
                this.XPos = x;
                this.YPos = y;
            }

            public static bool operator ==(Coordinate c1, Coordinate c2)
            {
                return c1.Equals(c2);
            }
            
            public static bool operator !=(Coordinate c1, Coordinate c2)
            {
                return !c1.Equals(c2);
            }

            /// <summary>
            /// Gets the difference between the two positions
            /// </summary>
            /// <param name="c1">First Coordinate</param>
            /// <param name="c2">Second Coordinate</param>
            /// <returns>the delta of the second from the first coordinate</returns>
            public static Coordinate operator -(Coordinate c1, Coordinate c2)
            {
                return new Coordinate(c1.XPos - c2.XPos, c1.YPos - c2.YPos);
            }
            
            private bool Equals(Coordinate coord2)
            {
                if (this.XPos == coord2.XPos && this.YPos == coord2.YPos) return true;
                return false;
            }

            public override string ToString()
            {
                return $"XPosition: {this.XPos}, YPosition: {this.YPos}";
            }
        }
        

        public interface IPiece
        {
            void UpdatePosition(Coordinate coords);
            bool CanTargetPosition(Coordinate targetPosition);
            Coordinate GetCurrentPosition();
            void DebugPrintStatus();

        }
        
        
        public static class BasicTargetFunctions
        {
            public static bool HorizontalTarget(Coordinate pieceCoord, Coordinate targetCoordinate, int maxRange = 0)
            {
                // return pieceCoord.YPos == targetCoordinate.YPos;

                if (pieceCoord.YPos == targetCoordinate.YPos)
                {
                    //if there is no max range or the piece is less than or equal to max range distance away
                    if (maxRange == 0 || (pieceCoord - targetCoordinate).XPos <= maxRange) return true;
                }

                return false;
            }
            
            public static bool VerticalTarget(Coordinate pieceCoord, Coordinate targetCoordinate, int maxRange = 0)
            {
                // return pieceCoord.XPos == targetCoordinate.XPos;
                
                if (pieceCoord.XPos == targetCoordinate.XPos)
                {
                    //if there is no max range or the piece is less than or equal to max range distance 
                    if (maxRange == 0 || (pieceCoord - targetCoordinate).YPos <= maxRange) return true;
                }

                return false;
            }
            
            public static bool DiagonalTarget(Coordinate pieceCoord, Coordinate targetCoordinate, int maxRange = 0)
            {
                Coordinate delta = pieceCoord - targetCoordinate;
                // return Math.Abs(delta.XPos) == Math.Abs(delta.YPos);

                if (Math.Abs(delta.XPos) == Math.Abs(delta.YPos))
                {
                    //if there is no max range or if the magnitude of the offset is less than or equal to max range distance
                    if (maxRange == 0 || delta.XPos <= maxRange) return true;
                }

                return false;
            }
        }
  
    }
}