using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DRUGS.Data;
using DRUGS.Models;

namespace DRUGS.Pages
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Order medicineOrder = new Order();
            medicineOrder.Title = Title;
            medicineOrder.Price = Price;

            _context.Orders.Add(medicineOrder);
            _context.SaveChanges();
        }
    }
}
