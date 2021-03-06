using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyCoreApp.Models;

namespace MyCoreApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MyCoreApp.Data.MyCoreAppContext _context;

        public IndexModel(MyCoreApp.Data.MyCoreAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
