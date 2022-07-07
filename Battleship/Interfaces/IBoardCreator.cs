using System;
using Battleship.Models;

namespace Battleship.Interfaces
{
    public interface IBoardCreator
    {
        Board CreateBoard(int rows, int columns);
    }
}
