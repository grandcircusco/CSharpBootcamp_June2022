using System;
using System.Collections.Generic;

namespace MovieDatabaseEF.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? Runtime { get; set; }

        public override string ToString()
        {
            return string.Format("Title:{0,-35} Genre:{1,-20} Runtime:{2,-4}",Title, Genre, Runtime);
        }
    }
}
