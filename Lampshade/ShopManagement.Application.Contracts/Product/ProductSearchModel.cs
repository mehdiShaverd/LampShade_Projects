namespace ShopManagement.Application.Contracts.Product
{
    public partial class CreateProduct
    {
        public class ProductSearchModel
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public long CategoryId { get; set; }
        }
    }
}
