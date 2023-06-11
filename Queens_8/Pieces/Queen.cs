using System;
using System.Collections.Generic;
using static Queens_8.Program.BasicTargetFunctions;

namespace Queens_8
{
    public class Queen : Program.IPiece
    {
        //properties
        
        private Program.Coordinate _coords;


        //Constructor

        public Queen(Program.Coordinate coords)
        {
            this._coords = coords;
        }
        
        
        //methods
        
        public void UpdatePosition(Program.Coordinate coords) { this._coords = coords; }
        public Program.Coordinate GetCurrentPosition() { return this._coords; }
        public bool CanTargetPosition(Program.Coordinate targetPosition)
        {
            //Queen can attack diagonals, horizontals, verticals
            if (DiagonalTarget(this._coords, targetPosition)) return true;
            if (HorizontalTarget(this._coords, targetPosition)) return true;
            if (VerticalTarget(this._coords, targetPosition)) return true;
            return false;
        }
        
        //Debug Methods
        
        public void DebugPrintStatus()
        {
            Console.WriteLine($"Position: X: {this._coords.XPos}, Y: {this._coords.YPos}" +
                              $"\nType: Queen");
        }
        
    }
}