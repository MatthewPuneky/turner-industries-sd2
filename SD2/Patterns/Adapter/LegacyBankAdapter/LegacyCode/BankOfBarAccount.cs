using System;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;
using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode
{
    [Serializable]
    public class BankOfBarAccount
    {
        public int AcctNum { get; set; }

        public string HNR { get; set; }
        public string FN { get; set; }
        public string MN { get; set; }
        public string SurNM { get; set; }

        public double Bal { get; set; }
    }
}
