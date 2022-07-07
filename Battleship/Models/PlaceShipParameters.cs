﻿using Battleship.Enums;
using System;
namespace Battleship.Models
{
    public class PlaceShipParameters
    {
        public int boardRows { get; set; }
        public int boardColumns { get; set; }
        public int PlacementRow { get; set; }
        public int PlacementColumn { get; set; }
        public ShipType ShipType { get; set; }
    }
}
