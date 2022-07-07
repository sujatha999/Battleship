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
    public class ShipCreartorTest
    {
        [Theory]
        [InlineData(ShipType.AircraftCarrier)]
        [InlineData(ShipType.Destroyer)]
        public void ShouldReturnShip_WhenShipCreated(ShipType shipType)
        {
            //arrange
            var shipCreator = new ShipCreator();

            //act
            var ship = shipCreator.CreateShip(shipType);

            //assert
            Assert.NotNull(ship);

        }
    }
}
