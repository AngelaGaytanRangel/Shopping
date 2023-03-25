using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;

namespace Shopping.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataContext _context;
        public CategoriesController(DataContext context)
        {
            _context = context;
            
        }
        public async Task<IActionResult> Index()
        {
            return _context.Countries != null ?
                        View(await _context.Categories.ToListAsync()) :
                        Problem("Entity set 'DataContext.Countries'  is null.");
        }
    }
}
