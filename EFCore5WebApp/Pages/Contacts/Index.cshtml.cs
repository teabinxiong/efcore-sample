using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCore5WebApp.Core.Entities;
using EFCore5WebApp.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace EFCore5WebApp.Pages.Contacts
{
    [Authorize(Roles = PageAccessRoles.AllAccess)]
    public class IndexModel : SecuredPageModel
    {
        private readonly EFCore5WebApp.DAL.AppDbContext _context;

        public IndexModel(
            EFCore5WebApp.DAL.AppDbContext context,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager) 
            : base(context, signInManager, userManager)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
