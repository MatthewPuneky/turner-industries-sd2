using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SD2.Patterns.ChainOfResponsibility.CacheNodes
{
    public class LinkedListCache : CacheChainHandler<int, CachedUser>
    {
        private int fakeUserLimit = 5;

        public static List<CachedUser> _fakeIndexCache { get; private set; } = new List<CachedUser>();

        public override CachedUser HandleRequest(int request)
        {
            Console.WriteLine("Accessing user from LINK storage...");
            Thread.Sleep(1000);

            var cachedUser = _fakeIndexCache.FirstOrDefault(x => x.User.Id == request);

            if (cachedUser != null)
            {
                Console.WriteLine($"User {cachedUser.User.Id} found");
                cachedUser.LastVisitDateTime = DateTime.UtcNow;
                return cachedUser;
            }
            else if (_successor != null)
            {
                cachedUser = _successor.HandleRequest(request);
                HandleResponse(cachedUser);
                return cachedUser;
            }

            throw new Exception("User was unable to be found");
        }

        internal override void HandleResponse(CachedUser response)
        {
            if (response == null) return;

            if (_fakeIndexCache.Any(x => x.User.Id == response.User.Id))
            {
                return;
            }
            if (_fakeIndexCache.Count + 1 > fakeUserLimit)
            {
                var userToDemote = RemoveOldestCachedUserFromList();
                Console.WriteLine($"Demoting user id={userToDemote.User.Id} from LINK to lower cache");
                _successor.HandleResponse(userToDemote);
            }

            response.LastVisitDateTime = DateTime.UtcNow;
            Console.WriteLine($"Adding user id={response.User.Id} to LINK cache.");
            _fakeIndexCache.Add(response);
        }

        private CachedUser RemoveOldestCachedUserFromList()
        {
            var userToRemove = _fakeIndexCache.OrderBy(x => x.LastVisitDateTime).First();
            _fakeIndexCache.Remove(userToRemove);

            return userToRemove;
        }
    }
}
