﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsCharacters.Models
{
    public class CharacterRatingDTO
    {
        public int Id { get; set; }
        [Required]
        public int IdCharacter { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
