using Battleship.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Battleship.Test
{
    public class BoardTest
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        public void ShouldReturnValidBoard_WhenBoardCreated(int rows, int columns)
        {
            //arrange
            var boardCreator = new BoardCreator();

            //act
            var board = boardCreator.CreateBoard(rows, columns);

            //assert
            Assert.Equal(rows * columns, board.BoardCellStatus.Length);
        }
    }
}
