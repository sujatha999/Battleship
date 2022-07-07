using Battleship.Enums;
using System;
namespace Battleship.Models
{
    public class AttackParameters
    {
        public int boardRows { get; set; }
        public int boardColumns { get; set; }
        public int PlacementRow { get; set; }
        public int PlacementColumn { get; set; }
        public int attackRow { get; set; }
        public int attackColumn { get; set; }
        public ShipType ShipType { get; set; }
        public BoardCellStatus boardCellStatus { get; set; }

    }
}
