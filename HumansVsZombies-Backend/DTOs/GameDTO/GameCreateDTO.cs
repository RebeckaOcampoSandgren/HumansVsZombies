﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansVsZombies_Backend.DTOs.GameDTO
{
    public class GameCreateDTO
    {
        public string GameName { get; set; }
        public string GameState { get; set; }
        public string Description { get; set; }
        public double? NwLat { get; set; }
        public double? NwLng { get; set; }
        public double? SeLat { get; set; }
        public double? SeLng { get; set; }
    }
}
