using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public class LegacyBankAdapter : IBankAdapter
    {
        private LegacyBankingInfoWithBadNames _target = new LegacyBankingInfoWithBadNames();

        public bool IsLegacy => true;

        public string AccountNumber => _target.AcctNum.ToString();

        public string GetHonorific => _target.HNR;
        public void SetHonorific(Honorific honorific)
        {
            _target.HNR = $"{honorific.ToString()}\\.";
        }

        public string GetMiddleName => _target.MN;
        public void SetMiddleName(List<string> middleNames)
        {
            var middleName = middleNames.Aggregate("", (acc, x) => acc + x + " ");
            var cleanMiddleName = middleName.Trim();
            _target.MN = cleanMiddleName;
        }

        public string GetLastName => _target.SurNM;
        public void SetLastName(List<string> lastNames)
        {
            var lastName = lastNames.Aggregate("", (acc, x) => acc + x + " ");
            var cleanLastName = lastName.Trim();
            _target.SurNM = cleanLastName;
        }

        public double GetBalance => _target.Bal;
        public void SetBalance(int balance, int decimalLocation)
        {
            var balanceAsString = balance.ToString();
            var lastIndex = balanceAsString.Length - 1;

            var balanceStringWithDecimal = balanceAsString.Insert(lastIndex - decimalLocation, "\\.");
            var balanceDoubleWithDecimal = double.Parse(balanceStringWithDecimal);

            _target.Bal = balanceDoubleWithDecimal;
        }
    }
}
