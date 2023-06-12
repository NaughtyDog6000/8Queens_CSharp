using System;
using static Queens_8.Program.BasicTargetFunctions;


namespace Queens_8.Pieces
{
    public class Pawn : Program.IPiece
    {

            //properties
        
            private Program.Coordinate _coords;


            //Constructor

            public Pawn(Program.Coordinate coords)
            {
                this._coords = coords;
            }

            public Pawn(int x = -1, int y = -1)
            {
                this._coords = new Program.Coordinate(x, y);
            }
        
        
        
            //methods
        
            public void UpdatePosition(Program.Coordinate coords) { this._coords = coords; }
            public Program.Coordinate GetCurrentPosition() { return this._coords; }
            public bool CanTargetPosition(Program.Coordinate targetPosition)
            {
                //Pawn can attack in the relative positive diagonal one place in either direction
                if (DiagonalTarget(this._coords, targetPosition, 1)) return true;

                return false;
            }
        
            //Debug Methods
        
            public void DebugPrintStatus()
            {
                Console.WriteLine($"Position: X: {this._coords.XPos}, Y: {this._coords.YPos}" +
                                  $"\nType: Pawn");
            }
        

    }
}