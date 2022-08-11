namespace ShopManagement.Application.Contracts.Product
{
    public partial class CreateProduct
    {
        public class ProductViewModel
        {
            public long Id { get; set; }
            public string Picture { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string Category { get; set; }
            public long CategoryId { get; set; }
            public string CreationDate { get; set; }

        }
    }
}
