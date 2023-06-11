using System;
using System.Collections.Generic;


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
        public List<Program.Coordinate> GetTargetablePositions()
        {
            throw new System.NotImplementedException();
        }
        
        //Debug Methods
        
        public void DebugPrintStatus()
        {
            Console.WriteLine($"Position: X: {this._coords.XPos}, Y: {this._coords.YPos}" +
                              $"\nType: Queen");
        }
        
    }
}