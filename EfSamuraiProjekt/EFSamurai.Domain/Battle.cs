using System;
using System.Collections.Generic;
using System.Text;

namespace EFSamurai.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Brutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<SamuraiBattles> SamuraiBattles { get; set; }

    }
}
