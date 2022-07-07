using Battleship.Enums;
using Battleship.Implementations;
using Battleship.Interfaces;
using Battleship.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Battleship.Controllers
{
    public class BattleController : ControllerBase
    {
        public ActionResult<IBoardCreator> CreateBoard([FromBody] BoardParameters newBoard)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(newBoard.Rows, newBoard.Columns);
                return Ok("Create board succeed with row is:" + board.Rows + "columns is:" + board.Columns);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed");
            }
        }
        [Route("place")]
        [HttpPost]
        public ActionResult PlaceShip([FromBody] PlaceShipParameters body)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(body.boardRows, body.boardColumns);

                var ShipCreator = new ShipCreator();
                var Ship = ShipCreator.CreateShip(body.ShipType);

                var ShipPlacer = new ShipPlacer();
                ShipPlacer.AddShipToBoard(Ship, board, body.PlacementRow, body.PlacementColumn);

                return Ok("Place Ship on the board succeed at placementRow:" + body.boardRows + "Columns:" + body.boardColumns);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("Attack")]
        [HttpPost]
        public ActionResult Attacker([FromBody] AttackParameters attack)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(attack.boardRows, attack.boardColumns);
                // then create a ship 
                var ShipCreator = new ShipCreator();
                var Ship = ShipCreator.CreateShip(attack.ShipType);

                var ShipPlacer = new ShipPlacer();
                ShipPlacer.AddShipToBoard(Ship, board, attack.PlacementRow, attack.PlacementColumn);

                //now attack the ship at given position 
                var attacker = new Attack();
                var result = attacker.Attack_(board, attack.attackRow, attack.attackColumn);
                return Ok(result.Equals(AttackStatus.Hit) ? "Hit" : "Miss");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }

    }

   
}
