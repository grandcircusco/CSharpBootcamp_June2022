using System;
using System.Collections.Generic;

namespace EFLecture.Models
{
    public partial class Trainer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? FavPokemonId { get; set; }

        public virtual Pokemon? FavPokemon { get; set; }
    }
}
