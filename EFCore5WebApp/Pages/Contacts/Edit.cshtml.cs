using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCore5WebApp.Core.Entities;
using EFCore5WebApp.DAL;

namespace EFCore5WebApp.Pages.Contacts
{
    public class EditModel : PageModel
    {
        private readonly EFCore5WebApp.DAL.AppDbContext _context;

        public EditModel(EFCore5WebApp.DAL.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Person Person { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> States { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> Countries { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Persons.Include("Addresses").FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }

            var lookups = _context.LookUps.Where(x => new List<LookUpType>
            {
                LookUpType.State, LookUpType.Country
            }.Contains(x.LookUpType)).ToList();

            States = lookups.Where(x => x.LookUpType == LookUpType.State).Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = x.Code
            }).ToList();

            Countries = lookups.Where(x => x.LookUpType == LookUpType.Country).Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = x.Code
            }).ToList();

            States.Insert(0, new SelectListItem
            {
                Text = "Select State",
                Value = string.Empty
            });

            Countries.Insert(0, new SelectListItem
            {
                Text = "Select Country",
                Value = string.Empty
            });

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                            .Where(y => y.Count > 0)
                            .ToList();
                return Page();
            }
           

            _context.Attach(Person).State = EntityState.Modified;


            var address = _context.Addresses.ToList();
            address = Person.Addresses;
            _context.Addresses.Update(address[0]);

            try
            {
               await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(Person.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.Id == id);
        }
    }
}
