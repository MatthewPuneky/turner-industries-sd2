using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.ChainOfResponsibility.Menus
{
    public class FindUserMenu : Menu<StorageState>
    {
        public FindUserMenu() 
            : base(StorageState.Instance)
        {
        }

        private UserFinder _userFinder = new UserFinder();

        protected override List<string> LegalValues => Users.AllUsers.Select(x => x.Id.ToString()).ToList();
        protected override bool CanExit => true;

        protected override void PrintMenuHeader()
        {
            Printer.PrintLine("FIND USER MENU");
        }

        protected override void PrintMenuBody()
        {
            var options = Users.AllUsers;
            var maxOptionWidth = options.Count.ToString().Length;

            foreach (var option in options)
            {
                Printer.PrintLine($"{option.Id.ToString().PadLeft(maxOptionWidth)}: {option.Username}");
            }
        }

        protected override void MenuOptions(string userInput)
        {
            if (userInput == "0")
            {
                MenuIsActive = false;
                return;
            }

            var selectedId = int.Parse(userInput);
            _userFinder.Find(selectedId);
        }
    }
}
