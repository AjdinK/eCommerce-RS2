namespace eCommerce.Model
{
    public class ProductSearchObject
    {
        public string? Code { get; set; }
        public string? CodeGTE { get; set; }
        public string? FTS { get; set; }
    }
}