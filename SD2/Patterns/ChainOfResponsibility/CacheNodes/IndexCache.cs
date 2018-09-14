using SD2.SharedFeatures.Printers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SD2.Patterns.ChainOfResponsibility.CacheNodes
{
    public class IndexCache : CacheChainHandler<int, CachedUser>
    {
        private int _fakeUserLimit = 2;

        public static List<CachedUser> _fakeIndexCache { get; } = new List<CachedUser>();

        public override CachedUser HandleRequest(int request)
        {
            Printer.PrintLine("Accessing user from INDEX storage...");

            var cachedUser = _fakeIndexCache.FirstOrDefault(x => x.User.Id == request);

            if (cachedUser != null)
            {
                Printer.PrintLine($"User {cachedUser.User.Id} found");
                cachedUser.LastVisitDateTime = DateTime.UtcNow;
                return cachedUser;
            }
            else if (Successor != null)
            {
                cachedUser = Successor.HandleRequest(request);
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
            if (_fakeIndexCache.Count + 1 > _fakeUserLimit)
            {
                var userToDemote = RemoveOldestCachedUserFromList();
                Printer.PrintLine($"Demoting user id={userToDemote.User.Id} from INDEX to lower cache");
                Successor.HandleResponse(userToDemote);
            }

            response.LastVisitDateTime = DateTime.UtcNow;
            Printer.PrintLine($"Adding user id={response.User.Id} to INDEX cache.");
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
