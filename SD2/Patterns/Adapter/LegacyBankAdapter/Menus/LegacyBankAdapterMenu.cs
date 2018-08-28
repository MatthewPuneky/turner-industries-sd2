﻿using SD2.Patterns.Adapter.LegacyBankAdapter.AdapterCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.Informationals;
using SD2.Patterns.Adapter.LegacyBankAdapter.LegacyCode;
using SD2.Patterns.Adapter.LegacyBankAdapter.State;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common.Helpers;
using SD2.SharedFeatures.Common;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using static SD2.SharedFeatures.Common.Constants;

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
            Printer.WriteLine("LEGACY BANK ADAPTER");
        }

        protected override void PrintMenuBody()
        {
            Printer.WriteLine($"{(int)LegacyBankAdapterMenuOptions.All}: Display All Accounts");
            Printer.WriteLine($"{(int)LegacyBankAdapterMenuOptions.BankOfFoo}: Display CompanyA Accounts");
            Printer.WriteLine($"{(int)LegacyBankAdapterMenuOptions.BankOfBar}: Display CompanyB Accounts");
            Printer.WriteLine($"{(int)LegacyBankAdapterMenuOptions.CreateNew}: Create New Account");
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
                case LegacyBankAdapterMenuOptions.CreateNew: Printer.WriteLine(Constants.Menu.UnderConstructionToUserResponse); break;
                default:
                    Printer.WriteLine(Constants.Menu.FailedToHandle(option.ToString()));
                    break;
            }

            AdapterInformationalFactory.DisplayMultipleAccountsInformational().Display();
        }

        private void HandleBankOfFooAccounts()
        {
            var adapter = new BankOfFooAccountAdapter();
            State.BankOfFooAccounts.ForEach(fooAccount => {
                adapter.FooAccount = fooAccount;
                IAccountTarget account = adapter;
                State.AccountsToPrint.Add(account);
            });
        }

        private void HandleBankOfBarAccounts()
        {
            var adapter = new BankOfBarAccountAdapter();
            State.BankOfBarAccounts.ForEach(barAccount => {
                adapter.BarAccount = barAccount;
                IAccountTarget account = adapter;
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