using Battleship.Enums;
using Battleship.Implementations;
using Battleship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Battleship.Test
{
    public class AttackerTest
    {
        [Theory]
        [InlineData(10, 10, 0, 0, 0, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 1, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 2, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 3, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 4, ShipType.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 5, 5, ShipType.AircraftCarrier, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 5, ShipType.AircraftCarrier, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 3, 8, ShipType.AircraftCarrier, BoardCellStatus.Miss)]

        public void ShouldReturnCorrectAttackStatus_WhenAttackLanched( int boardRows, int boardColumns, int PlacementRow,
            int PlacementColumn, int attackRow, 
            int attackColumn, ShipType ShipType, BoardCellStatus boardCellStatus)
        {
            //arrange 
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);
                       

           //then create aship
            var ShipCreator = new ShipCreator();
            var Ship = ShipCreator.CreateShip(ShipType);

            // place ship on the board
            var ShipPlacer = new ShipPlacer();
            ShipPlacer.AddShipToBoard(Ship, board, PlacementRow, PlacementColumn);

            //act
           // var attacker = new Attack();
            //attacker.Attack_(board, attackRow, attackColumn);

            //assert
            Assert.True(
                board.BoardCellStatus[attackRow, attackColumn] == boardCellStatus
                );
        }
    }
}
