using System;
using System.Collections.Generic;
using System.Numerics;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode
{
    [Serializable]
    public class BankOfFooAccount
    {
        public Guid AccountNumber { get; } = Guid.NewGuid();

        public Honorific Honorific { get; set; }
        public string HonorificClosingSymbol => ".";

        public string FirstName { get; set; }
        public List<string> MiddleNames { get; set; }
        public List<string> LastNames { get; set; }

        public BigInteger Balance { get; set; }
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
