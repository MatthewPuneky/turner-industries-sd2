using SD2.SharedFeatures.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SD2.Patterns.ChainOfResponsibility.CacheNodes
{
    public class LongTermUserStorage : CacheChainHandler<int, CachedUser>
    {
        public static List<User> _fakeLongTermStorage { get; } = Users.AllUsers;

        public override CachedUser HandleRequest(int request)
        {
            Printer.PrintLine("Accessing user from LONGTERM storage...");
            Thread.Sleep(5000);

            var user = _fakeLongTermStorage.FirstOrDefault(x => x.Id == request);

            return user != null ? new CachedUser { User = user } : null;
        }

        internal override void HandleResponse(CachedUser response)
        {
            Printer.PrintLine($"Incinerated cached user id={response.User.Id} since has aged past the cache.");
        }
    }
}
