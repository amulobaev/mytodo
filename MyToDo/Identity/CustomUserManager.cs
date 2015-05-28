using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using MyToDo.Core;

namespace MyToDo.Identity
{
    /// <summary>
    /// Custom user manager implementation for ASP.NET Identity
    /// </summary>
    public class CustomUserManager : UserManager<ApplicationUser, Guid>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="store">User store implementation</param>
        public CustomUserManager(IUserStore<ApplicationUser, Guid> store)
            : base(store)
        {
        }

        public override Task<ApplicationUser> FindAsync(string userName, string password)
        {
            return Task<ApplicationUser>.Factory.StartNew(() => Store.FindByNameAsync(userName).Result);
        }

        /// <summary>
        /// Create instance
        /// </summary>
        /// <param name="options">Options</param>
        /// <param name="context">Context</param>
        /// <returns></returns>
        public static CustomUserManager Create(IdentityFactoryOptions<CustomUserManager> options, IOwinContext context)
        {
            return new CustomUserManager(new CustomUserStore());
        }
    }
}