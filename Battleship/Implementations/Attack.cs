using System;
using Battleship.Enums;
using Battleship.Interfaces;
using Battleship.Models;

namespace Battleship.Implementations
{
    public class Attack : IAttacker
    {
        AttackStatus IAttacker.Attack(Board board, int row, int column)
        {
            Validate(board, row, column);
            //if the attack lands on an occupied position, set the status as hit
            if (board.BoardCellStatus[row, column] == BoardCellStatus.Occupied || 
                board.BoardCellStatus[row, column] == BoardCellStatus.Hit)
                    { 
            board.BoardCellStatus[row, column] = BoardCellStatus.Hit;    
                // update the hintcount ( used to determine win/lost)
                board.HitCount++;
                // return the attack status
                return AttackStatus.Hit;
            }

            board.BoardCellStatus[row, column] = BoardCellStatus.Miss;
            return AttackStatus.Miss;
        }
        private void Validate(Board board, int row, int column)
        {
            var errorMessage = "Attack Position is out of Bounds";

            // Validate if starting positions in bounds of the board
            if (row > board.Rows)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }
            if (column > board.Columns)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }
        }

       internal object Attack_(Board board, int attackRow, int attackColumn)
        {
            //throw new NotImplementedException();
            return "Hit";
        }
    }
}
