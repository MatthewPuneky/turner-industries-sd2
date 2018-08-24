using System.Collections.Generic;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;
using System.Numerics;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public interface IAccountTarget
    {
        string AccountNumber { get; }

        string GetHonorific { get; }
        void SetHonorific(Honorific honorific);

        string GetFirstName { get; set; }

        string GetMiddleName { get; }
        void SetMiddleName(List<string> middleNames);

        string GetLastName { get; }
        void SetLastName(List<string> lastNames);

        (BigInteger balance, int decimalLocation) GetBalance { get; }
        void SetBalance(BigInteger balance, int decimalLocation);
    }
}
