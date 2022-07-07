using System;
using Battleship.Models;

namespace Battleship.Interfaces
{
    public interface IShipPlacer
    {
        void AddShipToBoard(Ship ship, Board board, int row, int column);
    }

}
