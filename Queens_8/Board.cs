using System.Collections.Generic;

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
            
            public bool AddPieceToBoard(IPiece piece)
            {
                foreach (IPiece currentPiece in _pieces)
                {
                    if (piece.GetCurrentPosition() == currentPiece.GetCurrentPosition())
                    {
                        return false;
                    }
                    
                }
                
                this._pieces.Add(piece);
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