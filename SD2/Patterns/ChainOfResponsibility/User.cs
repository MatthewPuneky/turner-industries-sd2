using System.Collections.Generic;

namespace SD2.Patterns.ChainOfResponsibility
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }

    public static class Users
    {
        public static List<User> AllUsers => new List<User>
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
    }
}
