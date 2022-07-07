using System;
using Battleship.Enums;
using Battleship.Interfaces;
using Battleship.Models;

namespace Battleship.Implementations
{
    public class BoardCreator : IBoardCreator
    {
        public Board CreateBoard(int rows, int columns)
        {
            try
            {
                //build up the board and set all cells to unoccupied
                BoardCellStatus[,] statusArray = new BoardCellStatus[rows, columns];
                for (int row=0; row<rows; row++)
                {
                    for (int col=0; col<columns; col++)
                    {
                        statusArray[row, col] = BoardCellStatus.Unoccupied;
                    }
                }
                // return the board
                return new Board
                {
                    BoardCellStatus = statusArray,
                    Rows = rows,
                    Columns = columns
                };

            }
            catch (Exception ex)
            {
                throw new Exception($"Error While Creating Board : { ex.Message}");
            }
        }
    }
}
