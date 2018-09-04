using SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.Informationals;
using SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.State;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using static SD2.SharedFeatures.Common.Constants;
using static SD2.SharedFeatures.Helpers.ObjectHelpers;

namespace SD2.Patterns.Adapter.LegacyBankAdapter.Menus
{
    public class LegacyBankAdapterMenu : Menu<LegacyBankAdapterState>
    {
        public LegacyBankAdapterMenu() 
            : base(LegacyBankAdapterState.Instance)
        {
        }

        protected override List<string> LegalValues => EnumHelper.PoistionValuesToStringList(typeof(LegacyBankAdapterMenuOptions));
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("LEGACY BANK ADAPTER");
        }

        protected override void PrintMenuBody()
        {
            Printer.PrintLine($"{(int)LegacyBankAdapterMenuOptions.All}: Display All Accounts");
            Printer.PrintLine($"{(int)LegacyBankAdapterMenuOptions.BankOfFoo}: Display CompanyA Accounts");
            Printer.PrintLine($"{(int)LegacyBankAdapterMenuOptions.BankOfBar}: Display CompanyB Accounts");
            Printer.PrintLine($"{(int)LegacyBankAdapterMenuOptions.CreateNew}: Create New Account");
        }

        protected override void MenuOptions(string userInput)
        {
            State.AccountsToPrint = new List<IAccountTarget>();

            var option = (LegacyBankAdapterMenuOptions)int.Parse(userInput);

            switch(option)
            {
                case LegacyBankAdapterMenuOptions.All:
                    HandleBankOfFooAccounts();
                    HandleBankOfBarAccounts();
                    break;
                case LegacyBankAdapterMenuOptions.BankOfFoo:
                    HandleBankOfFooAccounts();
                    break;
                case LegacyBankAdapterMenuOptions.BankOfBar:
                    HandleBankOfBarAccounts();
                    break;
                case LegacyBankAdapterMenuOptions.CreateNew: Printer.PrintLine(Constants.Menu.UnderConstructionToUserResponse); break;
                default:
                    Printer.PrintLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }

            AdapterInformationalFactory.DisplayMultipleAccountsInformational().Display();
        }

        private void HandleBankOfFooAccounts()
        {
            var adapter = new BankOfFooAccountAdapter();
            State.BankOfFooAccounts.ForEach(fooAccount => {
                adapter.FooAccount = fooAccount;
                IAccountTarget account = DeepClone(adapter);
                State.AccountsToPrint.Add(account);
            });
        }

        private void HandleBankOfBarAccounts()
        {
            var adapter = new BankOfBarAccountAdapter();
            State.BankOfBarAccounts.ForEach(barAccount => {
                adapter.BarAccount = barAccount;
                IAccountTarget account = DeepClone(adapter);
                State.AccountsToPrint.Add(account);
            });
        }
    }

    public enum LegacyBankAdapterMenuOptions
    {
        All = 1,
        BankOfFoo,
        BankOfBar,
        CreateNew
    }
}
