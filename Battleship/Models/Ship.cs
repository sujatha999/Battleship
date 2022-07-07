using Battleship.Enums;
using System;
namespace Battleship.Models
{
    public  abstract class Ship
    {
        public ShipType ShipType { get; set; }
        public int Size { get; set; }
    }
}
