using System.Collections.Generic;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode
{
    public interface IBankOfBarDataBank
    {
        List<BankOfBarAccount> GetAllBarAccounts();
    }
}
