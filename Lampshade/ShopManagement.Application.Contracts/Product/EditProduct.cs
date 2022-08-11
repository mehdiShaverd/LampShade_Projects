namespace ShopManagement.Application.Contracts.Product
{
    public partial class CreateProduct
    {
        public class EditProduct : CreateProduct
        {
            public long Id { get; set; }
        }
    }
}
