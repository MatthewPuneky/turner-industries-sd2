using System;

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

            Console.WriteLine();
            Console.WriteLine("ACCOUNT INFORMATION");
            Console.WriteLine($"Owner Name: {account.GetHonorific} {account.GetFirstName} {account.GetMiddleName} {account.GetLastName}".Replace("  ", " "));
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: {stringBalance}");
            Console.WriteLine();
        }
    }
}
