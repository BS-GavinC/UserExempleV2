using UserExemple.Models;

namespace UserExemple.Data
{
    public static class FakeDb
    {
        public static List<User> users = new List<User>()
        {
            new User
            {
                Id = 1,
                Email = "admin@example.com",
                Password = "Test123=",
                IsAdmin = true
            },
            new User
            {
                Id = 2,
                Email = "user@example.com",
                Password = "Test123=",
                IsAdmin = false
            }
        };
    }
}
