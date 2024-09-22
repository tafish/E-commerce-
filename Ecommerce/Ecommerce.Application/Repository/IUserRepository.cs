using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IUserRepository : IRepository<User>
    {

        Task AssignRoleToUserAsync(int userId, int roleId);
    }
}
