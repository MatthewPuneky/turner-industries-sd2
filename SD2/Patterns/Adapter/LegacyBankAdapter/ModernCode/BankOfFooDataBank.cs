using System.Collections.Generic;
using System.Numerics;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode
{
    public class BankOfFooDataBank : IBankOfFooDataBank
    {
        public List<BankOfFooAccount> GetAllFooAccounts() => new List<BankOfFooAccount>
        {
            new BankOfFooAccount
            {
                Honorific = Honorific.Ms,
                FirstName = "Wynell",
                MiddleNames = new List<string>{"Maris"},
                LastNames = new List<string>{"Lafleur"},
                Balance = new BigInteger(3422735),
                DecimalLocation = 2,
            },
            new BankOfFooAccount
            {
                Honorific = Honorific.Dr,
                FirstName = "Enoch",
                MiddleNames = new List<string>{"Luke", "Michael", "Gabriel"},
                LastNames = new List<string>{"Dubay"},
                Balance = new BigInteger(21833170),
                DecimalLocation = 2,
            },
            new BankOfFooAccount
            {
                Honorific = Honorific.Ms,
                FirstName = "Sona",
                MiddleNames = new List<string>{""},
                LastNames = new List<string>{"Phan"},
                Balance = new BigInteger(517497113),
                DecimalLocation = 0,
            },
            new BankOfFooAccount
            {
                Honorific = Honorific.Mr,
                FirstName = "Wilton",
                MiddleNames = new List<string>{"Desmond"},
                LastNames = new List<string>{"Guillermo", "Spann"},
                Balance = new BigInteger(21512),
                DecimalLocation = 2,
            },
            new BankOfFooAccount
            {
                Honorific = Honorific.Mrs,
                FirstName = "Tisa",
                MiddleNames = new List<string>{"Emmy"},
                LastNames = new List<string>{"Irvin"},
                Balance = new BigInteger(327319),
                DecimalLocation = 2,
            },
        };
    }
}
