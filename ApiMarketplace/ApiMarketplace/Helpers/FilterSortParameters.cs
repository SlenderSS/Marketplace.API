namespace ApiMarketplace.Helpers
{
    public class FilterSortParameters
    {
        public Guid? manufacturerId { get; set; }
        public string? name { get; set; }
        public Guid? sellerId { get; set; }
        public decimal? minPrice { get; set; }
        public decimal? maxPrice { get; set; }
        public string? sortBy { get; set; }
        public bool ascending { get; set; } = true;
        public int page { get; set; } = 1;
        public int size { get; set; } = 10;
    }
}
