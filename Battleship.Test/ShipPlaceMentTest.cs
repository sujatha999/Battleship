using Battleship.Enums;
using Battleship.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Battleship.Test
{
    public class ShipPlaceMentTest
    {
        [Theory]
        [InlineData(10, 10, 0, 0, ShipType.AircraftCarrier)]
        [InlineData(10, 10, 0, 6, ShipType.Destroyer)]
        public void ShoulsPlaceAShip_WhenCorrectPositionsProvided(
            int boardRows, int boardCols, int placementRow, int placementColumn, ShipType shipType )
        {
            //first create a board
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard( boardRows, boardCols );

            //then create  ship
            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            //assert
            Assert.True(
                board.BoardCellStatus[placementRow, placementColumn] == BoardCellStatus.Occupied && 
                board.BoardCellStatus[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied);
                      );

        }
    }
}
