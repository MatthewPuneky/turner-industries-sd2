using System.Collections.Generic;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode
{
    public interface IBankOfFooDataBank
    {
        List<BankOfFooAccount> GetAllFooAccounts();
    }
}
