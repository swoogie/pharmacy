using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DRUGS.Models;

namespace DRUGS.Pages.Categories
{
    public class SupplementsModel : PageModel
    {
        public List<MedicineClass> listOfSupplements = new List<MedicineClass>
        {
            new MedicineClass() {ImageTitle = "hairburst.jpg",
                Title = "Hairburst",
                Description = "Supplement for hair growth, 60 capsules",
                Weight = 3000,
                Price = 31.99,
                IsSupplement = true},
            new MedicineClass() {ImageTitle = "imunital.png",
                Title = "Imunital",
                Description = "Shots, 20 doses",
                Weight = 3000,
                Price = 16.96,
                IsSupplement = true},
            new MedicineClass() {ImageTitle = "biocell.png",
                Title = "Biocel",
                Description = "Beauty shots, 25ml x 14 doses",
                Weight = 7280,
                Price = 27.77,
                IsSupplement = true},
            new MedicineClass() {ImageTitle = "liuberin.jpg",
                Title = "Liuberin",
                Description = "eye stuff, 30 capsules",
                Weight = 348,
                Price = 11.86,
                IsSupplement = true},
            new MedicineClass() {ImageTitle = "sapiens.png",
                Title = "Sapiens",
                Description = "Hidrocolagen idk lol",
                Weight = 1030,
                Price = 37.99,
                IsSupplement = true},
        };
        public void OnGet()
        {
        }
    }
}
