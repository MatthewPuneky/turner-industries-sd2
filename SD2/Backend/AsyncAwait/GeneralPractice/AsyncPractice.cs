using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SD2.SharedFeatures.Menus;
using SD2.SharedFeatures.Printers;

namespace SD2.Backend.AsyncAwait.GeneralPractice
{
    public class AsyncPractice
    {
        public async Task Start()
        {
            var user = new User {Age = 20};

            var task1 = LongOperationAsync(user);

            var allowedToDrink = AllowedToDrink(user) ? "Yes" : "No";

            var valueFromTask1 = await task1;

            var resultInfo = new List<string>
            {
                $"How old is the user: {valueFromTask1}",
                $"Can the user drink: {allowedToDrink}"
            };

            MenuFactory.SimpleMessagesInformational(resultInfo).Display();
        }

        public async Task<int> LongOperationAsync(User myObject)
        {
            await Task.Delay(50);
            myObject.Age++;
            await Task.Delay(50);

            return myObject.Age;
        }

        public bool AllowedToDrink(User user)
        {
            return user.Age >= 21;
        }
    }

    public class User
    {
        public int Age { get; set; }
    }
}
