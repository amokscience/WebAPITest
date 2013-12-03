using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITest.Models;

namespace WebAPITest.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetProducts();
        ProductModel GetProduct(int id);
        int DeleteProduct(int id);
        int UpdateProduct(ProductModel productModel);
        int CreateProduct(ProductModel productModel);
    }
}
