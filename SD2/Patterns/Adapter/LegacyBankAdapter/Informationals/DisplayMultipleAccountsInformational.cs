using System.Collections.Generic;
using SD2.Patterns.Adapter.LegacyBankAdapter.State;
using SD2.SharedFeatures.Informationals;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.Informationals
{
    public class DisplayMultipleAccountsInformational : Informational<LegacyBankAdapterState>
    {
        public DisplayMultipleAccountsInformational()
            : base(LegacyBankAdapterState.Instance)
        {
        }

        protected override IEnumerable<string> LoadLinesToDisplay()
        {
            foreach (var account in State.AccountsToPrint)
            {
                var decimalLocation = account.GetBalance.decimalLocation;
                var stringBalance = account.GetBalance.balance.ToString();

                if (decimalLocation != 0)
                {
                    stringBalance = stringBalance.Insert(stringBalance.Length - decimalLocation, ".");
                }

                yield return "ACCOUNT INFORMATION";
                yield return $"Owner Name: {account.GetHonorific} {account.GetFirstName} {account.GetMiddleName} {account.GetLastName}".Replace("  ", " ");
                yield return $"Account Number: {account.AccountNumber}";
                yield return $"Balance: {stringBalance}";
                yield return "";
            }
        }
    }
}
