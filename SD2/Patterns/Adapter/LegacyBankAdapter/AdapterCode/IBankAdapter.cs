using System.Collections.Generic;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public interface IBankAdapter
    {
        bool IsLegacy { get; }

        string AccountNumber { get; }

        string GetHonorific { get; }
        void SetHonorific(Honorific honorific);

        string GetMiddleName { get; }
        void SetMiddleName(List<string> middleNames);

        string GetLastName { get; }
        void SetLastName(List<string> lastNames);

        double GetBalance { get; }
        void SetBalance(int balance, int decimalLocation);
    }
}
