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
    public class GameStatusTest
    {
        [Fact]
        public void ShouldReturnLostGameStatus_WhenShipSunk()
        {
            //first create a board
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            //then crate a ship 
            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(ShipType.Destroyer);

            // place ship on the board
            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, 0, 0);

            //act 
            //now attack the ship at all given positions for the ship
            var attacker = new Attacker();
            attacker.Attack(board, 0, 0);
            attacker.Attack(board, 0, 1);

            //assert that the status is now lost
            Assert.True(board.HasLost);

        }

        [Fact]
        public void ShouldReturnLostGameStatus_WhenShipNotSunk()
        {
            //arrange

            //first create a board
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            //then crate a ship 
            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(ShipType.Destroyer);

            // place ship on the board
            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, 0, 0);

            //act 
            //now attack the ship at all given positions for the ship
            var attacker = new Attacker();
            attacker.Attack(board, 0, 0);
            attacker.Attack(board, 0, 1);

            //assert that the status is now lost
            Assert.False(board.HasLost);


        }
    }
}
