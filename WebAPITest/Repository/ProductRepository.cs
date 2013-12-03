using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using WebAPITest.Core;
using WebAPITest.Models;

namespace WebAPITest.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductModel[] _products = new ProductModel[]
        {
            new ProductModel {Id = 1, Name = "Snickers"},
            new ProductModel {Id = 2, Name = "Pop Tarts"},
            new ProductModel {Id = 3, Name = "Soda"}
        };

        public IEnumerable<ProductModel> GetProducts()
        {
            using (var conn = DatabaseManager.GetOpenConnection())
            {
                IEnumerable<ProductModel> rows = conn.Query<ProductModel>("SELECT * FROM product");
                return rows;
            }
            return null;
            //return _products;
        }

        public ProductModel GetProduct(int id)
        {
            using (var conn = DatabaseManager.GetOpenConnection())
            {
                //var temp = _products.FirstOrDefault(p => p.Id == id);
                var row = conn.Query<ProductModel>("SELECT * FROM product WHERE Id = @Id", new {Id = id}).FirstOrDefault();
                return row;
            }
            return null;
        }

        public int DeleteProduct(int id)
        {
            return 0;
        }

        public int UpdateProduct(ProductModel productModel)
        {
            return 0;
        }
        public int CreateProduct(ProductModel productModel)
        {
            return 0;
        }
    }

}