using System.Collections.Generic;
using System.Linq;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public class ModernBankAdapter : IBankAdapter
    {
        private ModernBankingInfo _target = new ModernBankingInfo();

        public bool IsLegacy => false;

        public string AccountNumber => _target.AccountNumber.ToString();

        public string GetHonorific => $"{_target.Honorific}{_target.HonorificClosingSymbol}";
        public void SetHonorific(Honorific honorific)
        {
            _target.Honorific = honorific;
        }

        public string GetMiddleName => _target.MiddleNames.Aggregate("", (acc, x) => acc + x + " ").Trim();
        public void SetMiddleName(List<string> middleNames)
        {
            _target.MiddleNames = middleNames;
        }

        public string GetLastName => _target.LastNames.Aggregate("", (acc, x) => acc + x + " ").Trim();
        public void SetLastName(List<string> lastNames)
        {
            _target.LastNames = lastNames;
        }

        public double GetBalance
        {
            get
            {
                var balanceAsString = _target.Balance.ToString();
                var lastIndex = balanceAsString.Length - 1;

                var balanceStringWithDecimal = balanceAsString.Insert(lastIndex - _target.DecimalLocation, "\\.");
                var balanceDoubleWithDecimal = double.Parse(balanceStringWithDecimal);

                return balanceDoubleWithDecimal;
            }
        }

        public void SetBalance(int balance, int decimalLocation)
        {
            _target.Balance = balance;
            _target.DecimalLocation = decimalLocation;
        }
    }
}
