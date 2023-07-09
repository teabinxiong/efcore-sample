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
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace EFCore5WebApp.Pages.Contacts
{
    [Authorize(Roles = PageAccessRoles.AllAccess)]
    public class DetailsModel : SecuredPageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager) 
            : base(context, signInManager, userManager)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Persons.Include(nameof(Person.Addresses)).FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
