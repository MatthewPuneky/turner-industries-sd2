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

            Printer.WriteLine();
            Printer.WriteLine("ACCOUNT INFORMATION");
            Printer.WriteLine($"Owner Name: {account.GetHonorific} {account.GetFirstName} {account.GetMiddleName} {account.GetLastName}".Replace("  ", " "));
            Printer.WriteLine($"Account Number: {account.AccountNumber}");
            Printer.WriteLine($"Balance: {stringBalance}");
            Printer.WriteLine();
        }
    }
}
