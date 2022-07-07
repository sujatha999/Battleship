using System;
using Battleship.Models;
using Battleship.Enums;
namespace Battleship.Interfaces
{
    public interface IShipCreator
    {
        Ship CreateShip(ShipType shipType);
    }

}
