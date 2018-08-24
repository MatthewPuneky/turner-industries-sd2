using System.Collections.Generic;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode
{
    public class BankOfBarDataBank : IBankOfBarDataBank
    {
        public List<BankOfBarAccount> GetAllBarAccounts() => new List<BankOfBarAccount>
        {
            new BankOfBarAccount
            {
                AcctNum = 6829,
                HNR = "Mr.",
                FN = "Elton",
                MN = "James",
                SurNM = "Dekker",
                Bal = 1695320.03
            },
            new BankOfBarAccount
            {
                AcctNum = 6829,
                HNR = "Mrs.",
                FN = "Nicolle",
                MN = "Wendy",
                SurNM = "Gallagher",
                Bal = 32185.00
            },
            new BankOfBarAccount
            {
                AcctNum = 6829,
                HNR = "Ms.",
                FN = "Keva",
                MN = "Troyer",
                SurNM = "Montijor",
                Bal = 7693.92
            },
            new BankOfBarAccount
            {
                AcctNum = 6829,
                HNR = "Mr.",
                FN = "Jospeh",
                MN = "Bennett",
                SurNM = "Harker",
                Bal = 5318551.12
            },
            new BankOfBarAccount
            {
                AcctNum = 6829,
                HNR = "Mr.",
                FN = "Reid",
                MN = "Titus",
                SurNM = "Cofield",
                Bal = 1694.82
            },
        };
    }
}
