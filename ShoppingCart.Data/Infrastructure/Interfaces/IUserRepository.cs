using ShoppingCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Infrastructure.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByName(string username);

        bool UserEmailExists(string email);

        bool UserExists(string username);
    }
}
