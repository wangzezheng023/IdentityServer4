using IdentityS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityS4.Server
{
    public interface IAdminService
    {
        Task<Admin> GetByStr(string userName, string password);
    }
}
