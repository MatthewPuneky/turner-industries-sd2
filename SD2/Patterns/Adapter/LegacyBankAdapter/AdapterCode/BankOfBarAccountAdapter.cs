using System.Collections.Generic;
using System.Linq;
using SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.ModernCode;
using System.Numerics;
using System;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public class BankOfBarAccountAdapter : IAccountTarget
    {
        public BankOfBarAccount BarAccount { get; set; }

        public string AccountNumber => BarAccount.AcctNum.ToString();

        public string GetHonorific => BarAccount.HNR;
        public void SetHonorific(Honorific honorific)
        {
            BarAccount.HNR = $"{honorific.ToString()}\\.";
        }

        public string GetFirstName { get => BarAccount.FN; set => BarAccount.FN = value; }

        public string GetMiddleName => BarAccount.MN;
        public void SetMiddleName(List<string> middleNames)
        {
            var middleName = middleNames.Aggregate("", (acc, x) => acc + x + " ");
            var cleanMiddleName = middleName.Trim();
            BarAccount.MN = cleanMiddleName;
        }

        public string GetLastName => BarAccount.SurNM;
        public void SetLastName(List<string> lastNames)
        {
            var lastName = lastNames.Aggregate("", (acc, x) => acc + x + " ");
            var cleanLastName = lastName.Trim();
            BarAccount.SurNM = cleanLastName;
        }

        public (BigInteger balance, int decimalLocation) GetBalance
        {
            get
            {
                var balanceAsString = BarAccount.Bal.ToString();
                var splitBalance = balanceAsString.Split('.');

                if (splitBalance.Length == 1)
                {
                    return (BigInteger.Parse(splitBalance.First()), 0);
                }

                var indexOfDecimal = balanceAsString.IndexOf('.');
                var lengthOfBalanceWithoutDecimal = balanceAsString.Length - 1;
                var decimalLocationInBalance = lengthOfBalanceWithoutDecimal - indexOfDecimal;

                var balanceWithoutDecimal = BigInteger.Parse(splitBalance[0] + splitBalance[1]);

                return (balanceWithoutDecimal, decimalLocationInBalance);
            }
        }
        public void SetBalance(BigInteger balance, int decimalLocation)
        {
            var balanceAsString = balance.ToString();
            var lastIndex = balanceAsString.Length - 1;

            var balanceStringWithDecimal = balanceAsString.Insert(lastIndex - decimalLocation, "\\.");
            var balanceDoubleWithDecimal = double.Parse(balanceStringWithDecimal);

            BarAccount.Bal = balanceDoubleWithDecimal;
        }
    }
}
