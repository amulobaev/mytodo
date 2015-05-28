using System;
using Microsoft.AspNet.Identity;

namespace MyToDo.Core
{
    public class ApplicationUser : IUser<Guid>
    {
        public ApplicationUser()
        {
        }

        public ApplicationUser(string userName)
        {
            Id = Guid.NewGuid();
            UserName = userName;
        }

        public ApplicationUser(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
