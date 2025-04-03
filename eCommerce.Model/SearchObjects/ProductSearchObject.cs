namespace eCommerce.Model.SearchObjects
{
    public class ProductSearchObject : BaseSearchObject
    {
        public string? Code { get; set; }

        public string? CodeGTE { get; set; }

        public string? FTS { get; set; }
    }
}