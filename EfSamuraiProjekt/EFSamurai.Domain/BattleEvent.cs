using System;
using System.Collections.Generic;
using System.Text;

namespace EFSamurai.Domain
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public int BattleLogId { get; set; }
        public BattleLog BattleLogs { get; set; }
    }
}
