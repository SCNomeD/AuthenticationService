using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthenticationService
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public UserRepository()
        {
            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                Login = "Login1",
                FirstName = "FirstName1",
                LastName = "LastName1",
                Email = "Email1@mail.ru",
                Password = "pass1",
                Role = new Role()
                {
                    Id = 1,
                    Name = "Пользователь"
                }
            });

            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                Login = "Login2",
                FirstName = "FirstName2",
                LastName = "LastName2",
                Email = "Email2@mail.ru",
                Password = "pass2",
                Role = new Role()
                {
                    Id = 2,
                    Name = "Администратор"
                }
            });

            _users.Add(new User()
            {
                Id = Guid.NewGuid(),
                Login = "Login3",
                FirstName = "FirstName3",
                LastName = "LastName3",
                Email = "Email3@mail.ru",
                Password = "pass3",
                Role = new Role()
                {
                    Id = 1,
                    Name = "Пользователь"
                }
            });
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetByLogin(string login)
        {
            return _users.FirstOrDefault(v => v.Login == login);
        }
    }
}
