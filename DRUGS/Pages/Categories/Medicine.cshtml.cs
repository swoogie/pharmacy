using DRUGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DRUGS.Pages
{
    public class MedicineModel : PageModel
    {
        public List<MedicineClass> listOfMedicine = new List<MedicineClass>
        {
            new MedicineClass() {ImageTitle = "ibuprom.jpg",
                Title = "Ibuprom Express",
                Description = "Ibuprofen, active ingredient amount: 400mg",
                Weight = 200,
                Price = 4,
                IsMedicine = true},
            new MedicineClass() {ImageTitle = "mezym.png",
                Title = "Mezym",
                Description = "MEZYM 10000 V, Tablets, N10",
                Weight = 100,
                Price = 2,
                IsMedicine = true},
            new MedicineClass() {ImageTitle = "bronchipret.jpg",
                Title = "Bronchipret",
                Description = "100 ml, oral solution, N1",
                Weight = 165,
                Price = 6.3,
                IsMedicine = true},
            new MedicineClass() {ImageTitle = "voltaren.jpg",
                Title = "Voltaren Emulgel",
                Description = "23,2 mg/g, 150 g, Gel, N1",
                Weight = 348,
                Price = 14,
                IsMedicine = true},
            new MedicineClass() {ImageTitle = "raphacholin.jpg",
                Title = "Raphacholin",
                Description = "tablets of some sort for your liver I guess lol",
                Weight = 340,
                Price = 6,
                IsMedicine = true},
        };
        public void OnGet()
        {
        }
    }
}
