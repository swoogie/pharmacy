using DRUGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DRUGS.Pages.Categories
{
    public class VitaminsModel : PageModel
    {
        public List<MedicineClass> listOfVitamins = new List<MedicineClass>
        {
            new MedicineClass() {ImageTitle = "mollers.png",
                Title = "Moller's Vitamin D",
                Description = "60 capsules",
                Weight = 1200,
                Price = 19.44,
                IsVitamin = true},
            new MedicineClass() {ImageTitle = "vitamincprolong.jpg",
                Title = "Vitamin C Prolong",
                Description = "40 capsules",
                Weight = 1000,
                Price = 8.82,
                IsVitamin = true},
            new MedicineClass() {ImageTitle = "bcomplex.jpg",
                Title = "B Complex",
                Description = "40 capsules",
                Weight = 480,
                Price = 7.45,
                IsVitamin = true},
            new MedicineClass() {ImageTitle = "vitamincproforte.jpg",
                Title = "Vitamin C Pro forte",
                Description = "Grapefruit flavour, 30 capsules",
                Weight = 1500,
                Price = 10.14,
                IsVitamin = true},
            new MedicineClass() {ImageTitle = "magnesium.jpg",
                Title = "Magnesium",
                Description = "90 capsules",
                Weight = 225,
                Price = 16.46,
                IsVitamin = true},
        };
        public void OnGet()
        {
        }
    }
}
