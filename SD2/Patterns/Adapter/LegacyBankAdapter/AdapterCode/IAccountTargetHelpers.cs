using SD2.Patterns.Adapter.LegacyBankAdapter.State;
using SD2.SharedFeatures.Informationals;
using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode
{
    public class IAccountTargetHelpers
    {
        public static void PrintDescriptions(IAccountTarget account)
        {
            var decimalLocation = account.GetBalance.decimalLocation;
            var stringBalance = account.GetBalance.balance.ToString();

            if (decimalLocation != 0)
            {
                stringBalance = stringBalance.Insert(stringBalance.Length - decimalLocation, ".");
            }

            Printer.PrintLine();
            Printer.PrintLine("ACCOUNT INFORMATION");
            Printer.PrintLine($"Owner Name: {account.GetHonorific} {account.GetFirstName} {account.GetMiddleName} {account.GetLastName}".Replace("  ", " "));
            Printer.PrintLine($"Account Number: {account.AccountNumber}");
            Printer.PrintLine($"Balance: {stringBalance}");
            Printer.PrintLine();
        }
    }
}
