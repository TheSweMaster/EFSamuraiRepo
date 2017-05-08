using System;
using System.Collections.Generic;
using System.Text;

namespace EFSamurai.Domain
{
    public class SamuraiBattles
    {
        public int Id { get; set; }
        public int SamuraiId { get; set; }
        public Samurai Samurais { get; set; }
        public int BattleId { get; set; }
        public Battle Battles { get; set; }
    }
}
