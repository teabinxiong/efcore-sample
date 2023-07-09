using EFCore5WebApp.Core.Entities;
using EFCore5WebApp.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCore5WebApp.Pages.Reports
{
    public class PeopleReportModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public PaginatedList<Person> ReportData { get; set; }
        public PeopleReportModel(AppDbContext context)
        {
            _context = context;
        }
        public async void OnGetAsync(int? pageIndex)
        {
            int pageSize = 10;
            var persons = from p in _context.Persons
                          orderby p.LastName, p.FirstName
                          select p;

            ReportData = await PaginatedList<Person>.CreateAsync(persons, pageIndex ?? 1, pageSize);
            var i = 1;
        }
    }
}
