using FirstWebApp.Data;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages.Products
{
    public class IndexModel : PageModel
    {

        private MyContext _context;

        /*public IEnumerable<Product> MyProducts { get; set; }*/
        public List<Product> MyProducts { get; set; }
        public IndexModel (MyContext context) //DI
        {
            _context = context;
        }
        public void OnGet()
        {
            /*MyProducts = _context.Products;*/ // for IEnumerable
            MyProducts = _context.Products.ToList();
        }
    }
}
