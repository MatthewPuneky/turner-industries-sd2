using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Command.UndoTakeoffOperations
{
    [Serializable]
    public class Takeoff : TakeoffPutDto
    {
        public int ManHours { get; set; }
    }

    [Serializable]
    public class TakeoffPutDto : TakeoffDto
    {
        public int Id { get; set; }
    }

    [Serializable]
    public class TakeoffDto
    {
        public string DrawingNumber { get; set; }
        public string Abbreviation { get; set; }
        public int Size { get; set; }
    }
}
