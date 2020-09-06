using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Acess
{
    public class UserResolverService
    {
        private readonly IHttpContextAccessor _context;

        public UserResolverService(IHttpContextAccessor context)
        {
            _context = context;
        }

        #region Methods
        internal string GetUser()
        {
            return _context.HttpContext.User?.Identity?.Name;
        }

        internal string GetToken()
        {
            return ClaimManager.GetUserToken(_context.HttpContext.User);
        }

        internal int GetPessoaId()
        {
            var idPessoa = ClaimManager.GetUserPessoaId(_context.HttpContext.User);
            if (string.IsNullOrWhiteSpace(idPessoa))
            {
                return 0;
            }
            return int.Parse(idPessoa);
        }

        internal int GetId()
        {
            var id = ClaimManager.GetUserId(_context.HttpContext.User);
            if (string.IsNullOrWhiteSpace(id))
            {
                return 0;
            }
            return int.Parse(id);
        }

        internal string GetUserRole()
        {
            return ClaimManager.GetUserRole(_context.HttpContext.User);
        }

        internal string GetFullName()
        {
            return ClaimManager.GetUserFullName(_context.HttpContext.User);
        }
        #endregion
    }
}