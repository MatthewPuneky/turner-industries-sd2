using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Builder.States
{
    public class BuilderPatternState
    {
        private BuilderPatternState() { }
        private static BuilderPatternState _instance;
        public static BuilderPatternState Instance => _instance ?? (_instance = new BuilderPatternState());

        public Character Character { get; set; }
        public CharacterBuilder Builder { get; set; }
    }
}
