using System;
using Battleship.Interfaces;
using Battleship.Models;
using Battleship.Enums;

namespace Battleship.Implementations
{
    public class ShipPlacer : IShipPlacer
    {
              public void AddShipToBoard(Ship ship, Board board, int row, int column)
        {
            Validate(ship, board, row, column);
            for (int i = 0; i < ship.Size; i++)
            {
                // for each ship coordinate, update cell status to occupied
                board.BoardCellStatus[row, column + i] = BoardCellStatus.Occupied;
                board.OccupationCount++;

            }
        }
        private void Validate(Ship ship, Board board, int row, int column)
        {
            var errorMessage = " Ship's Placement Position is out of Bounds";

        // Validate if starting positions in bounds of the board
        if (row > board.Rows)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }
        if (column > board.Columns)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }
        for (int c = 0; c < ship.Size; c++)
            {
                if(column + c > board.Columns)
                {
                    throw new IndexOutOfRangeException(errorMessage);
                }
            }
        }

    }
}
