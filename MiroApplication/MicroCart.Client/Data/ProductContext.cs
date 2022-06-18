using MicroCart.Client.Models;

namespace MicroCart.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
            Name="Phonexl",
            Description="This phone flagrrrh support",
            ImageFile="Product-1.png",
            Price=950.00M,
            Category="Smart-Phone"
            },
            new Product()
            {
                Name="samsung-10",
            Description="This phone flagh support evvertyuje",
            ImageFile="Product-2.png",
            Price=850.00M,
            Category="Smart-Phone"
            },
            new Product()
            {
            Name="samsung-1",
            Description="This phone flagh supffffport",
            ImageFile="Product-2.png",
            Price=850.00M,
            Category="Smart-Phone"
            }

        };
    }
}
