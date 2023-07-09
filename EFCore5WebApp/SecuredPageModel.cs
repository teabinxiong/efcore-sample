using EFCore5WebApp.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EFCore5WebApp
{
    public class SecuredPageModel : PageModel, IAsyncPageFilter
    {
        private readonly AppDbContext _context;
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        public bool IsAdminUser { get; set; }
        public bool IsViewOnlyUser { get; set; }
        public bool IsAllAllowedUser => IsAdminUser || IsViewOnlyUser;

        public SecuredPageModel(AppDbContext context,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public override  Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            var userId = _userManager.GetUserId(User);
            var user =   _userManager.FindByIdAsync(userId).ConfigureAwait(false).GetAwaiter().GetResult();
            bool isSignedIn = _signInManager.IsSignedIn(User);
            IsAdminUser = isSignedIn &&  _userManager.IsInRoleAsync(user, Roles.AdminRoleName).ConfigureAwait(false).GetAwaiter().GetResult();
            IsViewOnlyUser = isSignedIn &&  _userManager.IsInRoleAsync(user, Roles.ViewOnlyRoleName).ConfigureAwait(false).GetAwaiter().GetResult();
            return base.OnPageHandlerExecutionAsync(context, next);
        }

    
    }
}
