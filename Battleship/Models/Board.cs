using System;
using Battleship.Enums;
namespace Battleship.Models
{
    public class Board
    {
        public BoardCellStatus[,] BoardCellStatus { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int OccupationCount { get; set; }
        public int HitCount { get; set; }
        public bool HasLost => HitCount >= OccupationCount;
    }
}
