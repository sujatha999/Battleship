using System;
using Battleship.Models;
using Battleship.Enums;
namespace Battleship.Interfaces
{
    public interface IAttacker
    {
        AttackStatus Attack(Board board, int row, int column);
    }
}
