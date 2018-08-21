using System;

namespace SD2.Patterns.ChainOfResponsibility.CacheNodes
{
    public class CachedUser
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                LastVisitDateTime = DateTime.UtcNow;
            }
        }

        public DateTime LastVisitDateTime { get; set; } = DateTime.UtcNow;
    }
}
