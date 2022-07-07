using System;
using Battleship.Enums;
using Battleship.Interfaces;
using Battleship.Models;
using Battleship.Models.Ships;

namespace Battleship.Implementations
{
    public class ShipCreator : IShipCreator
    {
        public Ship CreateShip(ShipType shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipType.AircraftCarrier:
                        return new AircraftCarrier();

                    case ShipType.Destroyer:
                        return new Destroyer();
                    default:
                        return new AircraftCarrier();
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception($"Could Not Create a Ship : {ex.Message}");
            }
        }
    }
}
