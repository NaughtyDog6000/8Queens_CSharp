using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Xml;

namespace Queens_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            
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
            
        }

        

        public interface IPiece
        {
            void UpdatePosition(Coordinate coords);
            List<Coordinate> GetTargetablePositions();
            Coordinate GetCurrentPosition();

        }

        public class Board
        {
            //properties
            private List<IPiece> Pieces = new List<IPiece>();

            //Constructor

            public Board()
            {
                
            }
            
            
            
            //Methods
            
            public bool AddPieceToBoard(IPiece piece)
            {
                foreach (IPiece currentPiece in Pieces)
                {
                    if (piece.GetCurrentPosition() == currentPiece.GetCurrentPosition())
                    {
                        return false;
                    }
                    
                }
                
                
                this.Pieces.Add(piece);
                return true;
            }

            public IPiece CheckPositionContents()
            {
                //should check the contents of a passed tile, returning the piece if filled
                throw new NotImplementedException();
                return null;
            }

        }
    }
}