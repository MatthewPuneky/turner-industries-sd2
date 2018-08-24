using System.Collections.Generic;
using System.Linq;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;
using System.Numerics;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public class BankOfFooAccountAdapter : IAccountTarget
    {
        public BankOfFooAccount FooAccount { get; set; }

        public string AccountNumber => FooAccount.AccountNumber.ToString();

        public string GetHonorific => $"{FooAccount.Honorific}{FooAccount.HonorificClosingSymbol}";
        public void SetHonorific(Honorific honorific)
        {
            FooAccount.Honorific = honorific;
        }

        public string GetFirstName { get => FooAccount.FirstName; set => FooAccount.FirstName = value; }

        public string GetMiddleName => FooAccount.MiddleNames.Aggregate("", (acc, x) => acc + x + " ").Trim();
        public void SetMiddleName(List<string> middleNames)
        {
            FooAccount.MiddleNames = middleNames;
        }

        public string GetLastName => FooAccount.LastNames.Aggregate("", (acc, x) => acc + x + " ").Trim();
        public void SetLastName(List<string> lastNames)
        {
            FooAccount.LastNames = lastNames;
        }

        public (BigInteger balance, int decimalLocation) GetBalance => (FooAccount.Balance, FooAccount.DecimalLocation);
        public void SetBalance(BigInteger balance, int decimalLocation)
        {
            FooAccount.Balance = balance;
            FooAccount.DecimalLocation = decimalLocation;
        }
    }
} 
