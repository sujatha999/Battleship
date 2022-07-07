using System;
using Battleship.Enums;

namespace Battleship.Models.Ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            Size = 5;
            ShipType = ShipType.AircraftCarrier;
        }
    }
}
