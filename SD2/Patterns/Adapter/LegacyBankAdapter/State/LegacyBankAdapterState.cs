using SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;
using System.Collections.Generic;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.State
{
    public class LegacyBankAdapterState
    {
        private LegacyBankAdapterState() { }
        private static LegacyBankAdapterState _instance;
        public static LegacyBankAdapterState Instance => _instance ?? (_instance = new LegacyBankAdapterState());

        public List<BankOfFooAccount> BankOfFooAccounts { get; set; } = new BankOfFooDataBank().GetAllFooAccounts();
        public List<BankOfBarAccount> BankOfBarAccounts { get; set; } = new BankOfBarDataBank().GetAllBarAccounts();
        public List<IAccountTarget> AccountsToPrint { get; set; } = new List<IAccountTarget>();
    }
}
