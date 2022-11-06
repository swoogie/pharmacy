namespace DRUGS.Models
{
    public class MedicineClass
    {
        public string ImageTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public bool InBasket { get; set; } = false;
        public bool IsMedicine { get; set; } = false;
        public bool IsSupplement { get; set; } = false;
        public bool IsVitamin { get; set; } = false;
        public bool IsRecreational { get; set; } = false;
    }
}
