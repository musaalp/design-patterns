using System.Collections.Generic;

namespace Proxy
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}
