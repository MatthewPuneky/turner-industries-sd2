using System;
using System.Collections.Generic;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode
{
    public class ModernBankingInfo
    {
        public Guid AccountNumber { get; } = Guid.NewGuid();

        public Honorific Honorific { get; set; }
        public string HonorificClosingSymbol => ".";

        public string FirstName { get; }
        public List<string> MiddleNames { get; set; }
        public List<string> LastNames { get; set; }

        public int Balance { get; set; }
        public int DecimalLocation { get; set; } = 2;
    }

    public enum Honorific
    {
        Mr,
        Mrs,
        Ms,
        Dr,
    }
}
