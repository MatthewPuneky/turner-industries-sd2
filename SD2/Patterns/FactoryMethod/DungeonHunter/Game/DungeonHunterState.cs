using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Game
{
    public class DungeonHunterState
    {    
        private static DungeonHunterState _instance => new DungeonHunterState();
        public static DungeonHunterState Instance => _instance;
        private DungeonHunterState() { }
    }
}
