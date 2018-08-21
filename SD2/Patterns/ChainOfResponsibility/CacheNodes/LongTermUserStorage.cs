using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SD2.Patterns.ChainOfResponsibility.CacheNodes
{
    public class LongTermUserStorage : CacheChainHandler<int, CachedUser>
    {
        public static List<User> _fakeLongTermStorage { get; private set; } = new List<User>
        {
            new User { Id = 1, Username = "Bob" },
            new User { Id = 2, Username = "Joe" },
            new User { Id = 3, Username = "Buck" },
            new User { Id = 4, Username = "Jill" },
            new User { Id = 5, Username = "Sam" },
            new User { Id = 6, Username = "Harry" },
            new User { Id = 7, Username = "Will" },
            new User { Id = 8, Username = "Chad" },
            new User { Id = 9, Username = "Derek" },
            new User { Id = 10, Username = "Matt" },
            new User { Id = 11, Username = "Justin" },
            new User { Id = 12, Username = "Stephen" },
        };

        public override CachedUser HandleRequest(int request)
        {
            Console.WriteLine("Accessing user from LONGTERM storage...");
            Thread.Sleep(5000);

            var user = _fakeLongTermStorage.FirstOrDefault(x => x.Id == request);

            return user != null ? new CachedUser { User = user } : null;
        }

        internal override void HandleResponse(CachedUser response)
        {
            Console.WriteLine($"Incinerated cached user id={response.User.Id} since has aged past the cache.");
        }
    }
}
