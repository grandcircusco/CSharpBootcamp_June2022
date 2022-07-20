using System;
using System.Collections.Generic;

namespace EFLecture.Models
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            Trainers = new HashSet<Trainer>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? MainType { get; set; }
        public string? SecondType { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
