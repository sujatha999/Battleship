using System;
using Battleship.Enums;
namespace Battleship.Models.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Size = 2;
            ShipType = ShipType.Destroyer;
        }
    }
}
