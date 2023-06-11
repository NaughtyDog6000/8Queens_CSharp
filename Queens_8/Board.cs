using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Queens_8
{
    public partial class Program
    {
        public class Board
        {
            //properties
            
            
            /// <summary>
            /// The list of pieces contained within the board
            /// </summary>
            private List<IPiece> _pieces = new List<IPiece>();
            
            /// <summary>
            /// size of the board (default is 8 tiles)
            /// </summary>
            private int _size = 8;

            //Constructor

            public Board(int size)
            {
                this._size = size;
            }

            public Board()
            {
                
            }
            
            
            
            //Methods
            
            public bool AddPieceToBoard(Coordinate coordinate, string type)
            {
                //check the validity of the current position before creating the piece and wasting time
                foreach (var piece in _pieces)
                {
                    if (coordinate == piece.GetCurrentPosition()) { Console.WriteLine("The Attempted Position is occupied"); return false; }
                    if (piece.CanTargetPosition(coordinate)) { Console.WriteLine($"PIECE FAILED TO BE CREATED, {piece.GetCurrentPosition().ToString()} can Target it"); return false;}

                }

                
                //Create the new piece of the type passed
                switch (type)
                {
                    case "Queen":
                        Console.WriteLine($"Creating Queen @ {coordinate.ToString()}");
                        _pieces.Add(new Queen(coordinate)); 
                        break;
                    case "Pawn":
                        throw new NotImplementedException();
                        
                    case "King":
                        throw new NotImplementedException();
                    
                    case "Knight":
                        throw new NotImplementedException();
                    
                    default:
                        Console.WriteLine("WTF IS THAT PIECE! (Piece not added to the reg)");
                        return false;
                        break;
                }
                    
                //signal everything went well
                return true;
            }

            public IPiece CheckPositionContents(Coordinate coordinate)
            {
                //should check the contents of a passed tile, returning the piece if filled
                
                //definitely not fast method
                foreach (var piece in _pieces)
                {
                    if (piece.GetCurrentPosition() == coordinate) return piece;
                }

                //none found return nothing
                return null;
            }

            public void DebugAllPiecePositions()
            {
                foreach (IPiece piece in _pieces)
                {
                    piece.DebugPrintStatus();
                }
            }
            
        }
    }
}