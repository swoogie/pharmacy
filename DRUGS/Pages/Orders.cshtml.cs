using DRUGS.Data;
using DRUGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DRUGS.Pages
{
    public class OrdersModel : PageModel
    {
        public List<Order> Orders = new List<Order>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Orders = _context.Orders.ToList();


        }
    }
}
