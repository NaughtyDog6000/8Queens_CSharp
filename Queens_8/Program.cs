using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Xml;

namespace Queens_8
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();

            
            List<Coordinate> coordinates = new ManualTesting().GetCoordsToCreate();

            //testing manual coord creeation
            foreach (var coordinate in coordinates)
            {
                Console.WriteLine(coordinate.ToString());
            }
            
            
            IPiece piece = new Queen(coords: new Coordinate(0,0));
            board.AddPieceToBoard(piece);
            
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
            List<Coordinate> GetTargetablePositions();
            Coordinate GetCurrentPosition();
            void DebugPrintStatus();

        }
        
        
        public static class BasicTargetFunctions
        {
            public static bool HorizontalTarget(Coordinate pieceCoord, Coordinate targetCoordinate)
            {
                return pieceCoord.YPos == targetCoordinate.YPos;
            }
            
            public static bool VerticalTarget(Coordinate pieceCoord, Coordinate targetCoordinate)
            {
                return pieceCoord.XPos == targetCoordinate.XPos;
            }
            
            public static bool DiagonalTarget(Coordinate pieceCoord, Coordinate targetCoordinate)
            {
                if (Math.Abs(pieceCoord.XPos) == Math.Abs(targetCoordinate.XPos))
                {
                    Console.WriteLine("Xpos is of the same magnitiude");
                }
                else
                {
                    Console.WriteLine("Xpos is not of the same magnitude; they are not diagonal tiles");
                    return false;
                }

                if (Math.Abs(pieceCoord.YPos) == Math.Abs(targetCoordinate.YPos))
                {
                    Console.WriteLine("Ypos is of the same magnitude");
                }
                else
                {
                    Console.WriteLine("Ypos is not of the same magnitude; they are not diagonal tiles");
                    return false;
                }
                
                
                return true;
            }
        }
  
    }
}