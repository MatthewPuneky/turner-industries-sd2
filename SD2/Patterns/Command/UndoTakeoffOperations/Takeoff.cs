using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Command.UndoTakeoffOperations
{
    [Serializable]
    public class Takeoff
    {
        public int Id { get; set; }
        public string DrawingNumber { get; set; }
        public string Abbreviation { get; set; }
        public int Size { get; set; }
        public int ManHours { get; set; }
    }

    public class TakeoffPostDto
    {
        public string DrawingNumber { get; set; }
        public string Abbreviation { get; set; }
        public int Size { get; set; }
    }

    public class TakeoffPutDto : TakeoffPostDto
    {
        public int Id { get; set; }
    }
}
